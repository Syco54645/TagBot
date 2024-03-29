﻿
namespace TagBot.App
{
    partial class frmPreferences
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "dmb",
            "dm",
            "d&ttt"}, -1);
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAlbumFormatter = new System.Windows.Forms.TextBox();
            this.grpAlbumFormatter = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtfAlbumFormatterGuide = new System.Windows.Forms.RichTextBox();
            this.lblAlbumFormatterDemo = new TagBot.App.LabelToolTip();
            this.txtCustomDateFormatter = new System.Windows.Forms.TextBox();
            this.grpCustomDate = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDateFormatterDemo = new TagBot.App.LabelToolTip();
            this.grpTitleFormatter = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtfTitleFormatterGuide = new System.Windows.Forms.RichTextBox();
            this.lblTitleModifierFormatterDemo = new TagBot.App.LabelToolTip();
            this.lblTitleFormatterDemo = new TagBot.App.LabelToolTip();
            this.txtTitleFormatter = new System.Windows.Forms.TextBox();
            this.flpFormatters = new System.Windows.Forms.FlowLayoutPanel();
            this.grpArtistTransformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvArtists = new System.Windows.Forms.ListView();
            this.txtArtistTransformation = new System.Windows.Forms.TextBox();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.tabPreferences = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMp3 = new System.Windows.Forms.GroupBox();
            this.chkMp3ModeEnabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpExperimental = new System.Windows.Forms.GroupBox();
            this.chkParallelSavingEnabled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDisableConfirmation = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAlbumFormatter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpCustomDate.SuspendLayout();
            this.grpTitleFormatter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flpFormatters.SuspendLayout();
            this.grpArtistTransformation.SuspendLayout();
            this.tabPreferences.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flpSettings.SuspendLayout();
            this.grpMp3.SuspendLayout();
            this.grpExperimental.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(187, 472);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 120;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(272, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 140;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAlbumFormatter
            // 
            this.txtAlbumFormatter.Location = new System.Drawing.Point(8, 24);
            this.txtAlbumFormatter.Name = "txtAlbumFormatter";
            this.txtAlbumFormatter.Size = new System.Drawing.Size(304, 20);
            this.txtAlbumFormatter.TabIndex = 40;
            this.txtAlbumFormatter.TextChanged += new System.EventHandler(this.txtAlbumFormatter_TextChanged);
            // 
            // grpAlbumFormatter
            // 
            this.grpAlbumFormatter.Controls.Add(this.groupBox2);
            this.grpAlbumFormatter.Controls.Add(this.lblAlbumFormatterDemo);
            this.grpAlbumFormatter.Controls.Add(this.txtAlbumFormatter);
            this.grpAlbumFormatter.Location = new System.Drawing.Point(3, 109);
            this.grpAlbumFormatter.Name = "grpAlbumFormatter";
            this.grpAlbumFormatter.Size = new System.Drawing.Size(317, 152);
            this.grpAlbumFormatter.TabIndex = 4;
            this.grpAlbumFormatter.TabStop = false;
            this.grpAlbumFormatter.Text = "Album Formatter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtfAlbumFormatterGuide);
            this.groupBox2.Location = new System.Drawing.Point(8, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template Vars";
            // 
            // rtfAlbumFormatterGuide
            // 
            this.rtfAlbumFormatterGuide.BackColor = System.Drawing.SystemColors.Control;
            this.rtfAlbumFormatterGuide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfAlbumFormatterGuide.Location = new System.Drawing.Point(8, 16);
            this.rtfAlbumFormatterGuide.Name = "rtfAlbumFormatterGuide";
            this.rtfAlbumFormatterGuide.ReadOnly = true;
            this.rtfAlbumFormatterGuide.Size = new System.Drawing.Size(288, 56);
            this.rtfAlbumFormatterGuide.TabIndex = 8;
            this.rtfAlbumFormatterGuide.TabStop = false;
            this.rtfAlbumFormatterGuide.Text = "%d - Format date in custom date format\n%v - Venue\n%c - City\n%s - State\n%a - Short" +
    " Artist Name\n%A - Full Artist Name";
            // 
            // lblAlbumFormatterDemo
            // 
            this.lblAlbumFormatterDemo.AutoSize = true;
            this.lblAlbumFormatterDemo.Location = new System.Drawing.Point(8, 48);
            this.lblAlbumFormatterDemo.Name = "lblAlbumFormatterDemo";
            this.lblAlbumFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblAlbumFormatterDemo.TabIndex = 6;
            this.lblAlbumFormatterDemo.Text = "label1";
            // 
            // txtCustomDateFormatter
            // 
            this.txtCustomDateFormatter.Location = new System.Drawing.Point(8, 24);
            this.txtCustomDateFormatter.Name = "txtCustomDateFormatter";
            this.txtCustomDateFormatter.Size = new System.Drawing.Size(304, 20);
            this.txtCustomDateFormatter.TabIndex = 20;
            this.txtCustomDateFormatter.TextChanged += new System.EventHandler(this.txtCustomDateFormatter_TextChanged);
            // 
            // grpCustomDate
            // 
            this.grpCustomDate.Controls.Add(this.linkLabel1);
            this.grpCustomDate.Controls.Add(this.lblDateFormatterDemo);
            this.grpCustomDate.Controls.Add(this.txtCustomDateFormatter);
            this.grpCustomDate.Location = new System.Drawing.Point(3, 3);
            this.grpCustomDate.Name = "grpCustomDate";
            this.grpCustomDate.Size = new System.Drawing.Size(317, 100);
            this.grpCustomDate.TabIndex = 6;
            this.grpCustomDate.TabStop = false;
            this.grpCustomDate.Text = "Custom Date Format";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(20, 61);
            this.linkLabel1.Location = new System.Drawing.Point(8, 72);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(268, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Formatted using the C# date and time format strings.";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblDateFormatterDemo
            // 
            this.lblDateFormatterDemo.AutoSize = true;
            this.lblDateFormatterDemo.Location = new System.Drawing.Point(8, 48);
            this.lblDateFormatterDemo.Name = "lblDateFormatterDemo";
            this.lblDateFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblDateFormatterDemo.TabIndex = 7;
            this.lblDateFormatterDemo.Text = "label1";
            // 
            // grpTitleFormatter
            // 
            this.grpTitleFormatter.Controls.Add(this.groupBox1);
            this.grpTitleFormatter.Controls.Add(this.lblTitleModifierFormatterDemo);
            this.grpTitleFormatter.Controls.Add(this.lblTitleFormatterDemo);
            this.grpTitleFormatter.Controls.Add(this.txtTitleFormatter);
            this.grpTitleFormatter.Location = new System.Drawing.Point(3, 267);
            this.grpTitleFormatter.Name = "grpTitleFormatter";
            this.grpTitleFormatter.Size = new System.Drawing.Size(317, 160);
            this.grpTitleFormatter.TabIndex = 7;
            this.grpTitleFormatter.TabStop = false;
            this.grpTitleFormatter.Text = "Title Formatter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtfTitleFormatterGuide);
            this.groupBox1.Location = new System.Drawing.Point(8, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template Vars";
            // 
            // rtfTitleFormatterGuide
            // 
            this.rtfTitleFormatterGuide.BackColor = System.Drawing.SystemColors.Control;
            this.rtfTitleFormatterGuide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfTitleFormatterGuide.Location = new System.Drawing.Point(8, 16);
            this.rtfTitleFormatterGuide.Name = "rtfTitleFormatterGuide";
            this.rtfTitleFormatterGuide.ReadOnly = true;
            this.rtfTitleFormatterGuide.Size = new System.Drawing.Size(288, 48);
            this.rtfTitleFormatterGuide.TabIndex = 8;
            this.rtfTitleFormatterGuide.TabStop = false;
            this.rtfTitleFormatterGuide.Text = "%t - Title\n%r - Title with article at the end\n%m - Modifier";
            // 
            // lblTitleModifierFormatterDemo
            // 
            this.lblTitleModifierFormatterDemo.AutoSize = true;
            this.lblTitleModifierFormatterDemo.Location = new System.Drawing.Point(8, 64);
            this.lblTitleModifierFormatterDemo.Name = "lblTitleModifierFormatterDemo";
            this.lblTitleModifierFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblTitleModifierFormatterDemo.TabIndex = 7;
            this.lblTitleModifierFormatterDemo.Text = "label1";
            // 
            // lblTitleFormatterDemo
            // 
            this.lblTitleFormatterDemo.AutoSize = true;
            this.lblTitleFormatterDemo.Location = new System.Drawing.Point(8, 48);
            this.lblTitleFormatterDemo.Name = "lblTitleFormatterDemo";
            this.lblTitleFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblTitleFormatterDemo.TabIndex = 6;
            this.lblTitleFormatterDemo.Text = "label1";
            // 
            // txtTitleFormatter
            // 
            this.txtTitleFormatter.Location = new System.Drawing.Point(8, 24);
            this.txtTitleFormatter.Name = "txtTitleFormatter";
            this.txtTitleFormatter.Size = new System.Drawing.Size(304, 20);
            this.txtTitleFormatter.TabIndex = 60;
            this.txtTitleFormatter.TextChanged += new System.EventHandler(this.txtTitleFormatter_TextChanged);
            // 
            // flpFormatters
            // 
            this.flpFormatters.AutoScroll = true;
            this.flpFormatters.Controls.Add(this.grpCustomDate);
            this.flpFormatters.Controls.Add(this.grpAlbumFormatter);
            this.flpFormatters.Controls.Add(this.grpTitleFormatter);
            this.flpFormatters.Controls.Add(this.grpArtistTransformation);
            this.flpFormatters.Location = new System.Drawing.Point(0, 0);
            this.flpFormatters.Name = "flpFormatters";
            this.flpFormatters.Size = new System.Drawing.Size(344, 440);
            this.flpFormatters.TabIndex = 8;
            // 
            // grpArtistTransformation
            // 
            this.grpArtistTransformation.Controls.Add(this.label1);
            this.grpArtistTransformation.Controls.Add(this.lvArtists);
            this.grpArtistTransformation.Controls.Add(this.txtArtistTransformation);
            this.grpArtistTransformation.Location = new System.Drawing.Point(3, 433);
            this.grpArtistTransformation.Name = "grpArtistTransformation";
            this.grpArtistTransformation.Size = new System.Drawing.Size(317, 158);
            this.grpArtistTransformation.TabIndex = 9;
            this.grpArtistTransformation.TabStop = false;
            this.grpArtistTransformation.Text = "Artist Transformation";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click on an artist abbreviation in the above list and enter what the full name sh" +
    "ould be in the text box.";
            // 
            // lvArtists
            // 
            this.lvArtists.HideSelection = false;
            this.lvArtists.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvArtists.Location = new System.Drawing.Point(8, 24);
            this.lvArtists.Name = "lvArtists";
            this.lvArtists.Size = new System.Drawing.Size(304, 56);
            this.lvArtists.TabIndex = 80;
            this.lvArtists.UseCompatibleStateImageBehavior = false;
            this.lvArtists.View = System.Windows.Forms.View.Details;
            this.lvArtists.SelectedIndexChanged += new System.EventHandler(this.lvArtists_SelectedIndexChanged);
            // 
            // txtArtistTransformation
            // 
            this.txtArtistTransformation.Location = new System.Drawing.Point(8, 88);
            this.txtArtistTransformation.Name = "txtArtistTransformation";
            this.txtArtistTransformation.Size = new System.Drawing.Size(304, 20);
            this.txtArtistTransformation.TabIndex = 100;
            this.txtArtistTransformation.TextChanged += new System.EventHandler(this.txtArtistTransformation_TextChanged);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Location = new System.Drawing.Point(5, 472);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(75, 23);
            this.btnResetSettings.TabIndex = 9;
            this.btnResetSettings.TabStop = false;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.tabPage1);
            this.tabPreferences.Controls.Add(this.tabPage2);
            this.tabPreferences.Location = new System.Drawing.Point(0, 0);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.SelectedIndex = 0;
            this.tabPreferences.Size = new System.Drawing.Size(352, 464);
            this.tabPreferences.TabIndex = 141;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpFormatters);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formatters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flpSettings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flpSettings
            // 
            this.flpSettings.AutoScroll = true;
            this.flpSettings.Controls.Add(this.grpMp3);
            this.flpSettings.Controls.Add(this.grpExperimental);
            this.flpSettings.Location = new System.Drawing.Point(0, 0);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(344, 440);
            this.flpSettings.TabIndex = 2;
            // 
            // grpMp3
            // 
            this.grpMp3.Controls.Add(this.chkMp3ModeEnabled);
            this.grpMp3.Controls.Add(this.label3);
            this.grpMp3.Location = new System.Drawing.Point(3, 3);
            this.grpMp3.Name = "grpMp3";
            this.grpMp3.Size = new System.Drawing.Size(333, 100);
            this.grpMp3.TabIndex = 1;
            this.grpMp3.TabStop = false;
            this.grpMp3.Text = "Mp3 Support";
            // 
            // chkMp3ModeEnabled
            // 
            this.chkMp3ModeEnabled.AutoSize = true;
            this.chkMp3ModeEnabled.Location = new System.Drawing.Point(8, 24);
            this.chkMp3ModeEnabled.Name = "chkMp3ModeEnabled";
            this.chkMp3ModeEnabled.Size = new System.Drawing.Size(113, 17);
            this.chkMp3ModeEnabled.TabIndex = 0;
            this.chkMp3ModeEnabled.Text = "Enable Mp3 Mode";
            this.chkMp3ModeEnabled.UseVisualStyleBackColor = true;
            this.chkMp3ModeEnabled.Click += new System.EventHandler(this.chkMp3ModeEnabled_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Since Mp3 is frowned upon in online trading communities the disclaimer must be ma" +
    "de that this is for personal use only and that you will not distribute the files" +
    ".\r\n";
            // 
            // grpExperimental
            // 
            this.grpExperimental.Controls.Add(this.chkDisableConfirmation);
            this.grpExperimental.Controls.Add(this.label4);
            this.grpExperimental.Controls.Add(this.chkParallelSavingEnabled);
            this.grpExperimental.Controls.Add(this.label2);
            this.grpExperimental.Location = new System.Drawing.Point(3, 109);
            this.grpExperimental.Name = "grpExperimental";
            this.grpExperimental.Size = new System.Drawing.Size(333, 182);
            this.grpExperimental.TabIndex = 5;
            this.grpExperimental.TabStop = false;
            this.grpExperimental.Text = "Experimental Features";
            // 
            // chkParallelSavingEnabled
            // 
            this.chkParallelSavingEnabled.AutoSize = true;
            this.chkParallelSavingEnabled.Location = new System.Drawing.Point(8, 24);
            this.chkParallelSavingEnabled.Name = "chkParallelSavingEnabled";
            this.chkParallelSavingEnabled.Size = new System.Drawing.Size(132, 17);
            this.chkParallelSavingEnabled.TabIndex = 0;
            this.chkParallelSavingEnabled.Text = "Enable Parallel Saving";
            this.chkParallelSavingEnabled.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "This should speed up saving quite a bit. It is experimental at this point so use " +
    "at your own risk (I have had no issues with it). Progress bar is broken in this " +
    "mode.";
            // 
            // chkDisableConfirmation
            // 
            this.chkDisableConfirmation.AutoSize = true;
            this.chkDisableConfirmation.Location = new System.Drawing.Point(8, 97);
            this.chkDisableConfirmation.Name = "chkDisableConfirmation";
            this.chkDisableConfirmation.Size = new System.Drawing.Size(159, 17);
            this.chkDisableConfirmation.TabIndex = 5;
            this.chkDisableConfirmation.Text = "Disable Confirmation Screen";
            this.chkDisableConfirmation.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Disable the confirmation screen. This will go straight to writing the tags, allow" +
    "ing you to save a click.";
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 502);
            this.Controls.Add(this.tabPreferences);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.grpAlbumFormatter.ResumeLayout(false);
            this.grpAlbumFormatter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpCustomDate.ResumeLayout(false);
            this.grpCustomDate.PerformLayout();
            this.grpTitleFormatter.ResumeLayout(false);
            this.grpTitleFormatter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flpFormatters.ResumeLayout(false);
            this.grpArtistTransformation.ResumeLayout(false);
            this.grpArtistTransformation.PerformLayout();
            this.tabPreferences.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flpSettings.ResumeLayout(false);
            this.grpMp3.ResumeLayout(false);
            this.grpMp3.PerformLayout();
            this.grpExperimental.ResumeLayout(false);
            this.grpExperimental.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAlbumFormatter;
        private System.Windows.Forms.GroupBox grpAlbumFormatter;
        private LabelToolTip lblAlbumFormatterDemo;
        private System.Windows.Forms.TextBox txtCustomDateFormatter;
        private System.Windows.Forms.GroupBox grpCustomDate;
        private LabelToolTip lblDateFormatterDemo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grpTitleFormatter;
        private LabelToolTip lblTitleFormatterDemo;
        private System.Windows.Forms.TextBox txtTitleFormatter;
        private LabelToolTip lblTitleModifierFormatterDemo;
        private System.Windows.Forms.RichTextBox rtfTitleFormatterGuide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtfAlbumFormatterGuide;
        private System.Windows.Forms.FlowLayoutPanel flpFormatters;
        private System.Windows.Forms.GroupBox grpArtistTransformation;
        private System.Windows.Forms.TextBox txtArtistTransformation;
        private System.Windows.Forms.ListView lvArtists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.TabControl tabPreferences;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkMp3ModeEnabled;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private System.Windows.Forms.GroupBox grpMp3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpExperimental;
        private System.Windows.Forms.CheckBox chkParallelSavingEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDisableConfirmation;
        private System.Windows.Forms.Label label4;
    }
}