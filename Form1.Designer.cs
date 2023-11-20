﻿namespace testrun2
{
    partial class ReaperV1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaperV1));
            this.MainLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.INI_Section = new System.Windows.Forms.Label();
            this.lvlup_underline = new System.Windows.Forms.Label();
            this.Canvas_Section = new System.Windows.Forms.Label();
            this.Game_Section = new System.Windows.Forms.Label();
            this.Current_Section = new System.Windows.Forms.Label();
            this.Default = new System.Windows.Forms.Button();
            this.Soft = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.GenTwo = new System.Windows.Forms.Button();
            this.Pvp = new System.Windows.Forms.Button();
            this.Extinction = new System.Windows.Forms.Button();
            this.Open_File = new System.Windows.Forms.Button();
            this.Clear_File = new System.Windows.Forms.Button();
            this.Launch_Game = new System.Windows.Forms.Button();
            this.Close_Game = new System.Windows.Forms.Button();
            this.Open_CV_Folder = new System.Windows.Forms.Button();
            this.Canvas_Browser = new System.Windows.Forms.Button();
            this.Reconnect = new System.Windows.Forms.Button();
            this.TabOptions = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.CS_Section = new System.Windows.Forms.Label();
            this.SkinDelete = new System.Windows.Forms.Button();
            this.Create_INI_File = new System.Windows.Forms.Button();
            this.SkinRestore = new System.Windows.Forms.Button();
            this.Gamma_Input = new System.Windows.Forms.TextBox();
            this.gammaTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MainLabel.Location = new System.Drawing.Point(12, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(143, 31);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Reaper V2";
            this.MainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.MainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.Color.Transparent;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CloseLabel.Location = new System.Drawing.Point(1002, 4);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(30, 33);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "x";
            this.CloseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MinimizeLabel.Location = new System.Drawing.Point(970, 9);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(25, 33);
            this.MinimizeLabel.TabIndex = 2;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // INI_Section
            // 
            this.INI_Section.AutoSize = true;
            this.INI_Section.BackColor = System.Drawing.Color.Transparent;
            this.INI_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INI_Section.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.INI_Section.Location = new System.Drawing.Point(33, 94);
            this.INI_Section.Name = "INI_Section";
            this.INI_Section.Size = new System.Drawing.Size(121, 25);
            this.INI_Section.TabIndex = 5;
            this.INI_Section.Text = "INI Settings";
            this.INI_Section.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvlup_underline
            // 
            this.lvlup_underline.AutoSize = true;
            this.lvlup_underline.BackColor = System.Drawing.Color.Transparent;
            this.lvlup_underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lvlup_underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlup_underline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.lvlup_underline.Location = new System.Drawing.Point(255, -1);
            this.lvlup_underline.Name = "lvlup_underline";
            this.lvlup_underline.Size = new System.Drawing.Size(543, 33);
            this.lvlup_underline.TabIndex = 6;
            this.lvlup_underline.Text = "_________________________________";
            // 
            // Canvas_Section
            // 
            this.Canvas_Section.AutoSize = true;
            this.Canvas_Section.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Section.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.Canvas_Section.Location = new System.Drawing.Point(901, 94);
            this.Canvas_Section.Name = "Canvas_Section";
            this.Canvas_Section.Size = new System.Drawing.Size(85, 25);
            this.Canvas_Section.TabIndex = 8;
            this.Canvas_Section.Text = "Canvas";
            this.Canvas_Section.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game_Section
            // 
            this.Game_Section.AutoSize = true;
            this.Game_Section.BackColor = System.Drawing.Color.Transparent;
            this.Game_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Section.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.Game_Section.Location = new System.Drawing.Point(771, 94);
            this.Game_Section.Name = "Game_Section";
            this.Game_Section.Size = new System.Drawing.Size(124, 25);
            this.Game_Section.TabIndex = 9;
            this.Game_Section.Text = "Base Game";
            this.Game_Section.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Current_Section
            // 
            this.Current_Section.AutoSize = true;
            this.Current_Section.BackColor = System.Drawing.Color.Transparent;
            this.Current_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Section.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.Current_Section.Location = new System.Drawing.Point(160, 94);
            this.Current_Section.Name = "Current_Section";
            this.Current_Section.Size = new System.Drawing.Size(141, 25);
            this.Current_Section.TabIndex = 10;
            this.Current_Section.Text = "Your Current ";
            this.Current_Section.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Default
            // 
            this.Default.AutoSize = true;
            this.Default.BackColor = System.Drawing.Color.Transparent;
            this.Default.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Default.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Default.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Default.Location = new System.Drawing.Point(38, 131);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(93, 35);
            this.Default.TabIndex = 11;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = false;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // Soft
            // 
            this.Soft.AutoSize = true;
            this.Soft.BackColor = System.Drawing.Color.Transparent;
            this.Soft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soft.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Soft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Soft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Soft.Location = new System.Drawing.Point(38, 172);
            this.Soft.Name = "Soft";
            this.Soft.Size = new System.Drawing.Size(93, 35);
            this.Soft.TabIndex = 12;
            this.Soft.Text = "Soft";
            this.Soft.UseVisualStyleBackColor = false;
            this.Soft.Click += new System.EventHandler(this.Soft_Click);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.BackColor = System.Drawing.Color.Transparent;
            this.hard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hard.Cursor = System.Windows.Forms.Cursors.Cross;
            this.hard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.hard.Location = new System.Drawing.Point(38, 213);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(93, 35);
            this.hard.TabIndex = 13;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // GenTwo
            // 
            this.GenTwo.AutoSize = true;
            this.GenTwo.BackColor = System.Drawing.Color.Transparent;
            this.GenTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GenTwo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GenTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GenTwo.Location = new System.Drawing.Point(38, 254);
            this.GenTwo.Name = "GenTwo";
            this.GenTwo.Size = new System.Drawing.Size(93, 35);
            this.GenTwo.TabIndex = 14;
            this.GenTwo.Text = "GenTwo";
            this.GenTwo.UseVisualStyleBackColor = false;
            this.GenTwo.Click += new System.EventHandler(this.GenTwo_Click);
            // 
            // Pvp
            // 
            this.Pvp.AutoSize = true;
            this.Pvp.BackColor = System.Drawing.Color.Transparent;
            this.Pvp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pvp.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Pvp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pvp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pvp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Pvp.Location = new System.Drawing.Point(38, 336);
            this.Pvp.Name = "Pvp";
            this.Pvp.Size = new System.Drawing.Size(93, 35);
            this.Pvp.TabIndex = 16;
            this.Pvp.Text = "Pvp";
            this.Pvp.UseVisualStyleBackColor = false;
            this.Pvp.Click += new System.EventHandler(this.Pvp_Click);
            // 
            // Extinction
            // 
            this.Extinction.AutoSize = true;
            this.Extinction.BackColor = System.Drawing.Color.Transparent;
            this.Extinction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Extinction.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Extinction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Extinction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extinction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Extinction.Location = new System.Drawing.Point(38, 295);
            this.Extinction.Name = "Extinction";
            this.Extinction.Size = new System.Drawing.Size(93, 35);
            this.Extinction.TabIndex = 17;
            this.Extinction.Text = "Extinction";
            this.Extinction.UseVisualStyleBackColor = false;
            this.Extinction.Click += new System.EventHandler(this.Extinction_Click);
            // 
            // Open_File
            // 
            this.Open_File.AutoSize = true;
            this.Open_File.BackColor = System.Drawing.Color.Transparent;
            this.Open_File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Open_File.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Open_File.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Open_File.Location = new System.Drawing.Point(165, 131);
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(93, 35);
            this.Open_File.TabIndex = 18;
            this.Open_File.Text = "Open File";
            this.Open_File.UseVisualStyleBackColor = false;
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // Clear_File
            // 
            this.Clear_File.AutoSize = true;
            this.Clear_File.BackColor = System.Drawing.Color.Transparent;
            this.Clear_File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clear_File.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Clear_File.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Clear_File.Location = new System.Drawing.Point(165, 172);
            this.Clear_File.Name = "Clear_File";
            this.Clear_File.Size = new System.Drawing.Size(93, 35);
            this.Clear_File.TabIndex = 19;
            this.Clear_File.Text = "Clear File";
            this.Clear_File.UseVisualStyleBackColor = false;
            this.Clear_File.Click += new System.EventHandler(this.Clear_File_Click);
            // 
            // Launch_Game
            // 
            this.Launch_Game.AutoSize = true;
            this.Launch_Game.BackColor = System.Drawing.Color.Transparent;
            this.Launch_Game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Launch_Game.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Launch_Game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launch_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launch_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Launch_Game.Location = new System.Drawing.Point(776, 131);
            this.Launch_Game.Name = "Launch_Game";
            this.Launch_Game.Size = new System.Drawing.Size(93, 35);
            this.Launch_Game.TabIndex = 20;
            this.Launch_Game.Text = "Launch ";
            this.Launch_Game.UseVisualStyleBackColor = false;
            this.Launch_Game.Click += new System.EventHandler(this.Launch_Game_Click);
            // 
            // Close_Game
            // 
            this.Close_Game.AutoSize = true;
            this.Close_Game.BackColor = System.Drawing.Color.Transparent;
            this.Close_Game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_Game.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Close_Game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Close_Game.Location = new System.Drawing.Point(776, 172);
            this.Close_Game.Name = "Close_Game";
            this.Close_Game.Size = new System.Drawing.Size(93, 35);
            this.Close_Game.TabIndex = 21;
            this.Close_Game.Text = "Close";
            this.Close_Game.UseVisualStyleBackColor = false;
            this.Close_Game.Click += new System.EventHandler(this.Close_Game_Click);
            // 
            // Open_CV_Folder
            // 
            this.Open_CV_Folder.AutoSize = true;
            this.Open_CV_Folder.BackColor = System.Drawing.Color.Transparent;
            this.Open_CV_Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Open_CV_Folder.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Open_CV_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open_CV_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_CV_Folder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Open_CV_Folder.Location = new System.Drawing.Point(906, 131);
            this.Open_CV_Folder.Name = "Open_CV_Folder";
            this.Open_CV_Folder.Size = new System.Drawing.Size(108, 35);
            this.Open_CV_Folder.TabIndex = 22;
            this.Open_CV_Folder.Text = "Open Canvas";
            this.Open_CV_Folder.UseVisualStyleBackColor = false;
            this.Open_CV_Folder.Click += new System.EventHandler(this.Open_CV_Folder_Click);
            // 
            // Canvas_Browser
            // 
            this.Canvas_Browser.AutoSize = true;
            this.Canvas_Browser.BackColor = System.Drawing.Color.Transparent;
            this.Canvas_Browser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Canvas_Browser.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas_Browser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Canvas_Browser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canvas_Browser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Canvas_Browser.Location = new System.Drawing.Point(906, 172);
            this.Canvas_Browser.Name = "Canvas_Browser";
            this.Canvas_Browser.Size = new System.Drawing.Size(109, 35);
            this.Canvas_Browser.TabIndex = 23;
            this.Canvas_Browser.Text = "Basic Canvas";
            this.Canvas_Browser.UseVisualStyleBackColor = false;
            this.Canvas_Browser.Click += new System.EventHandler(this.Canvas_Browser_Click);
            // 
            // Reconnect
            // 
            this.Reconnect.AutoSize = true;
            this.Reconnect.BackColor = System.Drawing.Color.Transparent;
            this.Reconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Reconnect.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Reconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Reconnect.Location = new System.Drawing.Point(312, 131);
            this.Reconnect.Name = "Reconnect";
            this.Reconnect.Size = new System.Drawing.Size(93, 35);
            this.Reconnect.TabIndex = 24;
            this.Reconnect.Text = "Reconnect";
            this.Reconnect.UseVisualStyleBackColor = false;
            this.Reconnect.Click += new System.EventHandler(this.Reconnect_Click);
            // 
            // TabOptions
            // 
            this.TabOptions.AutoSize = true;
            this.TabOptions.BackColor = System.Drawing.Color.Transparent;
            this.TabOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.TabOptions.Location = new System.Drawing.Point(307, 94);
            this.TabOptions.Name = "TabOptions";
            this.TabOptions.Size = new System.Drawing.Size(134, 25);
            this.TabOptions.TabIndex = 25;
            this.TabOptions.Text = "TabFeatures";
            this.TabOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disconnect
            // 
            this.Disconnect.AutoSize = true;
            this.Disconnect.BackColor = System.Drawing.Color.Transparent;
            this.Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Disconnect.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Disconnect.Location = new System.Drawing.Point(312, 172);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(93, 35);
            this.Disconnect.TabIndex = 26;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // CS_Section
            // 
            this.CS_Section.AutoSize = true;
            this.CS_Section.BackColor = System.Drawing.Color.Transparent;
            this.CS_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CS_Section.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.CS_Section.Location = new System.Drawing.Point(623, 94);
            this.CS_Section.Name = "CS_Section";
            this.CS_Section.Size = new System.Drawing.Size(100, 25);
            this.CS_Section.TabIndex = 27;
            this.CS_Section.Text = "Texture\'s";
            this.CS_Section.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkinDelete
            // 
            this.SkinDelete.AutoSize = true;
            this.SkinDelete.BackColor = System.Drawing.Color.Transparent;
            this.SkinDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SkinDelete.Cursor = System.Windows.Forms.Cursors.Cross;
            this.SkinDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkinDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkinDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SkinDelete.Location = new System.Drawing.Point(628, 131);
            this.SkinDelete.Name = "SkinDelete";
            this.SkinDelete.Size = new System.Drawing.Size(93, 35);
            this.SkinDelete.TabIndex = 28;
            this.SkinDelete.Text = "Delete ";
            this.SkinDelete.UseVisualStyleBackColor = false;
            this.SkinDelete.Click += new System.EventHandler(this.SkinDelete_Click);
            // 
            // Create_INI_File
            // 
            this.Create_INI_File.AutoSize = true;
            this.Create_INI_File.BackColor = System.Drawing.Color.Transparent;
            this.Create_INI_File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Create_INI_File.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Create_INI_File.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Create_INI_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_INI_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Create_INI_File.Location = new System.Drawing.Point(165, 213);
            this.Create_INI_File.Name = "Create_INI_File";
            this.Create_INI_File.Size = new System.Drawing.Size(93, 35);
            this.Create_INI_File.TabIndex = 29;
            this.Create_INI_File.Text = "Create File";
            this.Create_INI_File.UseVisualStyleBackColor = false;
            this.Create_INI_File.Click += new System.EventHandler(this.Create_INI_File_Click);
            // 
            // SkinRestore
            // 
            this.SkinRestore.AutoSize = true;
            this.SkinRestore.BackColor = System.Drawing.Color.Transparent;
            this.SkinRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SkinRestore.Cursor = System.Windows.Forms.Cursors.Cross;
            this.SkinRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkinRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkinRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SkinRestore.Location = new System.Drawing.Point(628, 172);
            this.SkinRestore.Name = "SkinRestore";
            this.SkinRestore.Size = new System.Drawing.Size(93, 35);
            this.SkinRestore.TabIndex = 34;
            this.SkinRestore.Text = "Restore ";
            this.SkinRestore.UseVisualStyleBackColor = false;
            this.SkinRestore.Click += new System.EventHandler(this.SkinRestore_Click);
            // 
            // Gamma_Input
            // 
            this.Gamma_Input.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gamma_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gamma_Input.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Gamma_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamma_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Gamma_Input.Location = new System.Drawing.Point(418, 302);
            this.Gamma_Input.Name = "Gamma_Input";
            this.Gamma_Input.Size = new System.Drawing.Size(207, 21);
            this.Gamma_Input.TabIndex = 0;
            this.Gamma_Input.Text = "Gamma Value";
            this.Gamma_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gamma_Input.TextChanged += new System.EventHandler(this.Gamma_Input_TextChanged);
            // 
            // gammaTimer
            // 
            this.gammaTimer.Tick += new System.EventHandler(this.gammaTimer_Tick);
            // 
            // ReaperV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1054, 401);
            this.Controls.Add(this.Gamma_Input);
            this.Controls.Add(this.SkinRestore);
            this.Controls.Add(this.Create_INI_File);
            this.Controls.Add(this.SkinDelete);
            this.Controls.Add(this.CS_Section);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.TabOptions);
            this.Controls.Add(this.Reconnect);
            this.Controls.Add(this.Canvas_Browser);
            this.Controls.Add(this.Open_CV_Folder);
            this.Controls.Add(this.Close_Game);
            this.Controls.Add(this.Launch_Game);
            this.Controls.Add(this.Clear_File);
            this.Controls.Add(this.Open_File);
            this.Controls.Add(this.Extinction);
            this.Controls.Add(this.Pvp);
            this.Controls.Add(this.GenTwo);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.Soft);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.Current_Section);
            this.Controls.Add(this.Game_Section);
            this.Controls.Add(this.Canvas_Section);
            this.Controls.Add(this.lvlup_underline);
            this.Controls.Add(this.INI_Section);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.MainLabel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(224)))), ((int)(((byte)(76)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReaperV1";
            this.Text = "ReaperV1";
            this.Load += new System.EventHandler(this.ReaperV1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label INI_Section;
        private System.Windows.Forms.Label lvlup_underline;
        private System.Windows.Forms.Label Canvas_Section;
        private System.Windows.Forms.Label Game_Section;
        private System.Windows.Forms.Label Current_Section;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.Button Soft;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button GenTwo;
        private System.Windows.Forms.Button Pvp;
        private System.Windows.Forms.Button Extinction;
        private System.Windows.Forms.Button Open_File;
        private System.Windows.Forms.Button Clear_File;
        private System.Windows.Forms.Button Launch_Game;
        private System.Windows.Forms.Button Close_Game;
        private System.Windows.Forms.Button Open_CV_Folder;
        private System.Windows.Forms.Button Canvas_Browser;
        private System.Windows.Forms.Button Reconnect;
        private System.Windows.Forms.Label TabOptions;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label CS_Section;
        private System.Windows.Forms.Button SkinDelete;
        private System.Windows.Forms.Button Create_INI_File;
        private System.Windows.Forms.Button SkinRestore;
        private System.Windows.Forms.TextBox Gamma_Input;
        private System.Windows.Forms.Timer gammaTimer;
    }
}

