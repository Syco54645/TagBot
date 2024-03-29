﻿
using TagBot.App.usercontrols;

namespace TagBot.App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imgListFileIcons = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCommonTags = new System.Windows.Forms.GroupBox();
            this.btnAutofillComment = new System.Windows.Forms.Button();
            this.btnAutofillDate = new System.Windows.Forms.Button();
            this.btnAutofillAlbum = new System.Windows.Forms.Button();
            this.btnAutofillArtist = new System.Windows.Forms.Button();
            this.btnAutoFillCommonTags = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpFileTags = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpFIleInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDbInfo = new System.Windows.Forms.Button();
            this.txtLoadedDatabase = new System.Windows.Forms.TextBox();
            this.btnLoadDatabase = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scFileTagFlac = new System.Windows.Forms.SplitContainer();
            this.pnlFileView = new System.Windows.Forms.Panel();
            this.pnlDirectoryBrowserToolbar = new System.Windows.Forms.Panel();
            this.tsDirectoryBrowser = new System.Windows.Forms.ToolStrip();
            this.tsbSelectDirectory = new System.Windows.Forms.ToolStripButton();
            this.tstbLocation = new System.Windows.Forms.ToolStripTextBox();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tvDirectories = new System.Windows.Forms.TreeView();
            this.pnlShowSearch = new System.Windows.Forms.Panel();
            this.pnlTagView = new System.Windows.Forms.Panel();
            this.scFlacText = new System.Windows.Forms.SplitContainer();
            this.pnlTvMatchFiles = new System.Windows.Forms.Panel();
            this.tsAudioBrowser = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tslMatchFilesCount = new System.Windows.Forms.ToolStripLabel();
            this.tsbSeekBack = new System.Windows.Forms.ToolStripButton();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbSeekAhead = new System.Windows.Forms.ToolStripButton();
            this.tcFilename = new Aga.Controls.Tree.TreeColumn();
            this.tcNumber = new Aga.Controls.Tree.TreeColumn();
            this.tcTitle = new Aga.Controls.Tree.TreeColumn();
            this.tcArtist = new Aga.Controls.Tree.TreeColumn();
            this.tcAlbum = new Aga.Controls.Tree.TreeColumn();
            this.nodeIcon1 = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.ntbFile = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntbNumber = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntbTitle = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntbArtist = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntbAlbum = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scTopBottom = new System.Windows.Forms.SplitContainer();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tsbLastThirty = new System.Windows.Forms.ToolStripButton();
            this.txtOverallDate = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtOverallArtist = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtOverallComment = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtOverallAlbum = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtMetadataComment = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtMetadataDate = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtMetadataTitle = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtMetadataAlbum = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtMetadataTrackNumber = new TagBot.App.usercontrols.TextboxToolTip();
            this.txtMetadataArtist = new TagBot.App.usercontrols.TextboxToolTip();
            this.lblCurrentFile = new TagBot.App.LabelToolTip();
            this.lblEncoder = new TagBot.App.LabelToolTip();
            this.lblDuration = new TagBot.App.LabelToolTip();
            this.lblSize = new TagBot.App.LabelToolTip();
            this.lblChannels = new TagBot.App.LabelToolTip();
            this.lblSampleRate = new TagBot.App.LabelToolTip();
            this.lblBitrate = new TagBot.App.LabelToolTip();
            this.srtfLog = new TagBot.App.ScrollingRichTextBox();
            this.groupBox1.SuspendLayout();
            this.grpCommonTags.SuspendLayout();
            this.grpFileTags.SuspendLayout();
            this.grpFIleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scFileTagFlac)).BeginInit();
            this.scFileTagFlac.Panel1.SuspendLayout();
            this.scFileTagFlac.Panel2.SuspendLayout();
            this.scFileTagFlac.SuspendLayout();
            this.pnlFileView.SuspendLayout();
            this.pnlDirectoryBrowserToolbar.SuspendLayout();
            this.tsDirectoryBrowser.SuspendLayout();
            this.pnlShowSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scFlacText)).BeginInit();
            this.scFlacText.Panel1.SuspendLayout();
            this.scFlacText.SuspendLayout();
            this.tsAudioBrowser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTopBottom)).BeginInit();
            this.scTopBottom.Panel1.SuspendLayout();
            this.scTopBottom.Panel2.SuspendLayout();
            this.scTopBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgListFileIcons
            // 
            this.imgListFileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListFileIcons.ImageStream")));
            this.imgListFileIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListFileIcons.Images.SetKeyName(0, "folder");
            this.imgListFileIcons.Images.SetKeyName(1, "audio");
            this.imgListFileIcons.Images.SetKeyName(2, "file");
            this.imgListFileIcons.Images.SetKeyName(3, "text");
            this.imgListFileIcons.Images.SetKeyName(4, "save");
            this.imgListFileIcons.Images.SetKeyName(5, "refresh");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpCommonTags);
            this.groupBox1.Controls.Add(this.grpFileTags);
            this.groupBox1.Controls.Add(this.grpFIleInfo);
            this.groupBox1.Controls.Add(this.btnDbInfo);
            this.groupBox1.Controls.Add(this.txtLoadedDatabase);
            this.groupBox1.Controls.Add(this.btnLoadDatabase);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBox1.Size = new System.Drawing.Size(370, 457);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // grpCommonTags
            // 
            this.grpCommonTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCommonTags.Controls.Add(this.btnAutofillComment);
            this.grpCommonTags.Controls.Add(this.btnAutofillDate);
            this.grpCommonTags.Controls.Add(this.btnAutofillAlbum);
            this.grpCommonTags.Controls.Add(this.btnAutofillArtist);
            this.grpCommonTags.Controls.Add(this.btnAutoFillCommonTags);
            this.grpCommonTags.Controls.Add(this.label14);
            this.grpCommonTags.Controls.Add(this.label17);
            this.grpCommonTags.Controls.Add(this.label16);
            this.grpCommonTags.Controls.Add(this.txtOverallDate);
            this.grpCommonTags.Controls.Add(this.txtOverallArtist);
            this.grpCommonTags.Controls.Add(this.txtOverallComment);
            this.grpCommonTags.Controls.Add(this.label15);
            this.grpCommonTags.Controls.Add(this.txtOverallAlbum);
            this.grpCommonTags.Location = new System.Drawing.Point(8, 304);
            this.grpCommonTags.Name = "grpCommonTags";
            this.grpCommonTags.Size = new System.Drawing.Size(352, 144);
            this.grpCommonTags.TabIndex = 61;
            this.grpCommonTags.TabStop = false;
            this.grpCommonTags.Text = "Common Tags";
            // 
            // btnAutofillComment
            // 
            this.btnAutofillComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutofillComment.Location = new System.Drawing.Point(314, 89);
            this.btnAutofillComment.Name = "btnAutofillComment";
            this.btnAutofillComment.Size = new System.Drawing.Size(20, 20);
            this.btnAutofillComment.TabIndex = 304;
            this.btnAutofillComment.Text = "A";
            this.btnAutofillComment.UseVisualStyleBackColor = true;
            this.btnAutofillComment.Click += new System.EventHandler(this.btnAutofillComment_Click);
            // 
            // btnAutofillDate
            // 
            this.btnAutofillDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutofillDate.Location = new System.Drawing.Point(314, 65);
            this.btnAutofillDate.Name = "btnAutofillDate";
            this.btnAutofillDate.Size = new System.Drawing.Size(20, 20);
            this.btnAutofillDate.TabIndex = 303;
            this.btnAutofillDate.Text = "A";
            this.btnAutofillDate.UseVisualStyleBackColor = true;
            this.btnAutofillDate.Click += new System.EventHandler(this.btnAutofillDate_Click);
            // 
            // btnAutofillAlbum
            // 
            this.btnAutofillAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutofillAlbum.Location = new System.Drawing.Point(314, 43);
            this.btnAutofillAlbum.Name = "btnAutofillAlbum";
            this.btnAutofillAlbum.Size = new System.Drawing.Size(20, 20);
            this.btnAutofillAlbum.TabIndex = 302;
            this.btnAutofillAlbum.Text = "A";
            this.btnAutofillAlbum.UseVisualStyleBackColor = true;
            this.btnAutofillAlbum.Click += new System.EventHandler(this.btnAutofillAlbum_Click);
            // 
            // btnAutofillArtist
            // 
            this.btnAutofillArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutofillArtist.Location = new System.Drawing.Point(314, 20);
            this.btnAutofillArtist.Name = "btnAutofillArtist";
            this.btnAutofillArtist.Size = new System.Drawing.Size(20, 20);
            this.btnAutofillArtist.TabIndex = 301;
            this.btnAutofillArtist.Text = "A";
            this.btnAutofillArtist.UseVisualStyleBackColor = true;
            this.btnAutofillArtist.Click += new System.EventHandler(this.btnAutofillArtist_Click);
            // 
            // btnAutoFillCommonTags
            // 
            this.btnAutoFillCommonTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoFillCommonTags.Location = new System.Drawing.Point(262, 112);
            this.btnAutoFillCommonTags.Name = "btnAutoFillCommonTags";
            this.btnAutoFillCommonTags.Size = new System.Drawing.Size(75, 23);
            this.btnAutoFillCommonTags.TabIndex = 300;
            this.btnAutoFillCommonTags.Text = "Auto Fill All";
            this.btnAutoFillCommonTags.UseVisualStyleBackColor = true;
            this.btnAutoFillCommonTags.Click += new System.EventHandler(this.btnAutoFillCommonTags_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Comment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Artist";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Album";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Date";
            // 
            // grpFileTags
            // 
            this.grpFileTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFileTags.Controls.Add(this.label18);
            this.grpFileTags.Controls.Add(this.txtMetadataComment);
            this.grpFileTags.Controls.Add(this.txtMetadataDate);
            this.grpFileTags.Controls.Add(this.label1);
            this.grpFileTags.Controls.Add(this.label11);
            this.grpFileTags.Controls.Add(this.txtMetadataTitle);
            this.grpFileTags.Controls.Add(this.txtMetadataAlbum);
            this.grpFileTags.Controls.Add(this.label10);
            this.grpFileTags.Controls.Add(this.label9);
            this.grpFileTags.Controls.Add(this.txtMetadataTrackNumber);
            this.grpFileTags.Controls.Add(this.txtMetadataArtist);
            this.grpFileTags.Controls.Add(this.label8);
            this.grpFileTags.Location = new System.Drawing.Point(8, 128);
            this.grpFileTags.Name = "grpFileTags";
            this.grpFileTags.Size = new System.Drawing.Size(352, 168);
            this.grpFileTags.TabIndex = 61;
            this.grpFileTags.TabStop = false;
            this.grpFileTags.Text = "File Tags";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Album";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Artist";
            // 
            // grpFIleInfo
            // 
            this.grpFIleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFIleInfo.Controls.Add(this.lblCurrentFile);
            this.grpFIleInfo.Controls.Add(this.label2);
            this.grpFIleInfo.Controls.Add(this.label3);
            this.grpFIleInfo.Controls.Add(this.label4);
            this.grpFIleInfo.Controls.Add(this.label5);
            this.grpFIleInfo.Controls.Add(this.label6);
            this.grpFIleInfo.Controls.Add(this.label7);
            this.grpFIleInfo.Controls.Add(this.lblEncoder);
            this.grpFIleInfo.Controls.Add(this.lblDuration);
            this.grpFIleInfo.Controls.Add(this.lblSize);
            this.grpFIleInfo.Controls.Add(this.lblChannels);
            this.grpFIleInfo.Controls.Add(this.lblSampleRate);
            this.grpFIleInfo.Controls.Add(this.lblBitrate);
            this.grpFIleInfo.Location = new System.Drawing.Point(8, 41);
            this.grpFIleInfo.Name = "grpFIleInfo";
            this.grpFIleInfo.Size = new System.Drawing.Size(352, 87);
            this.grpFIleInfo.TabIndex = 52;
            this.grpFIleInfo.TabStop = false;
            this.grpFIleInfo.Text = "File Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Encoder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Bitrate";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sample rate";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Channels";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Duration";
            // 
            // btnDbInfo
            // 
            this.btnDbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDbInfo.Location = new System.Drawing.Point(336, 16);
            this.btnDbInfo.Name = "btnDbInfo";
            this.btnDbInfo.Size = new System.Drawing.Size(24, 20);
            this.btnDbInfo.TabIndex = 80;
            this.btnDbInfo.Text = "?";
            this.btnDbInfo.UseVisualStyleBackColor = true;
            this.btnDbInfo.Click += new System.EventHandler(this.btnDbInfo_Click);
            // 
            // txtLoadedDatabase
            // 
            this.txtLoadedDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoadedDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoadedDatabase.Location = new System.Drawing.Point(72, 16);
            this.txtLoadedDatabase.Name = "txtLoadedDatabase";
            this.txtLoadedDatabase.ReadOnly = true;
            this.txtLoadedDatabase.Size = new System.Drawing.Size(232, 20);
            this.txtLoadedDatabase.TabIndex = 7;
            this.txtLoadedDatabase.TabStop = false;
            // 
            // btnLoadDatabase
            // 
            this.btnLoadDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDatabase.Location = new System.Drawing.Point(310, 16);
            this.btnLoadDatabase.Name = "btnLoadDatabase";
            this.btnLoadDatabase.Size = new System.Drawing.Size(24, 20);
            this.btnLoadDatabase.TabIndex = 60;
            this.btnLoadDatabase.Text = "...";
            this.btnLoadDatabase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadDatabase.UseVisualStyleBackColor = true;
            this.btnLoadDatabase.Click += new System.EventHandler(this.btnLoadDatabase_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Database";
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatch.Location = new System.Drawing.Point(226, 4);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 20);
            this.btnMatch.TabIndex = 40;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Show Date";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Location = new System.Drawing.Point(64, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(157, 20);
            this.txtDate.TabIndex = 20;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scFileTagFlac);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.groupBox1);
            this.scMain.Size = new System.Drawing.Size(1278, 457);
            this.scMain.SplitterDistance = 904;
            this.scMain.TabIndex = 6;
            this.scMain.TabStop = false;
            // 
            // scFileTagFlac
            // 
            this.scFileTagFlac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFileTagFlac.Location = new System.Drawing.Point(0, 0);
            this.scFileTagFlac.Name = "scFileTagFlac";
            // 
            // scFileTagFlac.Panel1
            // 
            this.scFileTagFlac.Panel1.Controls.Add(this.pnlFileView);
            this.scFileTagFlac.Panel1.Controls.Add(this.pnlTagView);
            // 
            // scFileTagFlac.Panel2
            // 
            this.scFileTagFlac.Panel2.Controls.Add(this.scFlacText);
            this.scFileTagFlac.Panel2.Controls.Add(this.tsAudioBrowser);
            this.scFileTagFlac.Size = new System.Drawing.Size(904, 457);
            this.scFileTagFlac.SplitterDistance = 301;
            this.scFileTagFlac.TabIndex = 10;
            this.scFileTagFlac.TabStop = false;
            // 
            // pnlFileView
            // 
            this.pnlFileView.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFileView.Controls.Add(this.pnlDirectoryBrowserToolbar);
            this.pnlFileView.Controls.Add(this.pnlShowSearch);
            this.pnlFileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFileView.Location = new System.Drawing.Point(0, 0);
            this.pnlFileView.Name = "pnlFileView";
            this.pnlFileView.Size = new System.Drawing.Size(301, 457);
            this.pnlFileView.TabIndex = 0;
            // 
            // pnlDirectoryBrowserToolbar
            // 
            this.pnlDirectoryBrowserToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDirectoryBrowserToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDirectoryBrowserToolbar.Controls.Add(this.tsDirectoryBrowser);
            this.pnlDirectoryBrowserToolbar.Controls.Add(this.tvDirectories);
            this.pnlDirectoryBrowserToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlDirectoryBrowserToolbar.Name = "pnlDirectoryBrowserToolbar";
            this.pnlDirectoryBrowserToolbar.Size = new System.Drawing.Size(301, 395);
            this.pnlDirectoryBrowserToolbar.TabIndex = 52;
            // 
            // tsDirectoryBrowser
            // 
            this.tsDirectoryBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelectDirectory,
            this.tstbLocation,
            this.tsbRefresh});
            this.tsDirectoryBrowser.Location = new System.Drawing.Point(0, 0);
            this.tsDirectoryBrowser.Name = "tsDirectoryBrowser";
            this.tsDirectoryBrowser.Size = new System.Drawing.Size(301, 25);
            this.tsDirectoryBrowser.TabIndex = 10;
            this.tsDirectoryBrowser.Text = "toolStrip2";
            this.tsDirectoryBrowser.Resize += new System.EventHandler(this.tsDirectoryBrowser_Resize);
            // 
            // tsbSelectDirectory
            // 
            this.tsbSelectDirectory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelectDirectory.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectDirectory.Image")));
            this.tsbSelectDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectDirectory.Name = "tsbSelectDirectory";
            this.tsbSelectDirectory.Size = new System.Drawing.Size(23, 22);
            this.tsbSelectDirectory.Text = "Select Directory";
            this.tsbSelectDirectory.Click += new System.EventHandler(this.tsbSelectDirectory_Click);
            // 
            // tstbLocation
            // 
            this.tstbLocation.AutoSize = false;
            this.tstbLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstbLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbLocation.Name = "tstbLocation";
            this.tstbLocation.ReadOnly = true;
            this.tstbLocation.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tvDirectories
            // 
            this.tvDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDirectories.HideSelection = false;
            this.tvDirectories.ImageIndex = 0;
            this.tvDirectories.ImageList = this.imgListFileIcons;
            this.tvDirectories.Location = new System.Drawing.Point(0, 24);
            this.tvDirectories.Name = "tvDirectories";
            this.tvDirectories.SelectedImageIndex = 0;
            this.tvDirectories.Size = new System.Drawing.Size(301, 371);
            this.tvDirectories.TabIndex = 4;
            this.tvDirectories.TabStop = false;
            // 
            // pnlShowSearch
            // 
            this.pnlShowSearch.BackColor = System.Drawing.SystemColors.Control;
            this.pnlShowSearch.Controls.Add(this.label12);
            this.pnlShowSearch.Controls.Add(this.txtDate);
            this.pnlShowSearch.Controls.Add(this.btnMatch);
            this.pnlShowSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowSearch.Location = new System.Drawing.Point(0, 393);
            this.pnlShowSearch.Name = "pnlShowSearch";
            this.pnlShowSearch.Size = new System.Drawing.Size(301, 64);
            this.pnlShowSearch.TabIndex = 51;
            // 
            // pnlTagView
            // 
            this.pnlTagView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTagView.Location = new System.Drawing.Point(0, 0);
            this.pnlTagView.Name = "pnlTagView";
            this.pnlTagView.Size = new System.Drawing.Size(301, 457);
            this.pnlTagView.TabIndex = 1;
            // 
            // scFlacText
            // 
            this.scFlacText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFlacText.Location = new System.Drawing.Point(0, 25);
            this.scFlacText.Name = "scFlacText";
            this.scFlacText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scFlacText.Panel1
            // 
            this.scFlacText.Panel1.Controls.Add(this.pnlTvMatchFiles);
            this.scFlacText.Size = new System.Drawing.Size(599, 432);
            this.scFlacText.SplitterDistance = 300;
            this.scFlacText.TabIndex = 10;
            this.scFlacText.TabStop = false;
            // 
            // pnlTvMatchFiles
            // 
            this.pnlTvMatchFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTvMatchFiles.Location = new System.Drawing.Point(0, 0);
            this.pnlTvMatchFiles.Name = "pnlTvMatchFiles";
            this.pnlTvMatchFiles.Size = new System.Drawing.Size(599, 300);
            this.pnlTvMatchFiles.TabIndex = 11;
            // 
            // tsAudioBrowser
            // 
            this.tsAudioBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tslMatchFilesCount,
            this.tsbSeekBack,
            this.tsbPlay,
            this.tsbStop,
            this.tsbSeekAhead,
            this.tsbLastThirty});
            this.tsAudioBrowser.Location = new System.Drawing.Point(0, 0);
            this.tsAudioBrowser.Name = "tsAudioBrowser";
            this.tsAudioBrowser.Size = new System.Drawing.Size(599, 25);
            this.tsAudioBrowser.TabIndex = 12;
            this.tsAudioBrowser.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tslMatchFilesCount
            // 
            this.tslMatchFilesCount.Name = "tslMatchFilesCount";
            this.tslMatchFilesCount.Size = new System.Drawing.Size(42, 22);
            this.tslMatchFilesCount.Text = "Files: 0";
            // 
            // tsbSeekBack
            // 
            this.tsbSeekBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSeekBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbSeekBack.Image")));
            this.tsbSeekBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeekBack.Name = "tsbSeekBack";
            this.tsbSeekBack.Size = new System.Drawing.Size(23, 22);
            this.tsbSeekBack.Text = "Skip Back 30 Seconds";
            this.tsbSeekBack.Click += new System.EventHandler(this.tsbSeekBack_Click);
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsbPlay.Image")));
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "Play";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "Stop";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbSeekAhead
            // 
            this.tsbSeekAhead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSeekAhead.Image = ((System.Drawing.Image)(resources.GetObject("tsbSeekAhead.Image")));
            this.tsbSeekAhead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeekAhead.Name = "tsbSeekAhead";
            this.tsbSeekAhead.Size = new System.Drawing.Size(23, 22);
            this.tsbSeekAhead.Text = "Skip Ahead 30 Seconds";
            this.tsbSeekAhead.Click += new System.EventHandler(this.tsbSeekAhead_Click);
            // 
            // tcFilename
            // 
            this.tcFilename.Header = "Filename";
            this.tcFilename.SortOrder = System.Windows.Forms.SortOrder.None;
            this.tcFilename.TooltipText = null;
            this.tcFilename.Width = 100;
            // 
            // tcNumber
            // 
            this.tcNumber.Header = "#";
            this.tcNumber.SortOrder = System.Windows.Forms.SortOrder.None;
            this.tcNumber.TooltipText = null;
            // 
            // tcTitle
            // 
            this.tcTitle.Header = "Title";
            this.tcTitle.SortOrder = System.Windows.Forms.SortOrder.None;
            this.tcTitle.TooltipText = null;
            // 
            // tcArtist
            // 
            this.tcArtist.Header = "Artist";
            this.tcArtist.SortOrder = System.Windows.Forms.SortOrder.None;
            this.tcArtist.TooltipText = null;
            // 
            // tcAlbum
            // 
            this.tcAlbum.Header = "Album";
            this.tcAlbum.SortOrder = System.Windows.Forms.SortOrder.None;
            this.tcAlbum.TooltipText = null;
            // 
            // nodeIcon1
            // 
            this.nodeIcon1.DataPropertyName = "Image";
            this.nodeIcon1.LeftMargin = 1;
            this.nodeIcon1.ParentColumn = this.tcFilename;
            this.nodeIcon1.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Clip;
            // 
            // ntbFile
            // 
            this.ntbFile.DataPropertyName = "Text";
            this.ntbFile.IncrementalSearchEnabled = true;
            this.ntbFile.LeftMargin = 3;
            this.ntbFile.ParentColumn = this.tcFilename;
            // 
            // ntbNumber
            // 
            this.ntbNumber.DataPropertyName = "Tracknumber";
            this.ntbNumber.IncrementalSearchEnabled = true;
            this.ntbNumber.LeftMargin = 3;
            this.ntbNumber.ParentColumn = this.tcNumber;
            // 
            // ntbTitle
            // 
            this.ntbTitle.DataPropertyName = "Title";
            this.ntbTitle.IncrementalSearchEnabled = true;
            this.ntbTitle.LeftMargin = 3;
            this.ntbTitle.ParentColumn = this.tcTitle;
            // 
            // ntbArtist
            // 
            this.ntbArtist.DataPropertyName = "Artist";
            this.ntbArtist.IncrementalSearchEnabled = true;
            this.ntbArtist.LeftMargin = 3;
            this.ntbArtist.ParentColumn = this.tcArtist;
            // 
            // ntbAlbum
            // 
            this.ntbAlbum.DataPropertyName = "Album";
            this.ntbAlbum.IncrementalSearchEnabled = true;
            this.ntbAlbum.LeftMargin = 3;
            this.ntbAlbum.ParentColumn = this.tcAlbum;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.saveTagsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // saveTagsToolStripMenuItem
            // 
            this.saveTagsToolStripMenuItem.Name = "saveTagsToolStripMenuItem";
            this.saveTagsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTagsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveTagsToolStripMenuItem.Text = "Save Tags";
            this.saveTagsToolStripMenuItem.Visible = false;
            this.saveTagsToolStripMenuItem.Click += new System.EventHandler(this.saveTagsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdateToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // scTopBottom
            // 
            this.scTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTopBottom.Location = new System.Drawing.Point(0, 24);
            this.scTopBottom.Name = "scTopBottom";
            this.scTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scTopBottom.Panel1
            // 
            this.scTopBottom.Panel1.Controls.Add(this.scMain);
            // 
            // scTopBottom.Panel2
            // 
            this.scTopBottom.Panel2.Controls.Add(this.srtfLog);
            this.scTopBottom.Size = new System.Drawing.Size(1278, 519);
            this.scTopBottom.SplitterDistance = 457;
            this.scTopBottom.TabIndex = 8;
            this.scTopBottom.TabStop = false;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(134, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(301, 25);
            this.miniToolStrip.TabIndex = 10;
            // 
            // tsbLastThirty
            // 
            this.tsbLastThirty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLastThirty.Image = ((System.Drawing.Image)(resources.GetObject("tsbLastThirty.Image")));
            this.tsbLastThirty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLastThirty.Name = "tsbLastThirty";
            this.tsbLastThirty.Size = new System.Drawing.Size(23, 22);
            this.tsbLastThirty.Text = "Skip to Last 30 Seconds";
            this.tsbLastThirty.Click += new System.EventHandler(this.tsbLastThirty_Click);
            // 
            // txtOverallDate
            // 
            this.txtOverallDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverallDate.Location = new System.Drawing.Point(75, 66);
            this.txtOverallDate.Name = "txtOverallDate";
            this.txtOverallDate.Size = new System.Drawing.Size(242, 20);
            this.txtOverallDate.TabIndex = 260;
            // 
            // txtOverallArtist
            // 
            this.txtOverallArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverallArtist.Location = new System.Drawing.Point(75, 20);
            this.txtOverallArtist.Name = "txtOverallArtist";
            this.txtOverallArtist.Size = new System.Drawing.Size(242, 20);
            this.txtOverallArtist.TabIndex = 220;
            // 
            // txtOverallComment
            // 
            this.txtOverallComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverallComment.Location = new System.Drawing.Point(75, 89);
            this.txtOverallComment.Name = "txtOverallComment";
            this.txtOverallComment.Size = new System.Drawing.Size(242, 20);
            this.txtOverallComment.TabIndex = 280;
            // 
            // txtOverallAlbum
            // 
            this.txtOverallAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverallAlbum.Location = new System.Drawing.Point(75, 43);
            this.txtOverallAlbum.Name = "txtOverallAlbum";
            this.txtOverallAlbum.Size = new System.Drawing.Size(242, 20);
            this.txtOverallAlbum.TabIndex = 240;
            // 
            // txtMetadataComment
            // 
            this.txtMetadataComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetadataComment.Location = new System.Drawing.Point(75, 136);
            this.txtMetadataComment.Name = "txtMetadataComment";
            this.txtMetadataComment.Size = new System.Drawing.Size(261, 20);
            this.txtMetadataComment.TabIndex = 200;
            // 
            // txtMetadataDate
            // 
            this.txtMetadataDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetadataDate.Location = new System.Drawing.Point(75, 112);
            this.txtMetadataDate.Name = "txtMetadataDate";
            this.txtMetadataDate.Size = new System.Drawing.Size(261, 20);
            this.txtMetadataDate.TabIndex = 180;
            // 
            // txtMetadataTitle
            // 
            this.txtMetadataTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetadataTitle.Location = new System.Drawing.Point(75, 20);
            this.txtMetadataTitle.Name = "txtMetadataTitle";
            this.txtMetadataTitle.Size = new System.Drawing.Size(261, 20);
            this.txtMetadataTitle.TabIndex = 100;
            // 
            // txtMetadataAlbum
            // 
            this.txtMetadataAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetadataAlbum.Location = new System.Drawing.Point(75, 89);
            this.txtMetadataAlbum.Name = "txtMetadataAlbum";
            this.txtMetadataAlbum.Size = new System.Drawing.Size(261, 20);
            this.txtMetadataAlbum.TabIndex = 160;
            // 
            // txtMetadataTrackNumber
            // 
            this.txtMetadataTrackNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetadataTrackNumber.Location = new System.Drawing.Point(75, 43);
            this.txtMetadataTrackNumber.Name = "txtMetadataTrackNumber";
            this.txtMetadataTrackNumber.Size = new System.Drawing.Size(261, 20);
            this.txtMetadataTrackNumber.TabIndex = 120;
            // 
            // txtMetadataArtist
            // 
            this.txtMetadataArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetadataArtist.Location = new System.Drawing.Point(75, 66);
            this.txtMetadataArtist.Name = "txtMetadataArtist";
            this.txtMetadataArtist.Size = new System.Drawing.Size(261, 20);
            this.txtMetadataArtist.TabIndex = 140;
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFile.Location = new System.Drawing.Point(8, 14);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(336, 16);
            this.lblCurrentFile.TabIndex = 42;
            this.lblCurrentFile.Tag = "info";
            this.lblCurrentFile.Text = "lblCurrentFile";
            this.lblCurrentFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEncoder
            // 
            this.lblEncoder.AutoSize = true;
            this.lblEncoder.Location = new System.Drawing.Point(96, 32);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(57, 13);
            this.lblEncoder.TabIndex = 36;
            this.lblEncoder.Tag = "info";
            this.lblEncoder.Text = "lblEncoder";
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(256, 64);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(57, 13);
            this.lblDuration.TabIndex = 37;
            this.lblDuration.Tag = "info";
            this.lblDuration.Text = "lblDuration";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(256, 48);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(37, 13);
            this.lblSize.TabIndex = 38;
            this.lblSize.Tag = "info";
            this.lblSize.Text = "lblSize";
            // 
            // lblChannels
            // 
            this.lblChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChannels.AutoSize = true;
            this.lblChannels.Location = new System.Drawing.Point(256, 32);
            this.lblChannels.Name = "lblChannels";
            this.lblChannels.Size = new System.Drawing.Size(61, 13);
            this.lblChannels.TabIndex = 39;
            this.lblChannels.Tag = "info";
            this.lblChannels.Text = "lblChannels";
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(96, 64);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(75, 13);
            this.lblSampleRate.TabIndex = 40;
            this.lblSampleRate.Tag = "info";
            this.lblSampleRate.Text = "lblSampleRate";
            // 
            // lblBitrate
            // 
            this.lblBitrate.AutoSize = true;
            this.lblBitrate.Location = new System.Drawing.Point(96, 48);
            this.lblBitrate.Name = "lblBitrate";
            this.lblBitrate.Size = new System.Drawing.Size(47, 13);
            this.lblBitrate.TabIndex = 41;
            this.lblBitrate.Tag = "info";
            this.lblBitrate.Text = "lblBitrate";
            // 
            // srtfLog
            // 
            this.srtfLog.BackColor = System.Drawing.Color.Black;
            this.srtfLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srtfLog.Location = new System.Drawing.Point(0, 0);
            this.srtfLog.Name = "srtfLog";
            this.srtfLog.Size = new System.Drawing.Size(1278, 58);
            this.srtfLog.TabIndex = 53;
            this.srtfLog.TabStop = false;
            this.srtfLog.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 543);
            this.Controls.Add(this.scTopBottom);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "TagBot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCommonTags.ResumeLayout(false);
            this.grpCommonTags.PerformLayout();
            this.grpFileTags.ResumeLayout(false);
            this.grpFileTags.PerformLayout();
            this.grpFIleInfo.ResumeLayout(false);
            this.grpFIleInfo.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scFileTagFlac.Panel1.ResumeLayout(false);
            this.scFileTagFlac.Panel2.ResumeLayout(false);
            this.scFileTagFlac.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scFileTagFlac)).EndInit();
            this.scFileTagFlac.ResumeLayout(false);
            this.pnlFileView.ResumeLayout(false);
            this.pnlDirectoryBrowserToolbar.ResumeLayout(false);
            this.pnlDirectoryBrowserToolbar.PerformLayout();
            this.tsDirectoryBrowser.ResumeLayout(false);
            this.tsDirectoryBrowser.PerformLayout();
            this.pnlShowSearch.ResumeLayout(false);
            this.pnlShowSearch.PerformLayout();
            this.scFlacText.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFlacText)).EndInit();
            this.scFlacText.ResumeLayout(false);
            this.tsAudioBrowser.ResumeLayout(false);
            this.tsAudioBrowser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scTopBottom.Panel1.ResumeLayout(false);
            this.scTopBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTopBottom)).EndInit();
            this.scTopBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ImageList imgListFileIcons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDate;
        private TextboxToolTip txtMetadataDate;
        private System.Windows.Forms.Label label11;
        private TextboxToolTip txtMetadataTrackNumber;
        private System.Windows.Forms.Label label10;
        private TextboxToolTip txtMetadataAlbum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnMatch;
        private TextboxToolTip txtMetadataArtist;
        private System.Windows.Forms.Label label8;
        private TextboxToolTip txtMetadataTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFileView;
        private System.Windows.Forms.SplitContainer scFileTagFlac;
        private System.Windows.Forms.SplitContainer scFlacText;
        private System.Windows.Forms.ToolStrip tsAudioBrowser;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Panel pnlTagView;
        private System.Windows.Forms.Button btnLoadDatabase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLoadedDatabase;
        private ScrollingRichTextBox srtfLog;
        private System.Windows.Forms.SplitContainer scTopBottom;
        private System.Windows.Forms.Panel pnlShowSearch;
        private System.Windows.Forms.Button btnDbInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Aga.Controls.Tree.TreeColumn tcFilename;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Aga.Controls.Tree.TreeColumn tcNumber;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntbFile;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeIcon1;
        private Aga.Controls.Tree.TreeColumn tcTitle;
        private Aga.Controls.Tree.TreeColumn tcArtist;
        private Aga.Controls.Tree.TreeColumn tcAlbum;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntbNumber;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntbTitle;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntbArtist;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntbAlbum;
        private System.Windows.Forms.Panel pnlTvMatchFiles;
        private System.Windows.Forms.Panel pnlDirectoryBrowserToolbar;
        private System.Windows.Forms.ToolStrip tsDirectoryBrowser;
        private System.Windows.Forms.ToolStripButton tsbSelectDirectory;
        private System.Windows.Forms.ToolStripTextBox tstbLocation;
        private System.Windows.Forms.TreeView tvDirectories;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.GroupBox grpFIleInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private LabelToolTip lblEncoder;
        private LabelToolTip lblDuration;
        private LabelToolTip lblSize;
        private LabelToolTip lblChannels;
        private LabelToolTip lblSampleRate;
        private LabelToolTip lblBitrate;
        private System.Windows.Forms.GroupBox grpCommonTags;
        private System.Windows.Forms.Label label14;
        private TextboxToolTip txtOverallComment;
        private System.Windows.Forms.Label label15;
        private TextboxToolTip txtOverallDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private TextboxToolTip txtOverallArtist;
        private TextboxToolTip txtOverallAlbum;
        private System.Windows.Forms.GroupBox grpFileTags;
        private System.Windows.Forms.Label label18;
        private TextboxToolTip txtMetadataComment;
        private LabelToolTip lblCurrentFile;
        private System.Windows.Forms.Button btnAutoFillCommonTags;
        private System.Windows.Forms.ToolStripLabel tslMatchFilesCount;
        private System.Windows.Forms.ToolStripMenuItem saveTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Button btnAutofillComment;
        private System.Windows.Forms.Button btnAutofillDate;
        private System.Windows.Forms.Button btnAutofillAlbum;
        private System.Windows.Forms.Button btnAutofillArtist;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbSeekAhead;
        private System.Windows.Forms.ToolStripButton tsbSeekBack;
        private System.Windows.Forms.ToolStripButton tsbLastThirty;
    }
}

