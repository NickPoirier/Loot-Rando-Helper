namespace BL2_Test_Loot_Rando
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "All", "", "", "" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Assault Rifle", "", "", "" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Pistol", "", "", "" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Rocket Launcher", "", "", "" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Shotgun", "", "", "" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "SMG", "", "", "" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Sniper", "", "", "" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "All", "", "", "" }, -1);
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "Class Mod", "", "", "" }, -1);
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "Grenade", "", "", "" }, -1);
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Relic", "", "", "" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "Shield", "", "", "" }, -1);
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tc = new TabControl();
            seeds_tp = new TabPage();
            seed_tc = new TabControl();
            seed_tc_seed_tp = new TabPage();
            found_seeds_sc = new SplitContainer();
            seed_dgv = new DataGridView();
            seed_col_filename = new DataGridViewTextBoxColumn();
            seed_col_date = new DataGridViewTextBoxColumn();
            seed_col_locations = new DataGridViewTextBoxColumn();
            seed_col_items = new DataGridViewTextBoxColumn();
            seed_col_nothings = new DataGridViewTextBoxColumn();
            seed_col_hints = new DataGridViewTextBoxColumn();
            label31 = new Label();
            web_seed_tb = new TextBox();
            load_web_seed_button = new Button();
            seed_browse_button = new Button();
            seed_tlp = new TableLayoutPanel();
            label6 = new Label();
            seed_label_3 = new Label();
            seed_rtb_3 = new RichTextBox();
            seed_label_2 = new Label();
            seed_rtb_2 = new RichTextBox();
            seed_rtb_1 = new RichTextBox();
            vh_flow_layout_panel = new FlowLayoutPanel();
            vh_maya_button = new Button();
            vh_axton_button = new Button();
            vh_sal_button = new Button();
            vh_zero_button = new Button();
            vh_krieg_button = new Button();
            vh_gaige_button = new Button();
            vh_all_button = new Button();
            seed_label_1 = new Label();
            seed_load_button = new Button();
            selected_seed_rtb = new RichTextBox();
            label5 = new Label();
            seed_tc_steam_tp = new TabPage();
            label1 = new Label();
            seeds_folder_rtb = new RichTextBox();
            steam_library_folders_rtb = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            bl2_folder_rtb = new RichTextBox();
            weap_tp = new TabPage();
            weap_tlp = new TableLayoutPanel();
            weap_panel = new Panel();
            weap_show_not_found_rb = new RadioButton();
            weap_show_found_rb = new RadioButton();
            weap_show_all_rb = new RadioButton();
            weap_sniper_button = new Button();
            weap_smg_button = new Button();
            weap_shotgun_button = new Button();
            weap_launcher_button = new Button();
            weap_pistol_button = new Button();
            weap_ar_button = new Button();
            weap_all_button = new Button();
            weap_toggle_totals_button = new Button();
            weap_sc = new SplitContainer();
            all_weap_lv = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            weap_dgv = new DataGridView();
            weap_col_found = new DataGridViewCheckBoxColumn();
            weap_col_name = new DataGridViewTextBoxColumn();
            weap_col_type = new DataGridViewTextBoxColumn();
            weap_col_rarity = new DataGridViewTextBoxColumn();
            weap_col_source = new DataGridViewTextBoxColumn();
            weap_col_source_area = new DataGridViewTextBoxColumn();
            weap_col_rate = new DataGridViewTextBoxColumn();
            weap_col_hint = new DataGridViewTextBoxColumn();
            weap_col_options = new DataGridViewTextBoxColumn();
            item_tp = new TabPage();
            items_tlp = new TableLayoutPanel();
            item_panel = new Panel();
            item_show_not_found_rb = new RadioButton();
            item_show_found_rb = new RadioButton();
            item_show_all_rb = new RadioButton();
            item_shield_button = new Button();
            item_grenade_button = new Button();
            item_relic_button = new Button();
            item_com_button = new Button();
            item_all_button = new Button();
            item_toggle_totals_button = new Button();
            item_sc = new SplitContainer();
            all_item_lv = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            item_dgv = new DataGridView();
            item_col_found = new DataGridViewCheckBoxColumn();
            item_col_name = new DataGridViewTextBoxColumn();
            item_col_type = new DataGridViewTextBoxColumn();
            item_col_rarity = new DataGridViewTextBoxColumn();
            item_col_source = new DataGridViewTextBoxColumn();
            item_col_source_area = new DataGridViewTextBoxColumn();
            item_col_rate = new DataGridViewTextBoxColumn();
            item_col_hint = new DataGridViewTextBoxColumn();
            item_col_options = new DataGridViewTextBoxColumn();
            area_tp = new TabPage();
            area_sc_1 = new SplitContainer();
            area_sc_3 = new SplitContainer();
            areas_sc_4 = new SplitContainer();
            area_names_lv = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            area_maps_lv = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            area_sc_4 = new SplitContainer();
            area_map_name_label = new Label();
            area_show_all_rb = new RadioButton();
            area_show_not_found_rb = new RadioButton();
            area_show_found_rb = new RadioButton();
            area_dgv = new DataGridView();
            area_col_found = new DataGridViewCheckBoxColumn();
            area_col_type = new DataGridViewTextBoxColumn();
            area_col_name = new DataGridViewTextBoxColumn();
            area_col_reward = new DataGridViewTextBoxColumn();
            area_col_source = new DataGridViewTextBoxColumn();
            area_col_rate = new DataGridViewTextBoxColumn();
            area_col_options = new DataGridViewTextBoxColumn();
            hint_tp = new TabPage();
            hint_sc_1 = new SplitContainer();
            hint_sc_2 = new SplitContainer();
            hint_total_label = new Label();
            hint_dgv_2 = new DataGridView();
            hint2_col_hint = new DataGridViewTextBoxColumn();
            hint2_col_name = new DataGridViewTextBoxColumn();
            hint2_col_mission = new DataGridViewTextBoxColumn();
            hint2_col_map = new DataGridViewTextBoxColumn();
            hint2_col_options = new DataGridViewTextBoxColumn();
            hint_sc_3 = new SplitContainer();
            hint_show_not_found_rb = new RadioButton();
            hint_comboBox = new ComboBox();
            hint_show_found_rb = new RadioButton();
            label4 = new Label();
            hint_show_all_rb = new RadioButton();
            hint_dgv = new DataGridView();
            hint_col_found = new DataGridViewCheckBoxColumn();
            hint_col_hint = new DataGridViewTextBoxColumn();
            hint_col_name = new DataGridViewTextBoxColumn();
            hint_col_source = new DataGridViewTextBoxColumn();
            hint_col_source_area = new DataGridViewTextBoxColumn();
            hint_col_options = new DataGridViewTextBoxColumn();
            dupes_tp = new TabPage();
            duplicates_sc = new SplitContainer();
            dupe_description_label = new Label();
            dupe_dgv = new DataGridView();
            dupe_col_found = new DataGridViewCheckBoxColumn();
            dupe_col_name = new DataGridViewTextBoxColumn();
            dupe_col_type = new DataGridViewTextBoxColumn();
            dupe_col_rarity = new DataGridViewTextBoxColumn();
            dupe_col_source = new DataGridViewTextBoxColumn();
            dupe_col_area = new DataGridViewTextBoxColumn();
            dupe_col_rate = new DataGridViewTextBoxColumn();
            dupe_col_hint = new DataGridViewTextBoxColumn();
            dupe_col_options = new DataGridViewTextBoxColumn();
            search_tp = new TabPage();
            sc3 = new SplitContainer();
            last_search_label = new Label();
            label8 = new Label();
            search_rtb = new RichTextBox();
            sc2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            meo_search_dgv = new DataGridView();
            meo_search_found_col = new DataGridViewCheckBoxColumn();
            meo_search_type_col = new DataGridViewTextBoxColumn();
            meo_search_name_col = new DataGridViewTextBoxColumn();
            meo_search_reward_col = new DataGridViewTextBoxColumn();
            meo_search_source_col = new DataGridViewTextBoxColumn();
            meo_search_rate_col = new DataGridViewTextBoxColumn();
            meo_search_options_col = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            label10 = new Label();
            loot_search_dgv = new DataGridView();
            loot_search_found_col = new DataGridViewCheckBoxColumn();
            loot_search_name_col = new DataGridViewTextBoxColumn();
            loot_search_type_col = new DataGridViewTextBoxColumn();
            loot_search_rarity_col = new DataGridViewTextBoxColumn();
            loot_search_source_col = new DataGridViewTextBoxColumn();
            loot_search_source_area_col = new DataGridViewTextBoxColumn();
            loot_search_rate_col = new DataGridViewTextBoxColumn();
            loot_search_hint_col = new DataGridViewTextBoxColumn();
            loot_search_options_col = new DataGridViewTextBoxColumn();
            testing_tp = new TabPage();
            six_life_tlp = new TableLayoutPanel();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            six_life_random_button = new Button();
            label13 = new Label();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            seed_file_dlg = new OpenFileDialog();
            tc.SuspendLayout();
            seeds_tp.SuspendLayout();
            seed_tc.SuspendLayout();
            seed_tc_seed_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)found_seeds_sc).BeginInit();
            found_seeds_sc.Panel1.SuspendLayout();
            found_seeds_sc.Panel2.SuspendLayout();
            found_seeds_sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seed_dgv).BeginInit();
            seed_tlp.SuspendLayout();
            vh_flow_layout_panel.SuspendLayout();
            seed_tc_steam_tp.SuspendLayout();
            weap_tp.SuspendLayout();
            weap_tlp.SuspendLayout();
            weap_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weap_sc).BeginInit();
            weap_sc.Panel1.SuspendLayout();
            weap_sc.Panel2.SuspendLayout();
            weap_sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weap_dgv).BeginInit();
            item_tp.SuspendLayout();
            items_tlp.SuspendLayout();
            item_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)item_sc).BeginInit();
            item_sc.Panel1.SuspendLayout();
            item_sc.Panel2.SuspendLayout();
            item_sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)item_dgv).BeginInit();
            area_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)area_sc_1).BeginInit();
            area_sc_1.Panel2.SuspendLayout();
            area_sc_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)area_sc_3).BeginInit();
            area_sc_3.Panel1.SuspendLayout();
            area_sc_3.Panel2.SuspendLayout();
            area_sc_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)areas_sc_4).BeginInit();
            areas_sc_4.Panel1.SuspendLayout();
            areas_sc_4.Panel2.SuspendLayout();
            areas_sc_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)area_sc_4).BeginInit();
            area_sc_4.Panel1.SuspendLayout();
            area_sc_4.Panel2.SuspendLayout();
            area_sc_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)area_dgv).BeginInit();
            hint_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hint_sc_1).BeginInit();
            hint_sc_1.Panel1.SuspendLayout();
            hint_sc_1.Panel2.SuspendLayout();
            hint_sc_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hint_sc_2).BeginInit();
            hint_sc_2.Panel1.SuspendLayout();
            hint_sc_2.Panel2.SuspendLayout();
            hint_sc_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hint_dgv_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hint_sc_3).BeginInit();
            hint_sc_3.Panel1.SuspendLayout();
            hint_sc_3.Panel2.SuspendLayout();
            hint_sc_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hint_dgv).BeginInit();
            dupes_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)duplicates_sc).BeginInit();
            duplicates_sc.Panel1.SuspendLayout();
            duplicates_sc.Panel2.SuspendLayout();
            duplicates_sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dupe_dgv).BeginInit();
            search_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc3).BeginInit();
            sc3.Panel1.SuspendLayout();
            sc3.Panel2.SuspendLayout();
            sc3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc2).BeginInit();
            sc2.Panel1.SuspendLayout();
            sc2.Panel2.SuspendLayout();
            sc2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meo_search_dgv).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loot_search_dgv).BeginInit();
            testing_tp.SuspendLayout();
            six_life_tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tc
            // 
            tc.Controls.Add(seeds_tp);
            tc.Controls.Add(weap_tp);
            tc.Controls.Add(item_tp);
            tc.Controls.Add(area_tp);
            tc.Controls.Add(hint_tp);
            tc.Controls.Add(dupes_tp);
            tc.Controls.Add(search_tp);
            tc.Controls.Add(testing_tp);
            tc.Controls.Add(tabPage1);
            tc.Dock = DockStyle.Fill;
            tc.ItemSize = new Size(160, 40);
            tc.Location = new Point(0, 0);
            tc.Margin = new Padding(4);
            tc.Name = "tc";
            tc.Padding = new Point(20, 3);
            tc.SelectedIndex = 0;
            tc.Size = new Size(1380, 921);
            tc.TabIndex = 0;
            // 
            // seeds_tp
            // 
            seeds_tp.Controls.Add(seed_tc);
            seeds_tp.Location = new Point(4, 44);
            seeds_tp.Name = "seeds_tp";
            seeds_tp.Padding = new Padding(3);
            seeds_tp.Size = new Size(1372, 873);
            seeds_tp.TabIndex = 0;
            seeds_tp.Text = "Seeds";
            seeds_tp.UseVisualStyleBackColor = true;
            // 
            // seed_tc
            // 
            seed_tc.Controls.Add(seed_tc_seed_tp);
            seed_tc.Controls.Add(seed_tc_steam_tp);
            seed_tc.Dock = DockStyle.Fill;
            seed_tc.Location = new Point(3, 3);
            seed_tc.Name = "seed_tc";
            seed_tc.Padding = new Point(20, 3);
            seed_tc.SelectedIndex = 0;
            seed_tc.Size = new Size(1366, 867);
            seed_tc.TabIndex = 24;
            // 
            // seed_tc_seed_tp
            // 
            seed_tc_seed_tp.Controls.Add(found_seeds_sc);
            seed_tc_seed_tp.Location = new Point(4, 28);
            seed_tc_seed_tp.Name = "seed_tc_seed_tp";
            seed_tc_seed_tp.Padding = new Padding(3);
            seed_tc_seed_tp.Size = new Size(1358, 835);
            seed_tc_seed_tp.TabIndex = 0;
            seed_tc_seed_tp.Text = "Found Seeds";
            seed_tc_seed_tp.UseVisualStyleBackColor = true;
            // 
            // found_seeds_sc
            // 
            found_seeds_sc.Dock = DockStyle.Fill;
            found_seeds_sc.FixedPanel = FixedPanel.Panel2;
            found_seeds_sc.Location = new Point(3, 3);
            found_seeds_sc.Name = "found_seeds_sc";
            found_seeds_sc.Orientation = Orientation.Horizontal;
            // 
            // found_seeds_sc.Panel1
            // 
            found_seeds_sc.Panel1.Controls.Add(seed_dgv);
            // 
            // found_seeds_sc.Panel2
            // 
            found_seeds_sc.Panel2.Controls.Add(label31);
            found_seeds_sc.Panel2.Controls.Add(web_seed_tb);
            found_seeds_sc.Panel2.Controls.Add(load_web_seed_button);
            found_seeds_sc.Panel2.Controls.Add(seed_browse_button);
            found_seeds_sc.Panel2.Controls.Add(seed_tlp);
            found_seeds_sc.Panel2.Controls.Add(seed_load_button);
            found_seeds_sc.Panel2.Controls.Add(selected_seed_rtb);
            found_seeds_sc.Panel2.Controls.Add(label5);
            found_seeds_sc.Size = new Size(1352, 829);
            found_seeds_sc.SplitterDistance = 325;
            found_seeds_sc.TabIndex = 0;
            // 
            // seed_dgv
            // 
            seed_dgv.AllowUserToAddRows = false;
            seed_dgv.AllowUserToDeleteRows = false;
            seed_dgv.AllowUserToResizeRows = false;
            seed_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            seed_dgv.Columns.AddRange(new DataGridViewColumn[] { seed_col_filename, seed_col_date, seed_col_locations, seed_col_items, seed_col_nothings, seed_col_hints });
            seed_dgv.Dock = DockStyle.Fill;
            seed_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            seed_dgv.Location = new Point(0, 0);
            seed_dgv.MultiSelect = false;
            seed_dgv.Name = "seed_dgv";
            seed_dgv.ReadOnly = true;
            seed_dgv.RowHeadersVisible = false;
            seed_dgv.ScrollBars = ScrollBars.Vertical;
            seed_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            seed_dgv.ShowEditingIcon = false;
            seed_dgv.Size = new Size(1352, 325);
            seed_dgv.TabIndex = 19;
            seed_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            seed_dgv.SelectionChanged += seed_dgv_SelectionChanged;
            // 
            // seed_col_filename
            // 
            seed_col_filename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            seed_col_filename.FillWeight = 20F;
            seed_col_filename.HeaderText = "Filename";
            seed_col_filename.Name = "seed_col_filename";
            seed_col_filename.ReadOnly = true;
            seed_col_filename.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // seed_col_date
            // 
            seed_col_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            seed_col_date.FillWeight = 20F;
            seed_col_date.HeaderText = "Date Modified";
            seed_col_date.Name = "seed_col_date";
            seed_col_date.ReadOnly = true;
            seed_col_date.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // seed_col_locations
            // 
            seed_col_locations.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            seed_col_locations.FillWeight = 10F;
            seed_col_locations.HeaderText = "Total Locations";
            seed_col_locations.Name = "seed_col_locations";
            seed_col_locations.ReadOnly = true;
            seed_col_locations.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // seed_col_items
            // 
            seed_col_items.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            seed_col_items.FillWeight = 20F;
            seed_col_items.HeaderText = "Total Items";
            seed_col_items.Name = "seed_col_items";
            seed_col_items.ReadOnly = true;
            seed_col_items.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // seed_col_nothings
            // 
            seed_col_nothings.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            seed_col_nothings.FillWeight = 20F;
            seed_col_nothings.HeaderText = "Nothings or Duplicates";
            seed_col_nothings.Name = "seed_col_nothings";
            seed_col_nothings.ReadOnly = true;
            seed_col_nothings.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // seed_col_hints
            // 
            seed_col_hints.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            seed_col_hints.FillWeight = 10F;
            seed_col_hints.HeaderText = "Found Hints";
            seed_col_hints.Name = "seed_col_hints";
            seed_col_hints.ReadOnly = true;
            seed_col_hints.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(259, 104);
            label31.Name = "label31";
            label31.Size = new Size(153, 19);
            label31.TabIndex = 27;
            label31.Text = "GitHub Seed URL:";
            // 
            // web_seed_tb
            // 
            web_seed_tb.Location = new Point(429, 101);
            web_seed_tb.Name = "web_seed_tb";
            web_seed_tb.Size = new Size(892, 26);
            web_seed_tb.TabIndex = 26;
            web_seed_tb.Text = "https://gist.github.com/NickPoirier/60729e9e740e1e1738096341edacbc2e";
            // 
            // load_web_seed_button
            // 
            load_web_seed_button.Location = new Point(12, 89);
            load_web_seed_button.Name = "load_web_seed_button";
            load_web_seed_button.Size = new Size(212, 48);
            load_web_seed_button.TabIndex = 25;
            load_web_seed_button.Text = "Load GitHub Seed";
            load_web_seed_button.UseVisualStyleBackColor = true;
            load_web_seed_button.Click += load_web_seed_button_Click;
            // 
            // seed_browse_button
            // 
            seed_browse_button.Location = new Point(12, 22);
            seed_browse_button.Name = "seed_browse_button";
            seed_browse_button.Size = new Size(212, 48);
            seed_browse_button.TabIndex = 24;
            seed_browse_button.Text = "Browse to seed...";
            seed_browse_button.UseVisualStyleBackColor = true;
            seed_browse_button.Click += seed_browse_button_Click;
            // 
            // seed_tlp
            // 
            seed_tlp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            seed_tlp.ColumnCount = 4;
            seed_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            seed_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            seed_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            seed_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            seed_tlp.Controls.Add(label6, 0, 0);
            seed_tlp.Controls.Add(seed_label_3, 3, 0);
            seed_tlp.Controls.Add(seed_rtb_3, 3, 1);
            seed_tlp.Controls.Add(seed_label_2, 2, 0);
            seed_tlp.Controls.Add(seed_rtb_2, 2, 1);
            seed_tlp.Controls.Add(seed_rtb_1, 1, 1);
            seed_tlp.Controls.Add(vh_flow_layout_panel, 0, 1);
            seed_tlp.Controls.Add(seed_label_1, 1, 0);
            seed_tlp.Location = new Point(12, 152);
            seed_tlp.Name = "seed_tlp";
            seed_tlp.RowCount = 2;
            seed_tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            seed_tlp.RowStyles.Add(new RowStyle());
            seed_tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            seed_tlp.Size = new Size(1334, 340);
            seed_tlp.TabIndex = 23;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(327, 32);
            label6.TabIndex = 25;
            label6.Text = "Vault Hunter COMs";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seed_label_3
            // 
            seed_label_3.Dock = DockStyle.Fill;
            seed_label_3.Location = new Point(1002, 0);
            seed_label_3.Name = "seed_label_3";
            seed_label_3.Size = new Size(329, 32);
            seed_label_3.TabIndex = 5;
            seed_label_3.Text = "Miscellaneous";
            seed_label_3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seed_rtb_3
            // 
            seed_rtb_3.Dock = DockStyle.Fill;
            seed_rtb_3.Location = new Point(1002, 35);
            seed_rtb_3.Name = "seed_rtb_3";
            seed_rtb_3.Size = new Size(329, 302);
            seed_rtb_3.TabIndex = 2;
            seed_rtb_3.Text = "\n   ON - Mob Farms\n  OFF - Raids\n   ON - Mission Locations\n  OFF - Special Vendors\n   ON - Miscellaneous\n  OFF - Duplicate Items\n   ON - Allow Hints\n";
            // 
            // seed_label_2
            // 
            seed_label_2.Dock = DockStyle.Fill;
            seed_label_2.Location = new Point(669, 0);
            seed_label_2.Name = "seed_label_2";
            seed_label_2.Size = new Size(327, 32);
            seed_label_2.TabIndex = 4;
            seed_label_2.Text = "Missions and Enemies";
            seed_label_2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seed_rtb_2
            // 
            seed_rtb_2.Dock = DockStyle.Fill;
            seed_rtb_2.Location = new Point(669, 35);
            seed_rtb_2.Name = "seed_rtb_2";
            seed_rtb_2.Size = new Size(327, 302);
            seed_rtb_2.TabIndex = 1;
            seed_rtb_2.Text = resources.GetString("seed_rtb_2.Text");
            // 
            // seed_rtb_1
            // 
            seed_rtb_1.Dock = DockStyle.Fill;
            seed_rtb_1.Location = new Point(336, 35);
            seed_rtb_1.Name = "seed_rtb_1";
            seed_rtb_1.Size = new Size(327, 302);
            seed_rtb_1.TabIndex = 0;
            seed_rtb_1.Text = resources.GetString("seed_rtb_1.Text");
            // 
            // vh_flow_layout_panel
            // 
            vh_flow_layout_panel.Controls.Add(vh_maya_button);
            vh_flow_layout_panel.Controls.Add(vh_axton_button);
            vh_flow_layout_panel.Controls.Add(vh_sal_button);
            vh_flow_layout_panel.Controls.Add(vh_zero_button);
            vh_flow_layout_panel.Controls.Add(vh_krieg_button);
            vh_flow_layout_panel.Controls.Add(vh_gaige_button);
            vh_flow_layout_panel.Controls.Add(vh_all_button);
            vh_flow_layout_panel.Dock = DockStyle.Fill;
            vh_flow_layout_panel.Location = new Point(3, 35);
            vh_flow_layout_panel.Name = "vh_flow_layout_panel";
            vh_flow_layout_panel.Size = new Size(327, 302);
            vh_flow_layout_panel.TabIndex = 7;
            // 
            // vh_maya_button
            // 
            vh_maya_button.Image = Properties.Resources.maya;
            vh_maya_button.Location = new Point(3, 3);
            vh_maya_button.Name = "vh_maya_button";
            vh_maya_button.Size = new Size(100, 100);
            vh_maya_button.TabIndex = 24;
            vh_maya_button.UseVisualStyleBackColor = false;
            vh_maya_button.Click += vh_button_Click;
            // 
            // vh_axton_button
            // 
            vh_axton_button.Image = Properties.Resources.axton;
            vh_axton_button.Location = new Point(109, 3);
            vh_axton_button.Name = "vh_axton_button";
            vh_axton_button.Size = new Size(100, 100);
            vh_axton_button.TabIndex = 25;
            vh_axton_button.UseVisualStyleBackColor = true;
            vh_axton_button.Click += vh_button_Click;
            // 
            // vh_sal_button
            // 
            vh_sal_button.Image = Properties.Resources.sal;
            vh_sal_button.Location = new Point(215, 3);
            vh_sal_button.Name = "vh_sal_button";
            vh_sal_button.Size = new Size(100, 100);
            vh_sal_button.TabIndex = 26;
            vh_sal_button.UseVisualStyleBackColor = true;
            vh_sal_button.Click += vh_button_Click;
            // 
            // vh_zero_button
            // 
            vh_zero_button.Image = Properties.Resources.zero;
            vh_zero_button.Location = new Point(3, 109);
            vh_zero_button.Name = "vh_zero_button";
            vh_zero_button.Size = new Size(100, 100);
            vh_zero_button.TabIndex = 27;
            vh_zero_button.UseVisualStyleBackColor = true;
            vh_zero_button.Click += vh_button_Click;
            // 
            // vh_krieg_button
            // 
            vh_krieg_button.Image = Properties.Resources.krieg;
            vh_krieg_button.Location = new Point(109, 109);
            vh_krieg_button.Name = "vh_krieg_button";
            vh_krieg_button.Size = new Size(100, 100);
            vh_krieg_button.TabIndex = 29;
            vh_krieg_button.UseVisualStyleBackColor = true;
            vh_krieg_button.Click += vh_button_Click;
            // 
            // vh_gaige_button
            // 
            vh_gaige_button.Image = Properties.Resources.gaige;
            vh_gaige_button.Location = new Point(215, 109);
            vh_gaige_button.Name = "vh_gaige_button";
            vh_gaige_button.Size = new Size(100, 100);
            vh_gaige_button.TabIndex = 28;
            vh_gaige_button.UseVisualStyleBackColor = true;
            vh_gaige_button.Click += vh_button_Click;
            // 
            // vh_all_button
            // 
            vh_all_button.BackColor = Color.LightGreen;
            vh_all_button.Location = new Point(3, 215);
            vh_all_button.Name = "vh_all_button";
            vh_all_button.Size = new Size(312, 50);
            vh_all_button.TabIndex = 30;
            vh_all_button.Text = "Show All COMs";
            vh_all_button.UseVisualStyleBackColor = false;
            vh_all_button.Click += vh_button_Click;
            // 
            // seed_label_1
            // 
            seed_label_1.Dock = DockStyle.Fill;
            seed_label_1.Location = new Point(336, 0);
            seed_label_1.Name = "seed_label_1";
            seed_label_1.Size = new Size(327, 32);
            seed_label_1.TabIndex = 3;
            seed_label_1.Text = "Areas";
            seed_label_1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seed_load_button
            // 
            seed_load_button.Location = new Point(244, 22);
            seed_load_button.Name = "seed_load_button";
            seed_load_button.Size = new Size(212, 48);
            seed_load_button.TabIndex = 22;
            seed_load_button.Text = "Load selected seed";
            seed_load_button.UseVisualStyleBackColor = true;
            seed_load_button.Click += seed_load_button_Click;
            // 
            // selected_seed_rtb
            // 
            selected_seed_rtb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selected_seed_rtb.Location = new Point(595, 23);
            selected_seed_rtb.Name = "selected_seed_rtb";
            selected_seed_rtb.Size = new Size(726, 47);
            selected_seed_rtb.TabIndex = 21;
            selected_seed_rtb.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 27);
            label5.Name = "label5";
            label5.Size = new Size(90, 38);
            label5.TabIndex = 20;
            label5.Text = "Seed File\r\nLoaded:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // seed_tc_steam_tp
            // 
            seed_tc_steam_tp.BackColor = Color.LightGray;
            seed_tc_steam_tp.Controls.Add(label1);
            seed_tc_steam_tp.Controls.Add(seeds_folder_rtb);
            seed_tc_steam_tp.Controls.Add(steam_library_folders_rtb);
            seed_tc_steam_tp.Controls.Add(label3);
            seed_tc_steam_tp.Controls.Add(label2);
            seed_tc_steam_tp.Controls.Add(bl2_folder_rtb);
            seed_tc_steam_tp.Location = new Point(4, 24);
            seed_tc_steam_tp.Name = "seed_tc_steam_tp";
            seed_tc_steam_tp.Padding = new Padding(3);
            seed_tc_steam_tp.Size = new Size(1358, 839);
            seed_tc_steam_tp.TabIndex = 1;
            seed_tc_steam_tp.Text = "Steam Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(405, 19);
            label1.TabIndex = 13;
            label1.Text = "Steam library folders found in the registry:";
            // 
            // seeds_folder_rtb
            // 
            seeds_folder_rtb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            seeds_folder_rtb.Location = new Point(17, 393);
            seeds_folder_rtb.Name = "seeds_folder_rtb";
            seeds_folder_rtb.Size = new Size(1323, 46);
            seeds_folder_rtb.TabIndex = 17;
            seeds_folder_rtb.Text = "";
            // 
            // steam_library_folders_rtb
            // 
            steam_library_folders_rtb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            steam_library_folders_rtb.Location = new Point(17, 39);
            steam_library_folders_rtb.Name = "steam_library_folders_rtb";
            steam_library_folders_rtb.ScrollBars = RichTextBoxScrollBars.Vertical;
            steam_library_folders_rtb.Size = new Size(1323, 195);
            steam_library_folders_rtb.TabIndex = 12;
            steam_library_folders_rtb.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 371);
            label3.Name = "label3";
            label3.Size = new Size(207, 19);
            label3.TabIndex = 16;
            label3.Text = "BL2 Loot Rando Folder:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 259);
            label2.Name = "label2";
            label2.Size = new Size(189, 19);
            label2.TabIndex = 14;
            label2.Text = "Detected BL2 folder:";
            // 
            // bl2_folder_rtb
            // 
            bl2_folder_rtb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bl2_folder_rtb.Location = new Point(17, 281);
            bl2_folder_rtb.Name = "bl2_folder_rtb";
            bl2_folder_rtb.Size = new Size(1323, 46);
            bl2_folder_rtb.TabIndex = 15;
            bl2_folder_rtb.Text = "";
            // 
            // weap_tp
            // 
            weap_tp.Controls.Add(weap_tlp);
            weap_tp.Location = new Point(4, 44);
            weap_tp.Name = "weap_tp";
            weap_tp.Padding = new Padding(3);
            weap_tp.Size = new Size(1372, 873);
            weap_tp.TabIndex = 1;
            weap_tp.Text = "Weapons";
            weap_tp.UseVisualStyleBackColor = true;
            // 
            // weap_tlp
            // 
            weap_tlp.ColumnCount = 1;
            weap_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            weap_tlp.Controls.Add(weap_panel, 0, 0);
            weap_tlp.Controls.Add(weap_sc, 0, 1);
            weap_tlp.Dock = DockStyle.Fill;
            weap_tlp.Location = new Point(3, 3);
            weap_tlp.Name = "weap_tlp";
            weap_tlp.RowCount = 2;
            weap_tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            weap_tlp.RowStyles.Add(new RowStyle());
            weap_tlp.Size = new Size(1366, 867);
            weap_tlp.TabIndex = 3;
            // 
            // weap_panel
            // 
            weap_panel.AutoScroll = true;
            weap_panel.Controls.Add(weap_show_not_found_rb);
            weap_panel.Controls.Add(weap_show_found_rb);
            weap_panel.Controls.Add(weap_show_all_rb);
            weap_panel.Controls.Add(weap_sniper_button);
            weap_panel.Controls.Add(weap_smg_button);
            weap_panel.Controls.Add(weap_shotgun_button);
            weap_panel.Controls.Add(weap_launcher_button);
            weap_panel.Controls.Add(weap_pistol_button);
            weap_panel.Controls.Add(weap_ar_button);
            weap_panel.Controls.Add(weap_all_button);
            weap_panel.Controls.Add(weap_toggle_totals_button);
            weap_panel.Dock = DockStyle.Fill;
            weap_panel.Location = new Point(3, 3);
            weap_panel.Name = "weap_panel";
            weap_panel.Size = new Size(1360, 100);
            weap_panel.TabIndex = 1;
            // 
            // weap_show_not_found_rb
            // 
            weap_show_not_found_rb.AutoSize = true;
            weap_show_not_found_rb.Location = new Point(505, 16);
            weap_show_not_found_rb.Name = "weap_show_not_found_rb";
            weap_show_not_found_rb.Size = new Size(153, 23);
            weap_show_not_found_rb.TabIndex = 17;
            weap_show_not_found_rb.Text = "Show Not Found";
            weap_show_not_found_rb.UseVisualStyleBackColor = true;
            weap_show_not_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // weap_show_found_rb
            // 
            weap_show_found_rb.AutoSize = true;
            weap_show_found_rb.Location = new Point(356, 16);
            weap_show_found_rb.Name = "weap_show_found_rb";
            weap_show_found_rb.Size = new Size(117, 23);
            weap_show_found_rb.TabIndex = 16;
            weap_show_found_rb.Text = "Show Found";
            weap_show_found_rb.UseVisualStyleBackColor = true;
            weap_show_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // weap_show_all_rb
            // 
            weap_show_all_rb.AutoSize = true;
            weap_show_all_rb.Checked = true;
            weap_show_all_rb.Location = new Point(163, 16);
            weap_show_all_rb.Name = "weap_show_all_rb";
            weap_show_all_rb.Size = new Size(162, 23);
            weap_show_all_rb.TabIndex = 15;
            weap_show_all_rb.TabStop = true;
            weap_show_all_rb.Text = "Show Everything";
            weap_show_all_rb.UseVisualStyleBackColor = true;
            weap_show_all_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // weap_sniper_button
            // 
            weap_sniper_button.Location = new Point(694, 52);
            weap_sniper_button.Name = "weap_sniper_button";
            weap_sniper_button.Size = new Size(110, 36);
            weap_sniper_button.TabIndex = 9;
            weap_sniper_button.Text = "Sniper";
            weap_sniper_button.UseVisualStyleBackColor = true;
            weap_sniper_button.Click += Show_Weapon_Type_button_Click;
            // 
            // weap_smg_button
            // 
            weap_smg_button.Location = new Point(579, 52);
            weap_smg_button.Name = "weap_smg_button";
            weap_smg_button.Size = new Size(110, 36);
            weap_smg_button.TabIndex = 8;
            weap_smg_button.Text = "SMG";
            weap_smg_button.UseVisualStyleBackColor = true;
            weap_smg_button.Click += Show_Weapon_Type_button_Click;
            // 
            // weap_shotgun_button
            // 
            weap_shotgun_button.Location = new Point(464, 52);
            weap_shotgun_button.Name = "weap_shotgun_button";
            weap_shotgun_button.Size = new Size(110, 36);
            weap_shotgun_button.TabIndex = 7;
            weap_shotgun_button.Text = "Shotgun";
            weap_shotgun_button.UseVisualStyleBackColor = true;
            weap_shotgun_button.Click += Show_Weapon_Type_button_Click;
            // 
            // weap_launcher_button
            // 
            weap_launcher_button.Location = new Point(233, 52);
            weap_launcher_button.Name = "weap_launcher_button";
            weap_launcher_button.Size = new Size(110, 36);
            weap_launcher_button.TabIndex = 6;
            weap_launcher_button.Text = "Launcher";
            weap_launcher_button.UseVisualStyleBackColor = true;
            weap_launcher_button.Click += Show_Weapon_Type_button_Click;
            // 
            // weap_pistol_button
            // 
            weap_pistol_button.Location = new Point(348, 52);
            weap_pistol_button.Name = "weap_pistol_button";
            weap_pistol_button.Size = new Size(110, 36);
            weap_pistol_button.TabIndex = 5;
            weap_pistol_button.Text = "Pistol";
            weap_pistol_button.UseVisualStyleBackColor = true;
            weap_pistol_button.Click += Show_Weapon_Type_button_Click;
            // 
            // weap_ar_button
            // 
            weap_ar_button.Location = new Point(118, 52);
            weap_ar_button.Name = "weap_ar_button";
            weap_ar_button.Size = new Size(110, 36);
            weap_ar_button.TabIndex = 4;
            weap_ar_button.Text = "AR";
            weap_ar_button.UseVisualStyleBackColor = true;
            weap_ar_button.Click += Show_Weapon_Type_button_Click;
            // 
            // weap_all_button
            // 
            weap_all_button.BackColor = Color.LightGreen;
            weap_all_button.Location = new Point(3, 52);
            weap_all_button.Name = "weap_all_button";
            weap_all_button.Size = new Size(110, 36);
            weap_all_button.TabIndex = 3;
            weap_all_button.Text = "All";
            weap_all_button.UseVisualStyleBackColor = false;
            weap_all_button.Click += Show_Weapon_Type_button_Click;
            // 
            // weap_toggle_totals_button
            // 
            weap_toggle_totals_button.Location = new Point(3, 10);
            weap_toggle_totals_button.Name = "weap_toggle_totals_button";
            weap_toggle_totals_button.Size = new Size(135, 36);
            weap_toggle_totals_button.TabIndex = 2;
            weap_toggle_totals_button.Text = "Hide Totals";
            weap_toggle_totals_button.UseVisualStyleBackColor = true;
            weap_toggle_totals_button.Click += weap_toggle_totals_button_Click;
            // 
            // weap_sc
            // 
            weap_sc.Dock = DockStyle.Fill;
            weap_sc.FixedPanel = FixedPanel.Panel1;
            weap_sc.IsSplitterFixed = true;
            weap_sc.Location = new Point(3, 109);
            weap_sc.Name = "weap_sc";
            weap_sc.Orientation = Orientation.Horizontal;
            // 
            // weap_sc.Panel1
            // 
            weap_sc.Panel1.Controls.Add(all_weap_lv);
            // 
            // weap_sc.Panel2
            // 
            weap_sc.Panel2.Controls.Add(weap_dgv);
            weap_sc.Size = new Size(1360, 755);
            weap_sc.SplitterDistance = 195;
            weap_sc.TabIndex = 2;
            // 
            // all_weap_lv
            // 
            all_weap_lv.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            all_weap_lv.Dock = DockStyle.Fill;
            all_weap_lv.FullRowSelect = true;
            all_weap_lv.GridLines = true;
            listViewItem2.StateImageIndex = 0;
            all_weap_lv.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7 });
            all_weap_lv.Location = new Point(0, 0);
            all_weap_lv.Name = "all_weap_lv";
            all_weap_lv.Size = new Size(1360, 195);
            all_weap_lv.TabIndex = 2;
            all_weap_lv.UseCompatibleStateImageBehavior = false;
            all_weap_lv.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Type";
            columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Found";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Total";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Percent";
            columnHeader8.Width = 90;
            // 
            // weap_dgv
            // 
            weap_dgv.AllowUserToAddRows = false;
            weap_dgv.AllowUserToDeleteRows = false;
            weap_dgv.AllowUserToResizeRows = false;
            weap_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            weap_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weap_dgv.Columns.AddRange(new DataGridViewColumn[] { weap_col_found, weap_col_name, weap_col_type, weap_col_rarity, weap_col_source, weap_col_source_area, weap_col_rate, weap_col_hint, weap_col_options });
            weap_dgv.Dock = DockStyle.Fill;
            weap_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            weap_dgv.Location = new Point(0, 0);
            weap_dgv.MultiSelect = false;
            weap_dgv.Name = "weap_dgv";
            weap_dgv.ReadOnly = true;
            weap_dgv.RowHeadersVisible = false;
            weap_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            weap_dgv.ShowEditingIcon = false;
            weap_dgv.Size = new Size(1360, 556);
            weap_dgv.TabIndex = 3;
            weap_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            weap_dgv.MouseClick += dgv_MouseClick;
            weap_dgv.MouseUp += dgv_MouseUp;
            // 
            // weap_col_found
            // 
            weap_col_found.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            weap_col_found.HeaderText = "Found";
            weap_col_found.Name = "weap_col_found";
            weap_col_found.ReadOnly = true;
            weap_col_found.Resizable = DataGridViewTriState.True;
            weap_col_found.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_found.Width = 65;
            // 
            // weap_col_name
            // 
            weap_col_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_name.HeaderText = "Name";
            weap_col_name.Name = "weap_col_name";
            weap_col_name.ReadOnly = true;
            weap_col_name.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_name.Width = 70;
            // 
            // weap_col_type
            // 
            weap_col_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_type.HeaderText = "Type";
            weap_col_type.Name = "weap_col_type";
            weap_col_type.ReadOnly = true;
            weap_col_type.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_type.Width = 70;
            // 
            // weap_col_rarity
            // 
            weap_col_rarity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_rarity.HeaderText = "Rarity";
            weap_col_rarity.Name = "weap_col_rarity";
            weap_col_rarity.ReadOnly = true;
            weap_col_rarity.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_rarity.Width = 88;
            // 
            // weap_col_source
            // 
            weap_col_source.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_source.HeaderText = "Source";
            weap_col_source.Name = "weap_col_source";
            weap_col_source.ReadOnly = true;
            weap_col_source.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_source.Width = 88;
            // 
            // weap_col_source_area
            // 
            weap_col_source_area.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_source_area.HeaderText = "Source Area";
            weap_col_source_area.Name = "weap_col_source_area";
            weap_col_source_area.ReadOnly = true;
            weap_col_source_area.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_source_area.Width = 133;
            // 
            // weap_col_rate
            // 
            weap_col_rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_rate.HeaderText = "Drop Rate";
            weap_col_rate.Name = "weap_col_rate";
            weap_col_rate.ReadOnly = true;
            weap_col_rate.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_rate.Width = 115;
            // 
            // weap_col_hint
            // 
            weap_col_hint.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_hint.HeaderText = "Hint";
            weap_col_hint.Name = "weap_col_hint";
            weap_col_hint.ReadOnly = true;
            weap_col_hint.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_hint.Visible = false;
            // 
            // weap_col_options
            // 
            weap_col_options.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            weap_col_options.HeaderText = "Options";
            weap_col_options.Name = "weap_col_options";
            weap_col_options.ReadOnly = true;
            weap_col_options.SortMode = DataGridViewColumnSortMode.Programmatic;
            weap_col_options.Visible = false;
            // 
            // item_tp
            // 
            item_tp.Controls.Add(items_tlp);
            item_tp.Location = new Point(4, 44);
            item_tp.Name = "item_tp";
            item_tp.Padding = new Padding(3);
            item_tp.Size = new Size(1372, 873);
            item_tp.TabIndex = 2;
            item_tp.Text = "Items";
            item_tp.UseVisualStyleBackColor = true;
            // 
            // items_tlp
            // 
            items_tlp.ColumnCount = 1;
            items_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            items_tlp.Controls.Add(item_panel, 0, 0);
            items_tlp.Controls.Add(item_sc, 0, 1);
            items_tlp.Dock = DockStyle.Fill;
            items_tlp.Location = new Point(3, 3);
            items_tlp.Name = "items_tlp";
            items_tlp.RowCount = 2;
            items_tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            items_tlp.RowStyles.Add(new RowStyle());
            items_tlp.Size = new Size(1366, 867);
            items_tlp.TabIndex = 4;
            // 
            // item_panel
            // 
            item_panel.AutoScroll = true;
            item_panel.Controls.Add(item_show_not_found_rb);
            item_panel.Controls.Add(item_show_found_rb);
            item_panel.Controls.Add(item_show_all_rb);
            item_panel.Controls.Add(item_shield_button);
            item_panel.Controls.Add(item_grenade_button);
            item_panel.Controls.Add(item_relic_button);
            item_panel.Controls.Add(item_com_button);
            item_panel.Controls.Add(item_all_button);
            item_panel.Controls.Add(item_toggle_totals_button);
            item_panel.Dock = DockStyle.Fill;
            item_panel.Location = new Point(3, 3);
            item_panel.Name = "item_panel";
            item_panel.Size = new Size(1360, 100);
            item_panel.TabIndex = 1;
            // 
            // item_show_not_found_rb
            // 
            item_show_not_found_rb.AutoSize = true;
            item_show_not_found_rb.Location = new Point(505, 16);
            item_show_not_found_rb.Name = "item_show_not_found_rb";
            item_show_not_found_rb.Size = new Size(153, 23);
            item_show_not_found_rb.TabIndex = 14;
            item_show_not_found_rb.Text = "Show Not Found";
            item_show_not_found_rb.UseVisualStyleBackColor = true;
            item_show_not_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // item_show_found_rb
            // 
            item_show_found_rb.AutoSize = true;
            item_show_found_rb.Location = new Point(356, 16);
            item_show_found_rb.Name = "item_show_found_rb";
            item_show_found_rb.Size = new Size(117, 23);
            item_show_found_rb.TabIndex = 13;
            item_show_found_rb.Text = "Show Found";
            item_show_found_rb.UseVisualStyleBackColor = true;
            item_show_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // item_show_all_rb
            // 
            item_show_all_rb.AutoSize = true;
            item_show_all_rb.Checked = true;
            item_show_all_rb.Location = new Point(163, 16);
            item_show_all_rb.Name = "item_show_all_rb";
            item_show_all_rb.Size = new Size(162, 23);
            item_show_all_rb.TabIndex = 12;
            item_show_all_rb.TabStop = true;
            item_show_all_rb.Text = "Show Everything";
            item_show_all_rb.UseVisualStyleBackColor = true;
            item_show_all_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // item_shield_button
            // 
            item_shield_button.Location = new Point(464, 52);
            item_shield_button.Name = "item_shield_button";
            item_shield_button.Size = new Size(110, 36);
            item_shield_button.TabIndex = 7;
            item_shield_button.Text = "Shield";
            item_shield_button.UseVisualStyleBackColor = true;
            item_shield_button.Click += Show_Item_Button_Click;
            // 
            // item_grenade_button
            // 
            item_grenade_button.Location = new Point(233, 52);
            item_grenade_button.Name = "item_grenade_button";
            item_grenade_button.Size = new Size(110, 36);
            item_grenade_button.TabIndex = 6;
            item_grenade_button.Text = "Grenade";
            item_grenade_button.UseVisualStyleBackColor = true;
            item_grenade_button.Click += Show_Item_Button_Click;
            // 
            // item_relic_button
            // 
            item_relic_button.Location = new Point(348, 52);
            item_relic_button.Name = "item_relic_button";
            item_relic_button.Size = new Size(110, 36);
            item_relic_button.TabIndex = 5;
            item_relic_button.Text = "Relic";
            item_relic_button.UseVisualStyleBackColor = true;
            item_relic_button.Click += Show_Item_Button_Click;
            // 
            // item_com_button
            // 
            item_com_button.Location = new Point(118, 52);
            item_com_button.Name = "item_com_button";
            item_com_button.Size = new Size(110, 36);
            item_com_button.TabIndex = 4;
            item_com_button.Text = "Class Mod";
            item_com_button.UseVisualStyleBackColor = true;
            item_com_button.Click += Show_Item_Button_Click;
            // 
            // item_all_button
            // 
            item_all_button.BackColor = Color.LightGreen;
            item_all_button.Location = new Point(3, 52);
            item_all_button.Name = "item_all_button";
            item_all_button.Size = new Size(110, 36);
            item_all_button.TabIndex = 3;
            item_all_button.Text = "All";
            item_all_button.UseVisualStyleBackColor = false;
            item_all_button.Click += Show_Item_Button_Click;
            // 
            // item_toggle_totals_button
            // 
            item_toggle_totals_button.Location = new Point(3, 10);
            item_toggle_totals_button.Name = "item_toggle_totals_button";
            item_toggle_totals_button.Size = new Size(135, 36);
            item_toggle_totals_button.TabIndex = 2;
            item_toggle_totals_button.Text = "Hide Totals";
            item_toggle_totals_button.UseVisualStyleBackColor = true;
            item_toggle_totals_button.Click += item_toggle_totals_button_Click;
            // 
            // item_sc
            // 
            item_sc.Dock = DockStyle.Fill;
            item_sc.FixedPanel = FixedPanel.Panel1;
            item_sc.IsSplitterFixed = true;
            item_sc.Location = new Point(3, 109);
            item_sc.Name = "item_sc";
            item_sc.Orientation = Orientation.Horizontal;
            // 
            // item_sc.Panel1
            // 
            item_sc.Panel1.Controls.Add(all_item_lv);
            // 
            // item_sc.Panel2
            // 
            item_sc.Panel2.Controls.Add(item_dgv);
            item_sc.Size = new Size(1360, 755);
            item_sc.SplitterDistance = 148;
            item_sc.TabIndex = 2;
            // 
            // all_item_lv
            // 
            all_item_lv.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            all_item_lv.Dock = DockStyle.Fill;
            all_item_lv.FullRowSelect = true;
            all_item_lv.GridLines = true;
            listViewItem10.StateImageIndex = 0;
            all_item_lv.Items.AddRange(new ListViewItem[] { listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            all_item_lv.Location = new Point(0, 0);
            all_item_lv.Name = "all_item_lv";
            all_item_lv.Size = new Size(1360, 148);
            all_item_lv.TabIndex = 2;
            all_item_lv.UseCompatibleStateImageBehavior = false;
            all_item_lv.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Type";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Found";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Total";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Percent";
            columnHeader4.Width = 90;
            // 
            // item_dgv
            // 
            item_dgv.AllowUserToAddRows = false;
            item_dgv.AllowUserToDeleteRows = false;
            item_dgv.AllowUserToResizeRows = false;
            item_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            item_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            item_dgv.Columns.AddRange(new DataGridViewColumn[] { item_col_found, item_col_name, item_col_type, item_col_rarity, item_col_source, item_col_source_area, item_col_rate, item_col_hint, item_col_options });
            item_dgv.Dock = DockStyle.Fill;
            item_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            item_dgv.Location = new Point(0, 0);
            item_dgv.MultiSelect = false;
            item_dgv.Name = "item_dgv";
            item_dgv.ReadOnly = true;
            item_dgv.RowHeadersVisible = false;
            item_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            item_dgv.ShowEditingIcon = false;
            item_dgv.Size = new Size(1360, 603);
            item_dgv.TabIndex = 3;
            item_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            item_dgv.MouseClick += dgv_MouseClick;
            item_dgv.MouseUp += dgv_MouseUp;
            // 
            // item_col_found
            // 
            item_col_found.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            item_col_found.HeaderText = "Found";
            item_col_found.Name = "item_col_found";
            item_col_found.ReadOnly = true;
            item_col_found.Resizable = DataGridViewTriState.True;
            item_col_found.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_found.Width = 65;
            // 
            // item_col_name
            // 
            item_col_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_name.HeaderText = "Name";
            item_col_name.Name = "item_col_name";
            item_col_name.ReadOnly = true;
            item_col_name.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_name.Width = 70;
            // 
            // item_col_type
            // 
            item_col_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_type.HeaderText = "Type";
            item_col_type.Name = "item_col_type";
            item_col_type.ReadOnly = true;
            item_col_type.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_type.Width = 70;
            // 
            // item_col_rarity
            // 
            item_col_rarity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_rarity.HeaderText = "Rarity";
            item_col_rarity.Name = "item_col_rarity";
            item_col_rarity.ReadOnly = true;
            item_col_rarity.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_rarity.Width = 88;
            // 
            // item_col_source
            // 
            item_col_source.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_source.HeaderText = "Source";
            item_col_source.Name = "item_col_source";
            item_col_source.ReadOnly = true;
            item_col_source.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_source.Width = 88;
            // 
            // item_col_source_area
            // 
            item_col_source_area.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_source_area.HeaderText = "Source Area";
            item_col_source_area.Name = "item_col_source_area";
            item_col_source_area.ReadOnly = true;
            item_col_source_area.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_source_area.Width = 133;
            // 
            // item_col_rate
            // 
            item_col_rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_rate.HeaderText = "Drop Rate";
            item_col_rate.Name = "item_col_rate";
            item_col_rate.ReadOnly = true;
            item_col_rate.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_rate.Width = 115;
            // 
            // item_col_hint
            // 
            item_col_hint.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_hint.HeaderText = "Hint";
            item_col_hint.Name = "item_col_hint";
            item_col_hint.ReadOnly = true;
            item_col_hint.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_hint.Visible = false;
            // 
            // item_col_options
            // 
            item_col_options.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            item_col_options.HeaderText = "Options";
            item_col_options.Name = "item_col_options";
            item_col_options.ReadOnly = true;
            item_col_options.SortMode = DataGridViewColumnSortMode.Programmatic;
            item_col_options.Visible = false;
            // 
            // area_tp
            // 
            area_tp.Controls.Add(area_sc_1);
            area_tp.Location = new Point(4, 44);
            area_tp.Name = "area_tp";
            area_tp.Padding = new Padding(3);
            area_tp.Size = new Size(1372, 873);
            area_tp.TabIndex = 3;
            area_tp.Text = "Areas";
            area_tp.UseVisualStyleBackColor = true;
            // 
            // area_sc_1
            // 
            area_sc_1.Dock = DockStyle.Fill;
            area_sc_1.FixedPanel = FixedPanel.Panel1;
            area_sc_1.IsSplitterFixed = true;
            area_sc_1.Location = new Point(3, 3);
            area_sc_1.Name = "area_sc_1";
            area_sc_1.Orientation = Orientation.Horizontal;
            area_sc_1.Panel1Collapsed = true;
            // 
            // area_sc_1.Panel2
            // 
            area_sc_1.Panel2.Controls.Add(area_sc_3);
            area_sc_1.Size = new Size(1366, 867);
            area_sc_1.SplitterDistance = 53;
            area_sc_1.TabIndex = 1;
            // 
            // area_sc_3
            // 
            area_sc_3.Dock = DockStyle.Fill;
            area_sc_3.Location = new Point(0, 0);
            area_sc_3.Name = "area_sc_3";
            area_sc_3.Orientation = Orientation.Horizontal;
            // 
            // area_sc_3.Panel1
            // 
            area_sc_3.Panel1.Controls.Add(areas_sc_4);
            area_sc_3.Panel1MinSize = 100;
            // 
            // area_sc_3.Panel2
            // 
            area_sc_3.Panel2.Controls.Add(area_sc_4);
            area_sc_3.Size = new Size(1366, 867);
            area_sc_3.SplitterDistance = 402;
            area_sc_3.TabIndex = 16;
            // 
            // areas_sc_4
            // 
            areas_sc_4.Dock = DockStyle.Fill;
            areas_sc_4.Location = new Point(0, 0);
            areas_sc_4.Name = "areas_sc_4";
            // 
            // areas_sc_4.Panel1
            // 
            areas_sc_4.Panel1.Controls.Add(area_names_lv);
            // 
            // areas_sc_4.Panel2
            // 
            areas_sc_4.Panel2.Controls.Add(area_maps_lv);
            areas_sc_4.Size = new Size(1366, 402);
            areas_sc_4.SplitterDistance = 600;
            areas_sc_4.TabIndex = 0;
            // 
            // area_names_lv
            // 
            area_names_lv.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            area_names_lv.Dock = DockStyle.Fill;
            area_names_lv.FullRowSelect = true;
            area_names_lv.GridLines = true;
            area_names_lv.Location = new Point(0, 0);
            area_names_lv.Name = "area_names_lv";
            area_names_lv.Size = new Size(600, 402);
            area_names_lv.TabIndex = 14;
            area_names_lv.UseCompatibleStateImageBehavior = false;
            area_names_lv.View = View.Details;
            area_names_lv.SelectedIndexChanged += area_names_lv_SelectedIndexChanged;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Areas";
            columnHeader13.Width = 220;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Missions";
            columnHeader14.Width = 104;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Enemies";
            columnHeader15.Width = 104;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Other";
            columnHeader16.Width = 104;
            // 
            // area_maps_lv
            // 
            area_maps_lv.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader18, columnHeader19, columnHeader20 });
            area_maps_lv.Dock = DockStyle.Fill;
            area_maps_lv.FullRowSelect = true;
            area_maps_lv.GridLines = true;
            area_maps_lv.Location = new Point(0, 0);
            area_maps_lv.Name = "area_maps_lv";
            area_maps_lv.Size = new Size(762, 402);
            area_maps_lv.TabIndex = 15;
            area_maps_lv.UseCompatibleStateImageBehavior = false;
            area_maps_lv.View = View.Details;
            area_maps_lv.SelectedIndexChanged += area_maps_lv_SelectedIndexChanged;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Maps";
            columnHeader17.Width = 360;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Missions";
            columnHeader18.Width = 104;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Enemies";
            columnHeader19.Width = 104;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Other";
            columnHeader20.Width = 104;
            // 
            // area_sc_4
            // 
            area_sc_4.Dock = DockStyle.Fill;
            area_sc_4.IsSplitterFixed = true;
            area_sc_4.Location = new Point(0, 0);
            area_sc_4.Name = "area_sc_4";
            area_sc_4.Orientation = Orientation.Horizontal;
            // 
            // area_sc_4.Panel1
            // 
            area_sc_4.Panel1.Controls.Add(area_map_name_label);
            area_sc_4.Panel1.Controls.Add(area_show_all_rb);
            area_sc_4.Panel1.Controls.Add(area_show_not_found_rb);
            area_sc_4.Panel1.Controls.Add(area_show_found_rb);
            area_sc_4.Panel1MinSize = 30;
            // 
            // area_sc_4.Panel2
            // 
            area_sc_4.Panel2.Controls.Add(area_dgv);
            area_sc_4.Size = new Size(1366, 461);
            area_sc_4.SplitterDistance = 48;
            area_sc_4.TabIndex = 5;
            // 
            // area_map_name_label
            // 
            area_map_name_label.AutoSize = true;
            area_map_name_label.Location = new Point(14, 11);
            area_map_name_label.Name = "area_map_name_label";
            area_map_name_label.Size = new Size(45, 19);
            area_map_name_label.TabIndex = 19;
            area_map_name_label.Text = "Map:";
            // 
            // area_show_all_rb
            // 
            area_show_all_rb.AutoSize = true;
            area_show_all_rb.Checked = true;
            area_show_all_rb.Location = new Point(390, 8);
            area_show_all_rb.Name = "area_show_all_rb";
            area_show_all_rb.Size = new Size(162, 23);
            area_show_all_rb.TabIndex = 15;
            area_show_all_rb.TabStop = true;
            area_show_all_rb.Text = "Show Everything";
            area_show_all_rb.UseVisualStyleBackColor = true;
            area_show_all_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // area_show_not_found_rb
            // 
            area_show_not_found_rb.AutoSize = true;
            area_show_not_found_rb.Location = new Point(726, 8);
            area_show_not_found_rb.Name = "area_show_not_found_rb";
            area_show_not_found_rb.Size = new Size(153, 23);
            area_show_not_found_rb.TabIndex = 17;
            area_show_not_found_rb.Text = "Show Not Found";
            area_show_not_found_rb.UseVisualStyleBackColor = true;
            area_show_not_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // area_show_found_rb
            // 
            area_show_found_rb.AutoSize = true;
            area_show_found_rb.Location = new Point(580, 8);
            area_show_found_rb.Name = "area_show_found_rb";
            area_show_found_rb.Size = new Size(117, 23);
            area_show_found_rb.TabIndex = 16;
            area_show_found_rb.Text = "Show Found";
            area_show_found_rb.UseVisualStyleBackColor = true;
            area_show_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // area_dgv
            // 
            area_dgv.AllowUserToAddRows = false;
            area_dgv.AllowUserToDeleteRows = false;
            area_dgv.AllowUserToResizeRows = false;
            area_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            area_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            area_dgv.Columns.AddRange(new DataGridViewColumn[] { area_col_found, area_col_type, area_col_name, area_col_reward, area_col_source, area_col_rate, area_col_options });
            area_dgv.Dock = DockStyle.Fill;
            area_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            area_dgv.Location = new Point(0, 0);
            area_dgv.MultiSelect = false;
            area_dgv.Name = "area_dgv";
            area_dgv.ReadOnly = true;
            area_dgv.RowHeadersVisible = false;
            area_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            area_dgv.ShowEditingIcon = false;
            area_dgv.Size = new Size(1366, 409);
            area_dgv.TabIndex = 4;
            area_dgv.CellMouseDoubleClick += dgv_CellMouseDoubleClick;
            area_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            area_dgv.MouseClick += dgv_MouseClick;
            area_dgv.MouseUp += dgv_MouseUp;
            // 
            // area_col_found
            // 
            area_col_found.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            area_col_found.HeaderText = "Found";
            area_col_found.Name = "area_col_found";
            area_col_found.ReadOnly = true;
            area_col_found.Resizable = DataGridViewTriState.True;
            area_col_found.SortMode = DataGridViewColumnSortMode.Programmatic;
            area_col_found.Width = 65;
            // 
            // area_col_type
            // 
            area_col_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            area_col_type.HeaderText = "Type";
            area_col_type.Name = "area_col_type";
            area_col_type.ReadOnly = true;
            area_col_type.SortMode = DataGridViewColumnSortMode.Programmatic;
            area_col_type.Width = 70;
            // 
            // area_col_name
            // 
            area_col_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            area_col_name.HeaderText = "Name";
            area_col_name.Name = "area_col_name";
            area_col_name.ReadOnly = true;
            area_col_name.SortMode = DataGridViewColumnSortMode.Programmatic;
            area_col_name.Width = 70;
            // 
            // area_col_reward
            // 
            area_col_reward.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            area_col_reward.HeaderText = "Drop or Reward";
            area_col_reward.Name = "area_col_reward";
            area_col_reward.ReadOnly = true;
            area_col_reward.SortMode = DataGridViewColumnSortMode.Programmatic;
            area_col_reward.Width = 97;
            // 
            // area_col_source
            // 
            area_col_source.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            area_col_source.HeaderText = "Source";
            area_col_source.Name = "area_col_source";
            area_col_source.ReadOnly = true;
            area_col_source.SortMode = DataGridViewColumnSortMode.Programmatic;
            area_col_source.Width = 88;
            // 
            // area_col_rate
            // 
            area_col_rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            area_col_rate.HeaderText = "Drop Rate";
            area_col_rate.Name = "area_col_rate";
            area_col_rate.ReadOnly = true;
            area_col_rate.SortMode = DataGridViewColumnSortMode.Programmatic;
            area_col_rate.Width = 73;
            // 
            // area_col_options
            // 
            area_col_options.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            area_col_options.HeaderText = "Options";
            area_col_options.Name = "area_col_options";
            area_col_options.ReadOnly = true;
            area_col_options.SortMode = DataGridViewColumnSortMode.Programmatic;
            area_col_options.Visible = false;
            // 
            // hint_tp
            // 
            hint_tp.Controls.Add(hint_sc_1);
            hint_tp.Location = new Point(4, 44);
            hint_tp.Name = "hint_tp";
            hint_tp.Padding = new Padding(3);
            hint_tp.Size = new Size(1372, 873);
            hint_tp.TabIndex = 4;
            hint_tp.Text = "Hints";
            hint_tp.UseVisualStyleBackColor = true;
            // 
            // hint_sc_1
            // 
            hint_sc_1.Dock = DockStyle.Fill;
            hint_sc_1.Location = new Point(3, 3);
            hint_sc_1.Name = "hint_sc_1";
            hint_sc_1.Orientation = Orientation.Horizontal;
            // 
            // hint_sc_1.Panel1
            // 
            hint_sc_1.Panel1.Controls.Add(hint_sc_2);
            // 
            // hint_sc_1.Panel2
            // 
            hint_sc_1.Panel2.Controls.Add(hint_sc_3);
            hint_sc_1.Panel2.Margin = new Padding(3);
            hint_sc_1.Size = new Size(1366, 867);
            hint_sc_1.SplitterDistance = 286;
            hint_sc_1.TabIndex = 7;
            // 
            // hint_sc_2
            // 
            hint_sc_2.Dock = DockStyle.Fill;
            hint_sc_2.FixedPanel = FixedPanel.Panel1;
            hint_sc_2.IsSplitterFixed = true;
            hint_sc_2.Location = new Point(0, 0);
            hint_sc_2.Name = "hint_sc_2";
            hint_sc_2.Orientation = Orientation.Horizontal;
            // 
            // hint_sc_2.Panel1
            // 
            hint_sc_2.Panel1.Controls.Add(hint_total_label);
            // 
            // hint_sc_2.Panel2
            // 
            hint_sc_2.Panel2.Controls.Add(hint_dgv_2);
            hint_sc_2.Size = new Size(1366, 286);
            hint_sc_2.SplitterDistance = 54;
            hint_sc_2.TabIndex = 6;
            // 
            // hint_total_label
            // 
            hint_total_label.AutoSize = true;
            hint_total_label.Location = new Point(11, 25);
            hint_total_label.Name = "hint_total_label";
            hint_total_label.Size = new Size(189, 19);
            hint_total_label.TabIndex = 0;
            hint_total_label.Text = "Total hints found: 0";
            // 
            // hint_dgv_2
            // 
            hint_dgv_2.AllowUserToAddRows = false;
            hint_dgv_2.AllowUserToDeleteRows = false;
            hint_dgv_2.AllowUserToResizeRows = false;
            hint_dgv_2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            hint_dgv_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hint_dgv_2.Columns.AddRange(new DataGridViewColumn[] { hint2_col_hint, hint2_col_name, hint2_col_mission, hint2_col_map, hint2_col_options });
            hint_dgv_2.Dock = DockStyle.Fill;
            hint_dgv_2.EditMode = DataGridViewEditMode.EditProgrammatically;
            hint_dgv_2.Location = new Point(0, 0);
            hint_dgv_2.MultiSelect = false;
            hint_dgv_2.Name = "hint_dgv_2";
            hint_dgv_2.ReadOnly = true;
            hint_dgv_2.RowHeadersVisible = false;
            hint_dgv_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            hint_dgv_2.ShowEditingIcon = false;
            hint_dgv_2.Size = new Size(1366, 228);
            hint_dgv_2.TabIndex = 5;
            hint_dgv_2.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            hint_dgv_2.SelectionChanged += hint_dgv_2_SelectionChanged;
            hint_dgv_2.MouseClick += dgv_MouseClick;
            hint_dgv_2.MouseUp += dgv_MouseUp;
            // 
            // hint2_col_hint
            // 
            hint2_col_hint.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint2_col_hint.HeaderText = "Dropped Hint";
            hint2_col_hint.Name = "hint2_col_hint";
            hint2_col_hint.ReadOnly = true;
            hint2_col_hint.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint2_col_hint.Width = 97;
            // 
            // hint2_col_name
            // 
            hint2_col_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint2_col_name.HeaderText = "Enemy Name";
            hint2_col_name.Name = "hint2_col_name";
            hint2_col_name.ReadOnly = true;
            hint2_col_name.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint2_col_name.Width = 81;
            // 
            // hint2_col_mission
            // 
            hint2_col_mission.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint2_col_mission.HeaderText = "Mission (if any)";
            hint2_col_mission.Name = "hint2_col_mission";
            hint2_col_mission.ReadOnly = true;
            hint2_col_mission.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint2_col_mission.Width = 130;
            // 
            // hint2_col_map
            // 
            hint2_col_map.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint2_col_map.HeaderText = "Map";
            hint2_col_map.Name = "hint2_col_map";
            hint2_col_map.ReadOnly = true;
            hint2_col_map.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint2_col_map.Width = 61;
            // 
            // hint2_col_options
            // 
            hint2_col_options.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint2_col_options.HeaderText = "Options";
            hint2_col_options.Name = "hint2_col_options";
            hint2_col_options.ReadOnly = true;
            hint2_col_options.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint2_col_options.Visible = false;
            // 
            // hint_sc_3
            // 
            hint_sc_3.Dock = DockStyle.Fill;
            hint_sc_3.FixedPanel = FixedPanel.Panel1;
            hint_sc_3.IsSplitterFixed = true;
            hint_sc_3.Location = new Point(0, 0);
            hint_sc_3.Margin = new Padding(0);
            hint_sc_3.Name = "hint_sc_3";
            hint_sc_3.Orientation = Orientation.Horizontal;
            // 
            // hint_sc_3.Panel1
            // 
            hint_sc_3.Panel1.Controls.Add(hint_show_not_found_rb);
            hint_sc_3.Panel1.Controls.Add(hint_comboBox);
            hint_sc_3.Panel1.Controls.Add(hint_show_found_rb);
            hint_sc_3.Panel1.Controls.Add(label4);
            hint_sc_3.Panel1.Controls.Add(hint_show_all_rb);
            // 
            // hint_sc_3.Panel2
            // 
            hint_sc_3.Panel2.Controls.Add(hint_dgv);
            hint_sc_3.Size = new Size(1366, 577);
            hint_sc_3.SplitterDistance = 53;
            hint_sc_3.TabIndex = 0;
            // 
            // hint_show_not_found_rb
            // 
            hint_show_not_found_rb.AutoSize = true;
            hint_show_not_found_rb.Location = new Point(732, 18);
            hint_show_not_found_rb.Name = "hint_show_not_found_rb";
            hint_show_not_found_rb.Size = new Size(153, 23);
            hint_show_not_found_rb.TabIndex = 17;
            hint_show_not_found_rb.Text = "Show Not Found";
            hint_show_not_found_rb.UseVisualStyleBackColor = true;
            hint_show_not_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // hint_comboBox
            // 
            hint_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hint_comboBox.FormattingEnabled = true;
            hint_comboBox.Location = new Point(74, 14);
            hint_comboBox.Name = "hint_comboBox";
            hint_comboBox.Size = new Size(288, 27);
            hint_comboBox.TabIndex = 0;
            hint_comboBox.SelectedIndexChanged += hint_comboBox_SelectedIndexChanged;
            // 
            // hint_show_found_rb
            // 
            hint_show_found_rb.AutoSize = true;
            hint_show_found_rb.Location = new Point(580, 18);
            hint_show_found_rb.Name = "hint_show_found_rb";
            hint_show_found_rb.Size = new Size(117, 23);
            hint_show_found_rb.TabIndex = 16;
            hint_show_found_rb.Text = "Show Found";
            hint_show_found_rb.UseVisualStyleBackColor = true;
            hint_show_found_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 17);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 4;
            label4.Text = "Hint:";
            // 
            // hint_show_all_rb
            // 
            hint_show_all_rb.AutoSize = true;
            hint_show_all_rb.Checked = true;
            hint_show_all_rb.Location = new Point(390, 18);
            hint_show_all_rb.Name = "hint_show_all_rb";
            hint_show_all_rb.Size = new Size(162, 23);
            hint_show_all_rb.TabIndex = 15;
            hint_show_all_rb.TabStop = true;
            hint_show_all_rb.Text = "Show Everything";
            hint_show_all_rb.UseVisualStyleBackColor = true;
            hint_show_all_rb.CheckedChanged += Found_RadioButton_CheckedChanged;
            // 
            // hint_dgv
            // 
            hint_dgv.AllowUserToAddRows = false;
            hint_dgv.AllowUserToDeleteRows = false;
            hint_dgv.AllowUserToResizeRows = false;
            hint_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            hint_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hint_dgv.Columns.AddRange(new DataGridViewColumn[] { hint_col_found, hint_col_hint, hint_col_name, hint_col_source, hint_col_source_area, hint_col_options });
            hint_dgv.Dock = DockStyle.Fill;
            hint_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            hint_dgv.Location = new Point(0, 0);
            hint_dgv.MultiSelect = false;
            hint_dgv.Name = "hint_dgv";
            hint_dgv.ReadOnly = true;
            hint_dgv.RowHeadersVisible = false;
            hint_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            hint_dgv.ShowEditingIcon = false;
            hint_dgv.Size = new Size(1366, 520);
            hint_dgv.TabIndex = 5;
            hint_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            hint_dgv.MouseClick += dgv_MouseClick;
            hint_dgv.MouseUp += dgv_MouseUp;
            // 
            // hint_col_found
            // 
            hint_col_found.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            hint_col_found.HeaderText = "Found";
            hint_col_found.Name = "hint_col_found";
            hint_col_found.ReadOnly = true;
            hint_col_found.Resizable = DataGridViewTriState.True;
            hint_col_found.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint_col_found.Width = 65;
            // 
            // hint_col_hint
            // 
            hint_col_hint.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint_col_hint.HeaderText = "Hint";
            hint_col_hint.Name = "hint_col_hint";
            hint_col_hint.ReadOnly = true;
            hint_col_hint.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint_col_hint.Width = 70;
            // 
            // hint_col_name
            // 
            hint_col_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint_col_name.HeaderText = "Name";
            hint_col_name.Name = "hint_col_name";
            hint_col_name.ReadOnly = true;
            hint_col_name.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint_col_name.Width = 70;
            // 
            // hint_col_source
            // 
            hint_col_source.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint_col_source.HeaderText = "Source";
            hint_col_source.Name = "hint_col_source";
            hint_col_source.ReadOnly = true;
            hint_col_source.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint_col_source.Width = 88;
            // 
            // hint_col_source_area
            // 
            hint_col_source_area.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint_col_source_area.HeaderText = "Source Area";
            hint_col_source_area.Name = "hint_col_source_area";
            hint_col_source_area.ReadOnly = true;
            hint_col_source_area.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint_col_source_area.Width = 133;
            // 
            // hint_col_options
            // 
            hint_col_options.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hint_col_options.HeaderText = "Options";
            hint_col_options.Name = "hint_col_options";
            hint_col_options.ReadOnly = true;
            hint_col_options.SortMode = DataGridViewColumnSortMode.Programmatic;
            hint_col_options.Visible = false;
            // 
            // dupes_tp
            // 
            dupes_tp.Controls.Add(duplicates_sc);
            dupes_tp.Location = new Point(4, 44);
            dupes_tp.Name = "dupes_tp";
            dupes_tp.Size = new Size(1372, 873);
            dupes_tp.TabIndex = 6;
            dupes_tp.Text = "Duplicates";
            dupes_tp.UseVisualStyleBackColor = true;
            // 
            // duplicates_sc
            // 
            duplicates_sc.Dock = DockStyle.Fill;
            duplicates_sc.FixedPanel = FixedPanel.Panel1;
            duplicates_sc.Location = new Point(0, 0);
            duplicates_sc.Name = "duplicates_sc";
            duplicates_sc.Orientation = Orientation.Horizontal;
            // 
            // duplicates_sc.Panel1
            // 
            duplicates_sc.Panel1.Controls.Add(dupe_description_label);
            duplicates_sc.Panel1MinSize = 50;
            // 
            // duplicates_sc.Panel2
            // 
            duplicates_sc.Panel2.Controls.Add(dupe_dgv);
            duplicates_sc.Size = new Size(1372, 873);
            duplicates_sc.TabIndex = 0;
            // 
            // dupe_description_label
            // 
            dupe_description_label.AutoSize = true;
            dupe_description_label.Location = new Point(28, 19);
            dupe_description_label.Name = "dupe_description_label";
            dupe_description_label.Size = new Size(180, 19);
            dupe_description_label.TabIndex = 1;
            dupe_description_label.Text = "Duplicates Found: 0";
            // 
            // dupe_dgv
            // 
            dupe_dgv.AllowUserToAddRows = false;
            dupe_dgv.AllowUserToDeleteRows = false;
            dupe_dgv.AllowUserToResizeRows = false;
            dupe_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dupe_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dupe_dgv.Columns.AddRange(new DataGridViewColumn[] { dupe_col_found, dupe_col_name, dupe_col_type, dupe_col_rarity, dupe_col_source, dupe_col_area, dupe_col_rate, dupe_col_hint, dupe_col_options });
            dupe_dgv.Dock = DockStyle.Fill;
            dupe_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dupe_dgv.Location = new Point(0, 0);
            dupe_dgv.MultiSelect = false;
            dupe_dgv.Name = "dupe_dgv";
            dupe_dgv.ReadOnly = true;
            dupe_dgv.RowHeadersVisible = false;
            dupe_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dupe_dgv.ShowEditingIcon = false;
            dupe_dgv.Size = new Size(1372, 819);
            dupe_dgv.TabIndex = 4;
            dupe_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            dupe_dgv.MouseClick += dgv_MouseClick;
            dupe_dgv.MouseUp += dgv_MouseUp;
            // 
            // dupe_col_found
            // 
            dupe_col_found.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dupe_col_found.HeaderText = "Found";
            dupe_col_found.Name = "dupe_col_found";
            dupe_col_found.ReadOnly = true;
            dupe_col_found.Resizable = DataGridViewTriState.True;
            dupe_col_found.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_found.Width = 65;
            // 
            // dupe_col_name
            // 
            dupe_col_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_name.HeaderText = "Name";
            dupe_col_name.Name = "dupe_col_name";
            dupe_col_name.ReadOnly = true;
            dupe_col_name.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_name.Width = 70;
            // 
            // dupe_col_type
            // 
            dupe_col_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_type.HeaderText = "Type";
            dupe_col_type.Name = "dupe_col_type";
            dupe_col_type.ReadOnly = true;
            dupe_col_type.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_type.Width = 70;
            // 
            // dupe_col_rarity
            // 
            dupe_col_rarity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_rarity.HeaderText = "Rarity";
            dupe_col_rarity.Name = "dupe_col_rarity";
            dupe_col_rarity.ReadOnly = true;
            dupe_col_rarity.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_rarity.Width = 88;
            // 
            // dupe_col_source
            // 
            dupe_col_source.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_source.HeaderText = "Source";
            dupe_col_source.Name = "dupe_col_source";
            dupe_col_source.ReadOnly = true;
            dupe_col_source.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_source.Width = 88;
            // 
            // dupe_col_area
            // 
            dupe_col_area.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_area.HeaderText = "Source Area";
            dupe_col_area.Name = "dupe_col_area";
            dupe_col_area.ReadOnly = true;
            dupe_col_area.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_area.Width = 133;
            // 
            // dupe_col_rate
            // 
            dupe_col_rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_rate.HeaderText = "Drop Rate";
            dupe_col_rate.Name = "dupe_col_rate";
            dupe_col_rate.ReadOnly = true;
            dupe_col_rate.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_rate.Width = 115;
            // 
            // dupe_col_hint
            // 
            dupe_col_hint.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_hint.HeaderText = "Hint";
            dupe_col_hint.Name = "dupe_col_hint";
            dupe_col_hint.ReadOnly = true;
            dupe_col_hint.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_hint.Visible = false;
            // 
            // dupe_col_options
            // 
            dupe_col_options.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dupe_col_options.HeaderText = "Options";
            dupe_col_options.Name = "dupe_col_options";
            dupe_col_options.ReadOnly = true;
            dupe_col_options.SortMode = DataGridViewColumnSortMode.Programmatic;
            dupe_col_options.Visible = false;
            // 
            // search_tp
            // 
            search_tp.BackColor = SystemColors.Window;
            search_tp.Controls.Add(sc3);
            search_tp.Location = new Point(4, 44);
            search_tp.Name = "search_tp";
            search_tp.Padding = new Padding(3);
            search_tp.Size = new Size(1372, 873);
            search_tp.TabIndex = 5;
            search_tp.Text = "Search";
            // 
            // sc3
            // 
            sc3.BackColor = SystemColors.Window;
            sc3.Dock = DockStyle.Fill;
            sc3.FixedPanel = FixedPanel.Panel1;
            sc3.IsSplitterFixed = true;
            sc3.Location = new Point(3, 3);
            sc3.Name = "sc3";
            sc3.Orientation = Orientation.Horizontal;
            // 
            // sc3.Panel1
            // 
            sc3.Panel1.Controls.Add(last_search_label);
            sc3.Panel1.Controls.Add(label8);
            sc3.Panel1.Controls.Add(search_rtb);
            // 
            // sc3.Panel2
            // 
            sc3.Panel2.Controls.Add(sc2);
            sc3.Size = new Size(1366, 867);
            sc3.SplitterDistance = 56;
            sc3.TabIndex = 7;
            // 
            // last_search_label
            // 
            last_search_label.AutoSize = true;
            last_search_label.Font = new Font("Consolas", 15.75F);
            last_search_label.Location = new Point(608, 18);
            last_search_label.Name = "last_search_label";
            last_search_label.Size = new Size(94, 24);
            last_search_label.TabIndex = 9;
            last_search_label.Text = "nothing";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 15.75F);
            label8.Location = new Point(448, 18);
            label8.Name = "label8";
            label8.Size = new Size(154, 24);
            label8.TabIndex = 8;
            label8.Text = "Last Search:";
            // 
            // search_rtb
            // 
            search_rtb.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_rtb.ForeColor = SystemColors.ControlText;
            search_rtb.Location = new Point(10, 14);
            search_rtb.MaxLength = 30;
            search_rtb.Name = "search_rtb";
            search_rtb.ScrollBars = RichTextBoxScrollBars.None;
            search_rtb.Size = new Size(420, 32);
            search_rtb.TabIndex = 7;
            search_rtb.Text = "<ESC> to clear";
            search_rtb.WordWrap = false;
            search_rtb.KeyDown += search_rtb_KeyDown;
            search_rtb.MouseDown += search_rtb_MouseDown;
            // 
            // sc2
            // 
            sc2.Dock = DockStyle.Fill;
            sc2.Location = new Point(0, 0);
            sc2.Margin = new Padding(0);
            sc2.Name = "sc2";
            sc2.Orientation = Orientation.Horizontal;
            // 
            // sc2.Panel1
            // 
            sc2.Panel1.Controls.Add(tableLayoutPanel1);
            sc2.Panel1.Padding = new Padding(10);
            // 
            // sc2.Panel2
            // 
            sc2.Panel2.Controls.Add(tableLayoutPanel2);
            sc2.Panel2.Padding = new Padding(10);
            sc2.Size = new Size(1366, 807);
            sc2.SplitterDistance = 374;
            sc2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(meo_search_dgv, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1346, 354);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(250, 22);
            label9.TabIndex = 0;
            label9.Text = "Missions / Enemy / Other";
            // 
            // meo_search_dgv
            // 
            meo_search_dgv.AllowUserToAddRows = false;
            meo_search_dgv.AllowUserToDeleteRows = false;
            meo_search_dgv.AllowUserToResizeRows = false;
            meo_search_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            meo_search_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            meo_search_dgv.Columns.AddRange(new DataGridViewColumn[] { meo_search_found_col, meo_search_type_col, meo_search_name_col, meo_search_reward_col, meo_search_source_col, meo_search_rate_col, meo_search_options_col });
            meo_search_dgv.Dock = DockStyle.Fill;
            meo_search_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            meo_search_dgv.Location = new Point(3, 33);
            meo_search_dgv.MultiSelect = false;
            meo_search_dgv.Name = "meo_search_dgv";
            meo_search_dgv.ReadOnly = true;
            meo_search_dgv.RowHeadersVisible = false;
            meo_search_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            meo_search_dgv.ShowEditingIcon = false;
            meo_search_dgv.Size = new Size(1340, 318);
            meo_search_dgv.TabIndex = 6;
            meo_search_dgv.CellMouseDoubleClick += dgv_CellMouseDoubleClick;
            meo_search_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            meo_search_dgv.MouseClick += dgv_MouseClick;
            meo_search_dgv.MouseUp += dgv_MouseUp;
            // 
            // meo_search_found_col
            // 
            meo_search_found_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            meo_search_found_col.HeaderText = "Found";
            meo_search_found_col.Name = "meo_search_found_col";
            meo_search_found_col.ReadOnly = true;
            meo_search_found_col.Resizable = DataGridViewTriState.True;
            meo_search_found_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            meo_search_found_col.Width = 65;
            // 
            // meo_search_type_col
            // 
            meo_search_type_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            meo_search_type_col.HeaderText = "Type";
            meo_search_type_col.Name = "meo_search_type_col";
            meo_search_type_col.ReadOnly = true;
            meo_search_type_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            meo_search_type_col.Width = 70;
            // 
            // meo_search_name_col
            // 
            meo_search_name_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            meo_search_name_col.HeaderText = "Name";
            meo_search_name_col.Name = "meo_search_name_col";
            meo_search_name_col.ReadOnly = true;
            meo_search_name_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            meo_search_name_col.Width = 70;
            // 
            // meo_search_reward_col
            // 
            meo_search_reward_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            meo_search_reward_col.HeaderText = "Drop or Hint";
            meo_search_reward_col.Name = "meo_search_reward_col";
            meo_search_reward_col.ReadOnly = true;
            meo_search_reward_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            meo_search_reward_col.Width = 97;
            // 
            // meo_search_source_col
            // 
            meo_search_source_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            meo_search_source_col.HeaderText = "Source";
            meo_search_source_col.Name = "meo_search_source_col";
            meo_search_source_col.ReadOnly = true;
            meo_search_source_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            meo_search_source_col.Width = 88;
            // 
            // meo_search_rate_col
            // 
            meo_search_rate_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            meo_search_rate_col.HeaderText = "Drop Rate";
            meo_search_rate_col.Name = "meo_search_rate_col";
            meo_search_rate_col.ReadOnly = true;
            meo_search_rate_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            meo_search_rate_col.Width = 73;
            // 
            // meo_search_options_col
            // 
            meo_search_options_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            meo_search_options_col.HeaderText = "Options";
            meo_search_options_col.Name = "meo_search_options_col";
            meo_search_options_col.ReadOnly = true;
            meo_search_options_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            meo_search_options_col.Width = 97;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label10, 0, 0);
            tableLayoutPanel2.Controls.Add(loot_search_dgv, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1346, 409);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 22);
            label10.TabIndex = 6;
            label10.Text = "Loot";
            // 
            // loot_search_dgv
            // 
            loot_search_dgv.AllowUserToAddRows = false;
            loot_search_dgv.AllowUserToDeleteRows = false;
            loot_search_dgv.AllowUserToResizeRows = false;
            loot_search_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            loot_search_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            loot_search_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loot_search_dgv.Columns.AddRange(new DataGridViewColumn[] { loot_search_found_col, loot_search_name_col, loot_search_type_col, loot_search_rarity_col, loot_search_source_col, loot_search_source_area_col, loot_search_rate_col, loot_search_hint_col, loot_search_options_col });
            loot_search_dgv.Dock = DockStyle.Fill;
            loot_search_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            loot_search_dgv.Location = new Point(3, 33);
            loot_search_dgv.MultiSelect = false;
            loot_search_dgv.Name = "loot_search_dgv";
            loot_search_dgv.ReadOnly = true;
            loot_search_dgv.RowHeadersVisible = false;
            loot_search_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loot_search_dgv.ShowEditingIcon = false;
            loot_search_dgv.Size = new Size(1340, 373);
            loot_search_dgv.TabIndex = 5;
            loot_search_dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            loot_search_dgv.MouseClick += dgv_MouseClick;
            loot_search_dgv.MouseUp += dgv_MouseUp;
            // 
            // loot_search_found_col
            // 
            loot_search_found_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            loot_search_found_col.HeaderText = "Found";
            loot_search_found_col.Name = "loot_search_found_col";
            loot_search_found_col.ReadOnly = true;
            loot_search_found_col.Resizable = DataGridViewTriState.True;
            loot_search_found_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_found_col.Width = 65;
            // 
            // loot_search_name_col
            // 
            loot_search_name_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_name_col.HeaderText = "Name";
            loot_search_name_col.Name = "loot_search_name_col";
            loot_search_name_col.ReadOnly = true;
            loot_search_name_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_name_col.Width = 70;
            // 
            // loot_search_type_col
            // 
            loot_search_type_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_type_col.HeaderText = "Type";
            loot_search_type_col.Name = "loot_search_type_col";
            loot_search_type_col.ReadOnly = true;
            loot_search_type_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_type_col.Width = 70;
            // 
            // loot_search_rarity_col
            // 
            loot_search_rarity_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_rarity_col.HeaderText = "Rarity";
            loot_search_rarity_col.Name = "loot_search_rarity_col";
            loot_search_rarity_col.ReadOnly = true;
            loot_search_rarity_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_rarity_col.Width = 88;
            // 
            // loot_search_source_col
            // 
            loot_search_source_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_source_col.HeaderText = "Source";
            loot_search_source_col.Name = "loot_search_source_col";
            loot_search_source_col.ReadOnly = true;
            loot_search_source_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_source_col.Width = 88;
            // 
            // loot_search_source_area_col
            // 
            loot_search_source_area_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_source_area_col.HeaderText = "Source Area";
            loot_search_source_area_col.Name = "loot_search_source_area_col";
            loot_search_source_area_col.ReadOnly = true;
            loot_search_source_area_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_source_area_col.Width = 133;
            // 
            // loot_search_rate_col
            // 
            loot_search_rate_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_rate_col.HeaderText = "Drop Rate";
            loot_search_rate_col.Name = "loot_search_rate_col";
            loot_search_rate_col.ReadOnly = true;
            loot_search_rate_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_rate_col.Width = 115;
            // 
            // loot_search_hint_col
            // 
            loot_search_hint_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_hint_col.HeaderText = "Hint";
            loot_search_hint_col.Name = "loot_search_hint_col";
            loot_search_hint_col.ReadOnly = true;
            loot_search_hint_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_hint_col.Width = 70;
            // 
            // loot_search_options_col
            // 
            loot_search_options_col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loot_search_options_col.HeaderText = "Options";
            loot_search_options_col.Name = "loot_search_options_col";
            loot_search_options_col.ReadOnly = true;
            loot_search_options_col.SortMode = DataGridViewColumnSortMode.Programmatic;
            loot_search_options_col.Width = 97;
            // 
            // testing_tp
            // 
            testing_tp.Controls.Add(six_life_tlp);
            testing_tp.Location = new Point(4, 44);
            testing_tp.Name = "testing_tp";
            testing_tp.Size = new Size(1372, 873);
            testing_tp.TabIndex = 7;
            testing_tp.Text = "Test";
            testing_tp.UseVisualStyleBackColor = true;
            // 
            // six_life_tlp
            // 
            six_life_tlp.BackColor = Color.Transparent;
            six_life_tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            six_life_tlp.ColumnCount = 4;
            six_life_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            six_life_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            six_life_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            six_life_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            six_life_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            six_life_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            six_life_tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            six_life_tlp.Controls.Add(label30, 3, 6);
            six_life_tlp.Controls.Add(label29, 2, 6);
            six_life_tlp.Controls.Add(label28, 1, 6);
            six_life_tlp.Controls.Add(label27, 3, 5);
            six_life_tlp.Controls.Add(label26, 2, 5);
            six_life_tlp.Controls.Add(label25, 1, 5);
            six_life_tlp.Controls.Add(label24, 3, 4);
            six_life_tlp.Controls.Add(label23, 2, 4);
            six_life_tlp.Controls.Add(label22, 1, 4);
            six_life_tlp.Controls.Add(label21, 3, 3);
            six_life_tlp.Controls.Add(label20, 2, 3);
            six_life_tlp.Controls.Add(label19, 1, 3);
            six_life_tlp.Controls.Add(label18, 3, 2);
            six_life_tlp.Controls.Add(label17, 2, 2);
            six_life_tlp.Controls.Add(label16, 1, 2);
            six_life_tlp.Controls.Add(label15, 3, 1);
            six_life_tlp.Controls.Add(label14, 2, 1);
            six_life_tlp.Controls.Add(pictureBox2, 0, 1);
            six_life_tlp.Controls.Add(pictureBox1, 0, 2);
            six_life_tlp.Controls.Add(pictureBox6, 0, 3);
            six_life_tlp.Controls.Add(pictureBox3, 0, 4);
            six_life_tlp.Controls.Add(pictureBox5, 0, 5);
            six_life_tlp.Controls.Add(pictureBox4, 0, 6);
            six_life_tlp.Controls.Add(label7, 1, 0);
            six_life_tlp.Controls.Add(label11, 2, 0);
            six_life_tlp.Controls.Add(label12, 3, 0);
            six_life_tlp.Controls.Add(six_life_random_button, 0, 0);
            six_life_tlp.Controls.Add(label13, 1, 1);
            six_life_tlp.Dock = DockStyle.Fill;
            six_life_tlp.Location = new Point(0, 0);
            six_life_tlp.Name = "six_life_tlp";
            six_life_tlp.RowCount = 7;
            six_life_tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            six_life_tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            six_life_tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            six_life_tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            six_life_tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            six_life_tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            six_life_tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            six_life_tlp.Size = new Size(1372, 873);
            six_life_tlp.TabIndex = 0;
            // 
            // label30
            // 
            label30.Dock = DockStyle.Fill;
            label30.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(963, 739);
            label30.Name = "label30";
            label30.Size = new Size(404, 132);
            label30.TabIndex = 28;
            label30.Text = "label30";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(553, 739);
            label29.Name = "label29";
            label29.Size = new Size(402, 132);
            label29.TabIndex = 27;
            label29.Text = "label29";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.Dock = DockStyle.Fill;
            label28.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(143, 739);
            label28.Name = "label28";
            label28.Size = new Size(402, 132);
            label28.TabIndex = 26;
            label28.Text = "label28";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.Dock = DockStyle.Fill;
            label27.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(963, 609);
            label27.Name = "label27";
            label27.Size = new Size(404, 128);
            label27.TabIndex = 25;
            label27.Text = "label27";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.Dock = DockStyle.Fill;
            label26.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(553, 609);
            label26.Name = "label26";
            label26.Size = new Size(402, 128);
            label26.TabIndex = 24;
            label26.Text = "label26";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.Dock = DockStyle.Fill;
            label25.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(143, 609);
            label25.Name = "label25";
            label25.Size = new Size(402, 128);
            label25.TabIndex = 23;
            label25.Text = "label25";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.Dock = DockStyle.Fill;
            label24.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(963, 479);
            label24.Name = "label24";
            label24.Size = new Size(404, 128);
            label24.TabIndex = 22;
            label24.Text = "label24";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Dock = DockStyle.Fill;
            label23.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(553, 479);
            label23.Name = "label23";
            label23.Size = new Size(402, 128);
            label23.TabIndex = 21;
            label23.Text = "label23";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(143, 479);
            label22.Name = "label22";
            label22.Size = new Size(402, 128);
            label22.TabIndex = 20;
            label22.Text = "label22";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(963, 349);
            label21.Name = "label21";
            label21.Size = new Size(404, 128);
            label21.TabIndex = 19;
            label21.Text = "label21";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(553, 349);
            label20.Name = "label20";
            label20.Size = new Size(402, 128);
            label20.TabIndex = 18;
            label20.Text = "label20";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(143, 349);
            label19.Name = "label19";
            label19.Size = new Size(402, 128);
            label19.TabIndex = 17;
            label19.Text = "label19";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(963, 219);
            label18.Name = "label18";
            label18.Size = new Size(404, 128);
            label18.TabIndex = 16;
            label18.Text = "label18";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(553, 219);
            label17.Name = "label17";
            label17.Size = new Size(402, 128);
            label17.TabIndex = 15;
            label17.Text = "label17";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(143, 219);
            label16.Name = "label16";
            label16.Size = new Size(402, 128);
            label16.TabIndex = 14;
            label16.Text = "label16";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(963, 89);
            label15.Name = "label15";
            label15.Size = new Size(404, 128);
            label15.TabIndex = 13;
            label15.Text = "label15";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(553, 89);
            label14.Name = "label14";
            label14.Size = new Size(402, 128);
            label14.TabIndex = 12;
            label14.Text = "label14";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.gaige;
            pictureBox2.Location = new Point(5, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.axton;
            pictureBox1.Location = new Point(5, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Properties.Resources.zero;
            pictureBox6.Location = new Point(5, 352);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(130, 122);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.krieg;
            pictureBox3.Location = new Point(5, 482);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(130, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.sal;
            pictureBox5.Location = new Point(5, 612);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(130, 122);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.maya;
            pictureBox4.Location = new Point(5, 742);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 126);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(143, 2);
            label7.Name = "label7";
            label7.Size = new Size(402, 85);
            label7.TabIndex = 7;
            label7.Text = "Normal";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(553, 2);
            label11.Name = "label11";
            label11.Size = new Size(402, 85);
            label11.TabIndex = 8;
            label11.Text = "TVHM";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(963, 2);
            label12.Name = "label12";
            label12.Size = new Size(404, 85);
            label12.TabIndex = 9;
            label12.Text = "UVHM";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // six_life_random_button
            // 
            six_life_random_button.Dock = DockStyle.Fill;
            six_life_random_button.Location = new Point(5, 5);
            six_life_random_button.Name = "six_life_random_button";
            six_life_random_button.Size = new Size(130, 79);
            six_life_random_button.TabIndex = 10;
            six_life_random_button.Text = "Randomize";
            six_life_random_button.UseVisualStyleBackColor = true;
            six_life_random_button.Click += six_life_random_button_Click;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(143, 89);
            label13.Name = "label13";
            label13.Size = new Size(402, 128);
            label13.TabIndex = 11;
            label13.Text = "label13";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1372, 873);
            tabPage1.TabIndex = 8;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Size = new Size(1366, 867);
            splitContainer1.SplitterDistance = 102;
            splitContainer1.TabIndex = 0;
            // 
            // seed_file_dlg
            // 
            seed_file_dlg.Filter = "Seed Files|*.txt";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 921);
            Controls.Add(tc);
            DoubleBuffered = true;
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1376, 700);
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loot Rando Helper";
            Load += Main_Form_Load;
            tc.ResumeLayout(false);
            seeds_tp.ResumeLayout(false);
            seed_tc.ResumeLayout(false);
            seed_tc_seed_tp.ResumeLayout(false);
            found_seeds_sc.Panel1.ResumeLayout(false);
            found_seeds_sc.Panel2.ResumeLayout(false);
            found_seeds_sc.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)found_seeds_sc).EndInit();
            found_seeds_sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)seed_dgv).EndInit();
            seed_tlp.ResumeLayout(false);
            vh_flow_layout_panel.ResumeLayout(false);
            seed_tc_steam_tp.ResumeLayout(false);
            seed_tc_steam_tp.PerformLayout();
            weap_tp.ResumeLayout(false);
            weap_tlp.ResumeLayout(false);
            weap_panel.ResumeLayout(false);
            weap_panel.PerformLayout();
            weap_sc.Panel1.ResumeLayout(false);
            weap_sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)weap_sc).EndInit();
            weap_sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)weap_dgv).EndInit();
            item_tp.ResumeLayout(false);
            items_tlp.ResumeLayout(false);
            item_panel.ResumeLayout(false);
            item_panel.PerformLayout();
            item_sc.Panel1.ResumeLayout(false);
            item_sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)item_sc).EndInit();
            item_sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)item_dgv).EndInit();
            area_tp.ResumeLayout(false);
            area_sc_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)area_sc_1).EndInit();
            area_sc_1.ResumeLayout(false);
            area_sc_3.Panel1.ResumeLayout(false);
            area_sc_3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)area_sc_3).EndInit();
            area_sc_3.ResumeLayout(false);
            areas_sc_4.Panel1.ResumeLayout(false);
            areas_sc_4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)areas_sc_4).EndInit();
            areas_sc_4.ResumeLayout(false);
            area_sc_4.Panel1.ResumeLayout(false);
            area_sc_4.Panel1.PerformLayout();
            area_sc_4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)area_sc_4).EndInit();
            area_sc_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)area_dgv).EndInit();
            hint_tp.ResumeLayout(false);
            hint_sc_1.Panel1.ResumeLayout(false);
            hint_sc_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hint_sc_1).EndInit();
            hint_sc_1.ResumeLayout(false);
            hint_sc_2.Panel1.ResumeLayout(false);
            hint_sc_2.Panel1.PerformLayout();
            hint_sc_2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hint_sc_2).EndInit();
            hint_sc_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hint_dgv_2).EndInit();
            hint_sc_3.Panel1.ResumeLayout(false);
            hint_sc_3.Panel1.PerformLayout();
            hint_sc_3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hint_sc_3).EndInit();
            hint_sc_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hint_dgv).EndInit();
            dupes_tp.ResumeLayout(false);
            duplicates_sc.Panel1.ResumeLayout(false);
            duplicates_sc.Panel1.PerformLayout();
            duplicates_sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)duplicates_sc).EndInit();
            duplicates_sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dupe_dgv).EndInit();
            search_tp.ResumeLayout(false);
            sc3.Panel1.ResumeLayout(false);
            sc3.Panel1.PerformLayout();
            sc3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc3).EndInit();
            sc3.ResumeLayout(false);
            sc2.Panel1.ResumeLayout(false);
            sc2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc2).EndInit();
            sc2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)meo_search_dgv).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loot_search_dgv).EndInit();
            testing_tp.ResumeLayout(false);
            six_life_tlp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tc;
        private TabPage seeds_tp;
        private TabPage weap_tp;
        private TabControl seed_tc;
        private TabPage seed_tc_seed_tp;
        private SplitContainer found_seeds_sc;
        private DataGridView seed_dgv;
        private Button seed_browse_button;
        private TableLayoutPanel seed_tlp;
        private Label seed_label_2;
        private RichTextBox seed_rtb_2;
        private Label seed_label_1;
        private RichTextBox seed_rtb_1;
        private FlowLayoutPanel vh_flow_layout_panel;
        private Button seed_load_button;
        private RichTextBox selected_seed_rtb;
        private Label label5;
        private TabPage seed_tc_steam_tp;
        private Label label1;
        private RichTextBox seeds_folder_rtb;
        private RichTextBox steam_library_folders_rtb;
        private Label label3;
        private Label label2;
        private RichTextBox bl2_folder_rtb;
        private TabPage item_tp;
        private TabPage area_tp;
        private TabPage hint_tp;
        private Label label6;
        private Label seed_label_3;
        private RichTextBox seed_rtb_3;
        private Button vh_maya_button;
        private Button vh_axton_button;
        private Button vh_sal_button;
        private Button vh_zero_button;
        private Button vh_krieg_button;
        private Button vh_gaige_button;
        private Button vh_all_button;
        private TableLayoutPanel weap_tlp;
        private Panel weap_panel;
        private RadioButton weap_show_not_found_rb;
        private RadioButton weap_show_found_rb;
        private RadioButton weap_show_all_rb;
        private Button weap_sniper_button;
        private Button weap_smg_button;
        private Button weap_shotgun_button;
        private Button weap_launcher_button;
        private Button weap_pistol_button;
        private Button weap_ar_button;
        private Button weap_all_button;
        private Button weap_toggle_totals_button;
        private SplitContainer weap_sc;
        private ListView all_weap_lv;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private DataGridView weap_dgv;
        private TableLayoutPanel items_tlp;
        private Panel item_panel;
        private RadioButton item_show_not_found_rb;
        private RadioButton item_show_found_rb;
        private RadioButton item_show_all_rb;
        private Button item_shield_button;
        private Button item_grenade_button;
        private Button item_relic_button;
        private Button item_com_button;
        private Button item_all_button;
        private Button item_toggle_totals_button;
        private SplitContainer item_sc;
        private ListView all_item_lv;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DataGridView item_dgv;
        private SplitContainer area_sc_1;
        private SplitContainer area_sc_3;
        private SplitContainer areas_sc_4;
        private ListView area_names_lv;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ListView area_maps_lv;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private SplitContainer area_sc_4;
        private Label area_map_name_label;
        private RadioButton area_show_all_rb;
        private RadioButton area_show_not_found_rb;
        private RadioButton area_show_found_rb;
        private DataGridView area_dgv;
        private SplitContainer hint_sc_1;
        private SplitContainer hint_sc_2;
        private Label hint_total_label;
        private DataGridView hint_dgv_2;
        private SplitContainer hint_sc_3;
        private RadioButton hint_show_not_found_rb;
        private ComboBox hint_comboBox;
        private RadioButton hint_show_found_rb;
        private Label label4;
        private RadioButton hint_show_all_rb;
        private DataGridView hint_dgv;
        private TabPage search_tp;
        private SplitContainer sc3;
        private Label last_search_label;
        private Label label8;
        private RichTextBox search_rtb;
        private SplitContainer sc2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private DataGridView meo_search_dgv;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private DataGridView loot_search_dgv;
        private DataGridViewTextBoxColumn seed_col_filename;
        private DataGridViewTextBoxColumn seed_col_date;
        private DataGridViewTextBoxColumn seed_col_locations;
        private DataGridViewTextBoxColumn seed_col_items;
        private DataGridViewTextBoxColumn seed_col_nothings;
        private DataGridViewTextBoxColumn seed_col_hints;
        private TabPage dupes_tp;
        private SplitContainer duplicates_sc;
        private DataGridView dupe_dgv;
        private Label dupe_description_label;
        private OpenFileDialog seed_file_dlg;
        private DataGridViewCheckBoxColumn meo_search_found_col;
        private DataGridViewTextBoxColumn meo_search_type_col;
        private DataGridViewTextBoxColumn meo_search_name_col;
        private DataGridViewTextBoxColumn meo_search_reward_col;
        private DataGridViewTextBoxColumn meo_search_source_col;
        private DataGridViewTextBoxColumn meo_search_rate_col;
        private DataGridViewTextBoxColumn meo_search_options_col;
        private DataGridViewCheckBoxColumn loot_search_found_col;
        private DataGridViewTextBoxColumn loot_search_name_col;
        private DataGridViewTextBoxColumn loot_search_type_col;
        private DataGridViewTextBoxColumn loot_search_rarity_col;
        private DataGridViewTextBoxColumn loot_search_source_col;
        private DataGridViewTextBoxColumn loot_search_source_area_col;
        private DataGridViewTextBoxColumn loot_search_rate_col;
        private DataGridViewTextBoxColumn loot_search_hint_col;
        private DataGridViewTextBoxColumn loot_search_options_col;
        private DataGridViewCheckBoxColumn weap_col_found;
        private DataGridViewTextBoxColumn weap_col_name;
        private DataGridViewTextBoxColumn weap_col_type;
        private DataGridViewTextBoxColumn weap_col_rarity;
        private DataGridViewTextBoxColumn weap_col_source;
        private DataGridViewTextBoxColumn weap_col_source_area;
        private DataGridViewTextBoxColumn weap_col_rate;
        private DataGridViewTextBoxColumn weap_col_hint;
        private DataGridViewTextBoxColumn weap_col_options;
        private DataGridViewCheckBoxColumn item_col_found;
        private DataGridViewTextBoxColumn item_col_name;
        private DataGridViewTextBoxColumn item_col_type;
        private DataGridViewTextBoxColumn item_col_rarity;
        private DataGridViewTextBoxColumn item_col_source;
        private DataGridViewTextBoxColumn item_col_source_area;
        private DataGridViewTextBoxColumn item_col_rate;
        private DataGridViewTextBoxColumn item_col_hint;
        private DataGridViewTextBoxColumn item_col_options;
        private DataGridViewCheckBoxColumn area_col_found;
        private DataGridViewTextBoxColumn area_col_type;
        private DataGridViewTextBoxColumn area_col_name;
        private DataGridViewTextBoxColumn area_col_reward;
        private DataGridViewTextBoxColumn area_col_source;
        private DataGridViewTextBoxColumn area_col_rate;
        private DataGridViewTextBoxColumn area_col_options;
        private DataGridViewTextBoxColumn hint2_col_hint;
        private DataGridViewTextBoxColumn hint2_col_name;
        private DataGridViewTextBoxColumn hint2_col_mission;
        private DataGridViewTextBoxColumn hint2_col_map;
        private DataGridViewTextBoxColumn hint2_col_options;
        private DataGridViewCheckBoxColumn hint_col_found;
        private DataGridViewTextBoxColumn hint_col_hint;
        private DataGridViewTextBoxColumn hint_col_name;
        private DataGridViewTextBoxColumn hint_col_source;
        private DataGridViewTextBoxColumn hint_col_source_area;
        private DataGridViewTextBoxColumn hint_col_options;
        private DataGridViewCheckBoxColumn dupe_col_found;
        private DataGridViewTextBoxColumn dupe_col_name;
        private DataGridViewTextBoxColumn dupe_col_type;
        private DataGridViewTextBoxColumn dupe_col_rarity;
        private DataGridViewTextBoxColumn dupe_col_source;
        private DataGridViewTextBoxColumn dupe_col_area;
        private DataGridViewTextBoxColumn dupe_col_rate;
        private DataGridViewTextBoxColumn dupe_col_hint;
        private DataGridViewTextBoxColumn dupe_col_options;
        private TabPage testing_tp;
        private TableLayoutPanel six_life_tlp;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label11;
        private Label label12;
        private Button six_life_random_button;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private Label label31;
        private TextBox web_seed_tb;
        private Button load_web_seed_button;
    }
}