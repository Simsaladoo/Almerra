using System;

namespace Launcher
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.CloseButton = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.font = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.Game_NoteLabel = new System.Windows.Forms.Label();
            this.comboBox3_Shadows = new System.Windows.Forms.ComboBox();
            this.Game_ShadowLabel = new System.Windows.Forms.Label();
            this.comboBox2_AA = new System.Windows.Forms.ComboBox();
            this.Game_AALabel = new System.Windows.Forms.Label();
            this.Game_ResolutionLabel = new System.Windows.Forms.Label();
            this.comboBox1_Detail = new System.Windows.Forms.ComboBox();
            this.checkBox2_Vsync = new System.Windows.Forms.CheckBox();
            this.checkBox1_Fullscreen = new System.Windows.Forms.CheckBox();
            this.ResolutionBox = new System.Windows.Forms.ComboBox();
            this.Game_DetailLabel = new System.Windows.Forms.Label();
            this.GamePageTitle = new System.Windows.Forms.Label();
            this.Game_HeaderLabel = new System.Windows.Forms.Label();
            this.GameHLine = new System.Windows.Forms.Label();
            this.OtherPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.CacheSizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Pick_A_Label = new System.Windows.Forms.Label();
            this.ToPanelButton = new System.Windows.Forms.Button();
            this.ToMainButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar0 = new System.Windows.Forms.ProgressBar();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.DDpanel1 = new System.Windows.Forms.Panel();
            this.DDpanel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.font)).BeginInit();
            this.ToolsPanel.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.OtherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::Launcher.Properties.Resources.close;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(969, 2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 29);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.Enabled = false;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(792, 547);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(152, 54);
            this.play.TabIndex = 30;
            this.play.Text = "Builds";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // font
            // 
            this.font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.font.BackColor = System.Drawing.Color.Transparent;
            this.font.BackgroundImage = global::Launcher.Properties.Resources.font;
            this.font.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.font.InitialImage = ((System.Drawing.Image)(resources.GetObject("font.InitialImage")));
            this.font.Location = new System.Drawing.Point(0, 0);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(1000, 600);
            this.font.TabIndex = 16;
            this.font.TabStop = false;
            this.font.WaitOnLoad = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            this.font.MouseDown += new System.Windows.Forms.MouseEventHandler(this.font_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(592, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 29;
            this.button1.Text = "Editors";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Winds of Almerra";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolsPanel.Controls.Add(this.GeneralPanel);
            this.ToolsPanel.Controls.Add(this.OtherPanel);
            this.ToolsPanel.Controls.Add(this.button9);
            this.ToolsPanel.Controls.Add(this.button10);
            this.ToolsPanel.Controls.Add(this.Pick_A_Label);
            this.ToolsPanel.Location = new System.Drawing.Point(0, 73);
            this.ToolsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(1000, 476);
            this.ToolsPanel.TabIndex = 24;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralPanel.Controls.Add(this.Game_NoteLabel);
            this.GeneralPanel.Controls.Add(this.comboBox3_Shadows);
            this.GeneralPanel.Controls.Add(this.Game_ShadowLabel);
            this.GeneralPanel.Controls.Add(this.comboBox2_AA);
            this.GeneralPanel.Controls.Add(this.Game_AALabel);
            this.GeneralPanel.Controls.Add(this.Game_ResolutionLabel);
            this.GeneralPanel.Controls.Add(this.comboBox1_Detail);
            this.GeneralPanel.Controls.Add(this.checkBox2_Vsync);
            this.GeneralPanel.Controls.Add(this.checkBox1_Fullscreen);
            this.GeneralPanel.Controls.Add(this.ResolutionBox);
            this.GeneralPanel.Controls.Add(this.Game_DetailLabel);
            this.GeneralPanel.Controls.Add(this.GamePageTitle);
            this.GeneralPanel.Controls.Add(this.Game_HeaderLabel);
            this.GeneralPanel.Controls.Add(this.GameHLine);
            this.GeneralPanel.Location = new System.Drawing.Point(199, 3);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(798, 363);
            this.GeneralPanel.TabIndex = 39;
            // 
            // Game_NoteLabel
            // 
            this.Game_NoteLabel.AutoSize = true;
            this.Game_NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_NoteLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Game_NoteLabel.Location = new System.Drawing.Point(494, 342);
            this.Game_NoteLabel.Name = "Game_NoteLabel";
            this.Game_NoteLabel.Size = new System.Drawing.Size(306, 17);
            this.Game_NoteLabel.TabIndex = 50;
            this.Game_NoteLabel.Text = "These settings can be further modified in-game";
            this.Game_NoteLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox3_Shadows
            // 
            this.comboBox3_Shadows.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox3_Shadows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3_Shadows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3_Shadows.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox3_Shadows.FormattingEnabled = true;
            this.comboBox3_Shadows.Items.AddRange(new object[] {
            "1920 x 1080",
            "1280 x 720"});
            this.comboBox3_Shadows.Location = new System.Drawing.Point(561, 116);
            this.comboBox3_Shadows.Name = "comboBox3_Shadows";
            this.comboBox3_Shadows.Size = new System.Drawing.Size(154, 32);
            this.comboBox3_Shadows.TabIndex = 49;
            this.comboBox3_Shadows.Text = "Ultra";
            // 
            // Game_ShadowLabel
            // 
            this.Game_ShadowLabel.AutoSize = true;
            this.Game_ShadowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_ShadowLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Game_ShadowLabel.Location = new System.Drawing.Point(557, 86);
            this.Game_ShadowLabel.Name = "Game_ShadowLabel";
            this.Game_ShadowLabel.Size = new System.Drawing.Size(88, 24);
            this.Game_ShadowLabel.TabIndex = 48;
            this.Game_ShadowLabel.Text = "Shadows";
            this.Game_ShadowLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox2_AA
            // 
            this.comboBox2_AA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox2_AA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2_AA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2_AA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox2_AA.FormattingEnabled = true;
            this.comboBox2_AA.Items.AddRange(new object[] {
            "1920 x 1080",
            "1280 x 720"});
            this.comboBox2_AA.Location = new System.Drawing.Point(317, 205);
            this.comboBox2_AA.Name = "comboBox2_AA";
            this.comboBox2_AA.Size = new System.Drawing.Size(154, 32);
            this.comboBox2_AA.TabIndex = 47;
            this.comboBox2_AA.Text = "Ultra";
            // 
            // Game_AALabel
            // 
            this.Game_AALabel.AutoSize = true;
            this.Game_AALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_AALabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Game_AALabel.Location = new System.Drawing.Point(317, 174);
            this.Game_AALabel.Name = "Game_AALabel";
            this.Game_AALabel.Size = new System.Drawing.Size(114, 24);
            this.Game_AALabel.TabIndex = 46;
            this.Game_AALabel.Text = "Anti-Aliasing";
            this.Game_AALabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Game_ResolutionLabel
            // 
            this.Game_ResolutionLabel.AutoSize = true;
            this.Game_ResolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_ResolutionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Game_ResolutionLabel.Location = new System.Drawing.Point(54, 86);
            this.Game_ResolutionLabel.Name = "Game_ResolutionLabel";
            this.Game_ResolutionLabel.Size = new System.Drawing.Size(99, 24);
            this.Game_ResolutionLabel.TabIndex = 45;
            this.Game_ResolutionLabel.Text = "Resolution";
            this.Game_ResolutionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox1_Detail
            // 
            this.comboBox1_Detail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_Detail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1_Detail.FormattingEnabled = true;
            this.comboBox1_Detail.Items.AddRange(new object[] {
            "1920 x 1080",
            "1280 x 720"});
            this.comboBox1_Detail.Location = new System.Drawing.Point(318, 116);
            this.comboBox1_Detail.Name = "comboBox1_Detail";
            this.comboBox1_Detail.Size = new System.Drawing.Size(154, 32);
            this.comboBox1_Detail.TabIndex = 44;
            this.comboBox1_Detail.Text = "Ultra";
            // 
            // checkBox2_Vsync
            // 
            this.checkBox2_Vsync.AutoSize = true;
            this.checkBox2_Vsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2_Vsync.Location = new System.Drawing.Point(58, 210);
            this.checkBox2_Vsync.Name = "checkBox2_Vsync";
            this.checkBox2_Vsync.Size = new System.Drawing.Size(81, 28);
            this.checkBox2_Vsync.TabIndex = 43;
            this.checkBox2_Vsync.Text = "Vsync";
            this.checkBox2_Vsync.UseVisualStyleBackColor = true;
            // 
            // checkBox1_Fullscreen
            // 
            this.checkBox1_Fullscreen.AutoSize = true;
            this.checkBox1_Fullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_Fullscreen.Location = new System.Drawing.Point(58, 167);
            this.checkBox1_Fullscreen.Name = "checkBox1_Fullscreen";
            this.checkBox1_Fullscreen.Size = new System.Drawing.Size(118, 28);
            this.checkBox1_Fullscreen.TabIndex = 42;
            this.checkBox1_Fullscreen.Text = "Fullscreen";
            this.checkBox1_Fullscreen.UseVisualStyleBackColor = true;
            // 
            // ResolutionBox
            // 
            this.ResolutionBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ResolutionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResolutionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ResolutionBox.FormattingEnabled = true;
            this.ResolutionBox.Items.AddRange(new object[] {
            "1920 x 1080",
            "1280 x 720"});
            this.ResolutionBox.Location = new System.Drawing.Point(57, 116);
            this.ResolutionBox.Name = "ResolutionBox";
            this.ResolutionBox.Size = new System.Drawing.Size(154, 32);
            this.ResolutionBox.TabIndex = 41;
            this.ResolutionBox.Text = "1920 x 1080";
            this.ResolutionBox.SelectedIndexChanged += new System.EventHandler(this.ResolutionBox_SelectedIndexChanged);
            // 
            // Game_DetailLabel
            // 
            this.Game_DetailLabel.AutoSize = true;
            this.Game_DetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_DetailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Game_DetailLabel.Location = new System.Drawing.Point(314, 86);
            this.Game_DetailLabel.Name = "Game_DetailLabel";
            this.Game_DetailLabel.Size = new System.Drawing.Size(56, 24);
            this.Game_DetailLabel.TabIndex = 40;
            this.Game_DetailLabel.Text = "Detail";
            this.Game_DetailLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GamePageTitle
            // 
            this.GamePageTitle.AutoSize = true;
            this.GamePageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.GamePageTitle.Location = new System.Drawing.Point(295, 13);
            this.GamePageTitle.Name = "GamePageTitle";
            this.GamePageTitle.Size = new System.Drawing.Size(204, 36);
            this.GamePageTitle.TabIndex = 39;
            this.GamePageTitle.Text = "Game Options";
            // 
            // Game_HeaderLabel
            // 
            this.Game_HeaderLabel.AutoSize = true;
            this.Game_HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_HeaderLabel.Location = new System.Drawing.Point(52, 47);
            this.Game_HeaderLabel.Name = "Game_HeaderLabel";
            this.Game_HeaderLabel.Size = new System.Drawing.Size(195, 26);
            this.Game_HeaderLabel.TabIndex = 37;
            this.Game_HeaderLabel.Text = "Graphics Presets";
            // 
            // GameHLine
            // 
            this.GameHLine.AutoSize = true;
            this.GameHLine.Location = new System.Drawing.Point(53, 61);
            this.GameHLine.Name = "GameHLine";
            this.GameHLine.Size = new System.Drawing.Size(667, 13);
            this.GameHLine.TabIndex = 38;
            this.GameHLine.Text = "_________________________________________________________________________________" +
    "_____________________________";
            // 
            // OtherPanel
            // 
            this.OtherPanel.BackColor = System.Drawing.Color.Transparent;
            this.OtherPanel.Controls.Add(this.button3);
            this.OtherPanel.Controls.Add(this.CacheSizeLabel);
            this.OtherPanel.Controls.Add(this.label1);
            this.OtherPanel.Controls.Add(this.label2);
            this.OtherPanel.Controls.Add(this.label3);
            this.OtherPanel.Location = new System.Drawing.Point(199, 3);
            this.OtherPanel.Name = "OtherPanel";
            this.OtherPanel.Size = new System.Drawing.Size(798, 363);
            this.OtherPanel.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(56, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 54);
            this.button3.TabIndex = 44;
            this.button3.Text = "Clear Cache";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CacheSizeLabel
            // 
            this.CacheSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CacheSizeLabel.AutoSize = true;
            this.CacheSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CacheSizeLabel.Location = new System.Drawing.Point(539, 90);
            this.CacheSizeLabel.Name = "CacheSizeLabel";
            this.CacheSizeLabel.Size = new System.Drawing.Size(118, 37);
            this.CacheSizeLabel.TabIndex = 43;
            this.CacheSizeLabel.Text = "0.0 MB";
            this.CacheSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "Launcher Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Current Cache Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____________________________";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(2, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(194, 54);
            this.button9.TabIndex = 32;
            this.button9.Text = "General";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Lime;
            this.button10.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(2, 62);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(194, 54);
            this.button10.TabIndex = 31;
            this.button10.Text = "Other";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Pick_A_Label
            // 
            this.Pick_A_Label.AutoSize = true;
            this.Pick_A_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pick_A_Label.Location = new System.Drawing.Point(440, 199);
            this.Pick_A_Label.Name = "Pick_A_Label";
            this.Pick_A_Label.Size = new System.Drawing.Size(255, 29);
            this.Pick_A_Label.TabIndex = 41;
            this.Pick_A_Label.Text = "Pick a tool from the left";
            // 
            // ToPanelButton
            // 
            this.ToPanelButton.BackColor = System.Drawing.Color.Transparent;
            this.ToPanelButton.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.ToPanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ToPanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ToPanelButton.FlatAppearance.BorderSize = 0;
            this.ToPanelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.ToPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ToPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToPanelButton.ForeColor = System.Drawing.Color.White;
            this.ToPanelButton.Location = new System.Drawing.Point(1, 547);
            this.ToPanelButton.Name = "ToPanelButton";
            this.ToPanelButton.Size = new System.Drawing.Size(207, 54);
            this.ToPanelButton.TabIndex = 25;
            this.ToPanelButton.Text = "Tools";
            this.ToPanelButton.UseVisualStyleBackColor = false;
            this.ToPanelButton.Click += new System.EventHandler(this.ToPanelButton_Click);
            // 
            // ToMainButton
            // 
            this.ToMainButton.BackColor = System.Drawing.Color.Transparent;
            this.ToMainButton.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.ToMainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToMainButton.FlatAppearance.BorderSize = 0;
            this.ToMainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.ToMainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ToMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ToMainButton.ForeColor = System.Drawing.Color.White;
            this.ToMainButton.Location = new System.Drawing.Point(1, 547);
            this.ToMainButton.Margin = new System.Windows.Forms.Padding(0);
            this.ToMainButton.Name = "ToMainButton";
            this.ToMainButton.Size = new System.Drawing.Size(206, 54);
            this.ToMainButton.TabIndex = 26;
            this.ToMainButton.Text = "Main Menu";
            this.ToMainButton.UseVisualStyleBackColor = false;
            this.ToMainButton.Click += new System.EventHandler(this.ToMainButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 73);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1000, 476);
            this.webBrowser1.TabIndex = 23;
            this.webBrowser1.Url = new System.Uri("http://www.almerra.com/updates", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImage = global::Launcher.Properties.Resources.mini;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(936, 2);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 29);
            this.MinimizeButton.TabIndex = 27;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(206, 547);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(206, 54);
            this.button12.TabIndex = 28;
            this.button12.Text = "News";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Launcher.Properties.Resources.speakerON;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(855, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // progressBar0
            // 
            this.progressBar0.BackColor = System.Drawing.Color.Lime;
            this.progressBar0.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar0.ForeColor = System.Drawing.Color.Red;
            this.progressBar0.Location = new System.Drawing.Point(0, 549);
            this.progressBar0.Name = "progressBar0";
            this.progressBar0.Size = new System.Drawing.Size(1000, 1);
            this.progressBar0.Step = 100;
            this.progressBar0.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar0.TabIndex = 60;
            this.progressBar0.Value = 1;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.VersionLabel.Location = new System.Drawing.Point(16, 514);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(972, 22);
            this.VersionLabel.TabIndex = 62;
            this.VersionLabel.Text = "WoA_xxxx_xxxx";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(743, 547);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 54);
            this.button4.TabIndex = 63;
            this.button4.Text = "^";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DDpanel1
            // 
            this.DDpanel1.Location = new System.Drawing.Point(592, 349);
            this.DDpanel1.Name = "DDpanel1";
            this.DDpanel1.Size = new System.Drawing.Size(197, 200);
            this.DDpanel1.TabIndex = 64;
            this.DDpanel1.Visible = false;
            // 
            // DDpanel2
            // 
            this.DDpanel2.Location = new System.Drawing.Point(795, 349);
            this.DDpanel2.Name = "DDpanel2";
            this.DDpanel2.Size = new System.Drawing.Size(197, 200);
            this.DDpanel2.TabIndex = 65;
            this.DDpanel2.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(944, 547);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 54);
            this.button5.TabIndex = 66;
            this.button5.Text = "^";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.DDpanel1);
            this.Controls.Add(this.DDpanel2);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.progressBar0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ToPanelButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.play);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.ToMainButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.font);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winds of Almerra";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.font)).EndInit();
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.OtherPanel.ResumeLayout(false);
            this.OtherPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox font;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Button ToPanelButton;
        private System.Windows.Forms.Button ToMainButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel OtherPanel;
        private System.Windows.Forms.Label Pick_A_Label;
        private System.Windows.Forms.Label Game_HeaderLabel;
        private System.Windows.Forms.Label GameHLine;
        private System.Windows.Forms.Label GamePageTitle;
        private System.Windows.Forms.CheckBox checkBox1_Fullscreen;
        private System.Windows.Forms.ComboBox ResolutionBox;
        private System.Windows.Forms.CheckBox checkBox2_Vsync;
        private System.Windows.Forms.Label Game_ResolutionLabel;
        private System.Windows.Forms.ComboBox comboBox1_Detail;
        private System.Windows.Forms.Label Game_DetailLabel;
        private System.Windows.Forms.ComboBox comboBox3_Shadows;
        private System.Windows.Forms.Label Game_ShadowLabel;
        private System.Windows.Forms.ComboBox comboBox2_AA;
        private System.Windows.Forms.Label Game_AALabel;
        private System.Windows.Forms.Label Game_NoteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private EventHandler comboBox3_SelectedIndexChanged;
        private EventHandler comboBox1_SelectedIndexChanged;
        private System.Windows.Forms.ProgressBar progressBar0;
        private System.Windows.Forms.Label CacheSizeLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel DDpanel1;
        private System.Windows.Forms.Panel DDpanel2;
        private System.Windows.Forms.Button button5;
    }
}

