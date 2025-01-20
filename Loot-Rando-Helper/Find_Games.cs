using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace BL2_Test_Loot_Rando
{
    public static class Find_Games
    {
        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static List<string> Search_Registry_For_Steam_BL2()
        {
            List<string> steam_library_folders = new List<string>();

            //string steam32 = "SOFTWARE\\VALVE\\";
            //string steam64 = "SOFTWARE\\Wow6432Node\\Valve\\";
            string steam32path;
            string steam64path;
            string config32path;
            string config64path;
            RegistryKey key32 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\VALVE\\");
            RegistryKey key64 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Valve\\");

            if (key32 == null && key64 == null)
            {
                return steam_library_folders;
            }

            if (key64.ToString() == null || key64.ToString() == "")
            {
                foreach (string k32subKey in key32.GetSubKeyNames())
                {
                    using (RegistryKey subKey = key32.OpenSubKey(k32subKey))
                    {
                        steam32path = subKey.GetValue("InstallPath").ToString();
                        config32path = steam32path + "/steamapps/libraryfolders.vdf";
                        string driveRegex = @"[A-Z]:\\";
                        if (File.Exists(config32path))
                        {
                            string[] configLines = File.ReadAllLines(config32path);
                            foreach (var item in configLines)
                            {
                                Console.WriteLine("32:  " + item);
                                Match match = Regex.Match(item, driveRegex);
                                if (item != string.Empty && match.Success)
                                {
                                    string matched = match.ToString();
                                    string item2 = item.Substring(item.IndexOf(matched));
                                    item2 = item2.Replace("\\\\", "\\");
                                    item2 = item2.Replace("\"", "\\steamapps\\common\\");

                                    steam_library_folders.Add(item2);
                                }
                            }

                            steam_library_folders.Add(steam32path + "\\steamapps\\common\\");
                        }
                    }
                }
            }

            foreach (string k64subKey in key64.GetSubKeyNames())
            {
                using (RegistryKey subKey = key64.OpenSubKey(k64subKey))
                {
                    var x = subKey.GetValue("InstallPath");

                    if (x != null)
                    {
                        steam64path = x.ToString();
                        config64path = steam64path + "/steamapps/libraryfolders.vdf";
                        string driveRegex = @"[A-Z]:\\";
                        if (File.Exists(config64path))
                        {
                            string[] configLines = File.ReadAllLines(config64path);
                            foreach (var item in configLines)
                            {
                                Console.WriteLine("64:  " + item);
                                Match match = Regex.Match(item, driveRegex);
                                if (item != string.Empty && match.Success)
                                {
                                    string matched = match.ToString();
                                    string item2 = item.Substring(item.IndexOf(matched));
                                    item2 = item2.Replace("\\\\", "\\");
                                    item2 = item2.Replace("\"", "\\steamapps\\common\\");

                                    if (!steam_library_folders.Contains(item2))
                                        steam_library_folders.Add(item2);
                                }
                            }

                            string path = steam64path + "\\steamapps\\common\\";
                            if (!steam_library_folders.Contains(path))
                                steam_library_folders.Add(path);
                        }
                    }
                }
            }

            return steam_library_folders;
        }
    }
}