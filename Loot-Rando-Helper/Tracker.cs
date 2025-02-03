using System.Text.Json;
using Octokit;

namespace BL2_Test_Loot_Rando;

public class Tracker
{
    private const string SETTINGS_FILE = "trackerSettings.json";
    private const string SEED_LIST = "Seed List.txt";
    private readonly FileSystemWatcher _watcher;
    private readonly Settings _settings;
    private readonly string _seedsPath;

    public Tracker(string seedsPath)
    {
        try
        {
            _settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(SETTINGS_FILE));
        }
        catch (Exception)
        {
            _settings = new Settings();
        }
        
        _seedsPath = seedsPath;
        
        _watcher = new FileSystemWatcher(_seedsPath);
        _watcher.Created += WatcherEvent;
        _watcher.Changed += WatcherEvent;

        CheckExistingSeeds();
    }

    public void SetToken(string token)
    {
        _settings.Token = token;
        File.WriteAllText(SETTINGS_FILE, JsonSerializer.Serialize(_settings.Gist, new JsonSerializerOptions(JsonSerializerOptions.Default) {WriteIndented = true}));
    }

    public bool Start()
    {
        if (_settings.Token == null)
        {
            return false;
        }
        
        _watcher.EnableRaisingEvents = true;
        return true;
    }
    
    public void Shutdown()
    {
        _watcher.EnableRaisingEvents = false;
        _watcher.Dispose();
    }

    public string GetTrackerUrl()
    {
        return _settings.Gist?.Url ?? string.Empty;
    }

    private void CheckExistingSeeds()
    {
        string latestSeed = GetLatestSeed();

        if (!string.IsNullOrEmpty(latestSeed))
        {
            UpdateSeed(latestSeed);
        }
    }

    private string GetLatestSeed()
    {
        return Directory.GetFiles(_seedsPath)
            .Where(seed => !seed.EndsWith(SEED_LIST))
            .Aggregate((seed1, seed2) => new FileInfo(seed1).LastWriteTime > new FileInfo(seed2).LastWriteTime ? seed1 : seed2);
    }
    
    private void WatcherEvent(object sender, FileSystemEventArgs e)
    {
        UpdateSeed(e.FullPath);
    }

    private async void UpdateSeed(string path)
    {
        if (path.EndsWith(SEED_LIST) || string.IsNullOrEmpty(_settings.Token))
        {
            return;
        }
        
        try
        {
            string seed = Path.GetFileNameWithoutExtension(path);
            string trackerContents = File.ReadAllText(path);

            GitHubClient client = new GitHubClient(new ProductHeaderValue("bl2-loot-randomizer-tracker"));
            client.Credentials = new Credentials(_settings.Token);

            Gist result;
            if (_settings.Gist?.CurrentSeed.Equals(seed) ?? false)
            {
                result = await client.Gist.Edit(_settings.Gist.Id, new GistUpdate {Description = $"Tracker for {seed}", 
                    Files = {{$"{seed}.txt", new GistFileUpdate {Content = trackerContents}}}});
            }
            else if (_settings.Gist != null)
            {
                string gistId = _settings.Gist.Id;
                string previousSeed = _settings.Gist.CurrentSeed;
                
                result = await client.Gist.Edit(gistId, new GistUpdate {Description = $"Tracker for {seed}", Files =
                    {
                        {$"{seed}.txt", new GistFileUpdate {Content = trackerContents}},
                        {$"{previousSeed}.txt", new GistFileUpdate {Content = string.Empty}}
                    }
                });
            }
            else
            {
                result = await client.Gist.Create(new NewGist {Description = $"Tracker for {seed}", Public = true, Files = {{$"{seed}.txt", trackerContents}}});
            }

            _settings.Gist = new GistInformation {CurrentSeed = seed, Id = result.Id, Url = result.HtmlUrl};

            File.WriteAllText(SETTINGS_FILE, JsonSerializer.Serialize(_settings.Gist, new JsonSerializerOptions(JsonSerializerOptions.Default) {WriteIndented = true}));
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
    
    public class GistInformation
    {
        public string CurrentSeed { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
    }
    
    public class Settings
    {
        public string Token { get; set; }
        public GistInformation Gist { get; set; }
    }
}