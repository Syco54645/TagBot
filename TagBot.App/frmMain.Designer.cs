﻿
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
            this.rtfResult = new System.Windows.Forms.RichTextBox();
            this.imgListFileIcons = new System.Windows.Forms.ImageList(this.components);
            this.scOuter = new System.Windows.Forms.SplitContainer();
            this.tvDirectories = new System.Windows.Forms.TreeView();
            this.scNested = new System.Windows.Forms.SplitContainer();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.Name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.btnGetShowData = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMetadataDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMetadataTrackNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMetadataAlbum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMetadataArtist = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBitrate = new System.Windows.Forms.Label();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.lblChannels = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblEncoder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMetadataTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutomate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scOuter)).BeginInit();
            this.scOuter.Panel1.SuspendLayout();
            this.scOuter.Panel2.SuspendLayout();
            this.scOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scNested)).BeginInit();
            this.scNested.Panel1.SuspendLayout();
            this.scNested.Panel2.SuspendLayout();
            this.scNested.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfResult
            // 
            this.rtfResult.Location = new System.Drawing.Point(12, 38);
            this.rtfResult.Name = "rtfResult";
            this.rtfResult.Size = new System.Drawing.Size(389, 400);
            this.rtfResult.TabIndex = 2;
            this.rtfResult.Text = "";
            // 
            // imgListFileIcons
            // 
            this.imgListFileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListFileIcons.ImageStream")));
            this.imgListFileIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListFileIcons.Images.SetKeyName(0, "folder");
            this.imgListFileIcons.Images.SetKeyName(1, "audio");
            this.imgListFileIcons.Images.SetKeyName(2, "file");
            this.imgListFileIcons.Images.SetKeyName(3, "text");
            // 
            // scOuter
            // 
            this.scOuter.Location = new System.Drawing.Point(407, 38);
            this.scOuter.Name = "scOuter";
            // 
            // scOuter.Panel1
            // 
            this.scOuter.Panel1.Controls.Add(this.tvDirectories);
            // 
            // scOuter.Panel2
            // 
            this.scOuter.Panel2.Controls.Add(this.scNested);
            this.scOuter.Size = new System.Drawing.Size(736, 400);
            this.scOuter.SplitterDistance = 245;
            this.scOuter.TabIndex = 6;
            // 
            // tvDirectories
            // 
            this.tvDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDirectories.ImageIndex = 0;
            this.tvDirectories.ImageList = this.imgListFileIcons;
            this.tvDirectories.Location = new System.Drawing.Point(0, 0);
            this.tvDirectories.Name = "tvDirectories";
            this.tvDirectories.SelectedImageIndex = 0;
            this.tvDirectories.Size = new System.Drawing.Size(245, 400);
            this.tvDirectories.TabIndex = 4;
            // 
            // scNested
            // 
            this.scNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scNested.Location = new System.Drawing.Point(0, 0);
            this.scNested.Name = "scNested";
            // 
            // scNested.Panel1
            // 
            this.scNested.Panel1.Controls.Add(this.lvFiles);
            // 
            // scNested.Panel2
            // 
            this.scNested.Panel2.Controls.Add(this.btnAutomate);
            this.scNested.Panel2.Controls.Add(this.label12);
            this.scNested.Panel2.Controls.Add(this.btnGetShowData);
            this.scNested.Panel2.Controls.Add(this.txtDate);
            this.scNested.Panel2.Controls.Add(this.panel5);
            this.scNested.Panel2.Controls.Add(this.panel4);
            this.scNested.Panel2.Controls.Add(this.panel3);
            this.scNested.Panel2.Controls.Add(this.panel2);
            this.scNested.Panel2.Controls.Add(this.lblBitrate);
            this.scNested.Panel2.Controls.Add(this.lblSampleRate);
            this.scNested.Panel2.Controls.Add(this.lblChannels);
            this.scNested.Panel2.Controls.Add(this.lblSize);
            this.scNested.Panel2.Controls.Add(this.lblDuration);
            this.scNested.Panel2.Controls.Add(this.lblEncoder);
            this.scNested.Panel2.Controls.Add(this.label7);
            this.scNested.Panel2.Controls.Add(this.label6);
            this.scNested.Panel2.Controls.Add(this.label5);
            this.scNested.Panel2.Controls.Add(this.label4);
            this.scNested.Panel2.Controls.Add(this.label3);
            this.scNested.Panel2.Controls.Add(this.label2);
            this.scNested.Panel2.Controls.Add(this.panel1);
            this.scNested.Size = new System.Drawing.Size(487, 400);
            this.scNested.SplitterDistance = 162;
            this.scNested.TabIndex = 7;
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name1,
            this.Type,
            this.LastModified});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(0, 0);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(162, 400);
            this.lvFiles.SmallImageList = this.imgListFileIcons;
            this.lvFiles.TabIndex = 9;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.SelectedIndexChanged += new System.EventHandler(this.lvFiles_SelectedIndexChanged);
            // 
            // Name1
            // 
            this.Name1.Text = "Name";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // LastModified
            // 
            this.LastModified.Text = "LastModified";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Show Date";
            // 
            // btnGetShowData
            // 
            this.btnGetShowData.Location = new System.Drawing.Point(232, 12);
            this.btnGetShowData.Name = "btnGetShowData";
            this.btnGetShowData.Size = new System.Drawing.Size(75, 20);
            this.btnGetShowData.TabIndex = 25;
            this.btnGetShowData.Text = "Search";
            this.btnGetShowData.UseVisualStyleBackColor = true;
            this.btnGetShowData.Click += new System.EventHandler(this.btnGetShowData_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(72, 12);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(160, 20);
            this.txtDate.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMetadataDate);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(48, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 32);
            this.panel5.TabIndex = 23;
            // 
            // txtMetadataDate
            // 
            this.txtMetadataDate.Location = new System.Drawing.Point(40, 4);
            this.txtMetadataDate.Name = "txtMetadataDate";
            this.txtMetadataDate.Size = new System.Drawing.Size(183, 20);
            this.txtMetadataDate.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Date";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMetadataTrackNumber);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(48, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 32);
            this.panel4.TabIndex = 22;
            // 
            // txtMetadataTrackNumber
            // 
            this.txtMetadataTrackNumber.Location = new System.Drawing.Point(40, 4);
            this.txtMetadataTrackNumber.Name = "txtMetadataTrackNumber";
            this.txtMetadataTrackNumber.Size = new System.Drawing.Size(183, 20);
            this.txtMetadataTrackNumber.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Track Number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMetadataAlbum);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(48, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 32);
            this.panel3.TabIndex = 21;
            // 
            // txtMetadataAlbum
            // 
            this.txtMetadataAlbum.Location = new System.Drawing.Point(40, 4);
            this.txtMetadataAlbum.Name = "txtMetadataAlbum";
            this.txtMetadataAlbum.Size = new System.Drawing.Size(183, 20);
            this.txtMetadataAlbum.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Album";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMetadataArtist);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(48, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 32);
            this.panel2.TabIndex = 20;
            // 
            // txtMetadataArtist
            // 
            this.txtMetadataArtist.Location = new System.Drawing.Point(40, 4);
            this.txtMetadataArtist.Name = "txtMetadataArtist";
            this.txtMetadataArtist.Size = new System.Drawing.Size(183, 20);
            this.txtMetadataArtist.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Artist";
            // 
            // lblBitrate
            // 
            this.lblBitrate.AutoSize = true;
            this.lblBitrate.Location = new System.Drawing.Point(88, 64);
            this.lblBitrate.Name = "lblBitrate";
            this.lblBitrate.Size = new System.Drawing.Size(47, 13);
            this.lblBitrate.TabIndex = 19;
            this.lblBitrate.Text = "lblBitrate";
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(88, 80);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(75, 13);
            this.lblSampleRate.TabIndex = 18;
            this.lblSampleRate.Text = "lblSampleRate";
            // 
            // lblChannels
            // 
            this.lblChannels.AutoSize = true;
            this.lblChannels.Location = new System.Drawing.Point(248, 48);
            this.lblChannels.Name = "lblChannels";
            this.lblChannels.Size = new System.Drawing.Size(61, 13);
            this.lblChannels.TabIndex = 17;
            this.lblChannels.Text = "lblChannels";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(248, 64);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(37, 13);
            this.lblSize.TabIndex = 16;
            this.lblSize.Text = "lblSize";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(248, 80);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(57, 13);
            this.lblDuration.TabIndex = 15;
            this.lblDuration.Text = "lblDuration";
            // 
            // lblEncoder
            // 
            this.lblEncoder.AutoSize = true;
            this.lblEncoder.Location = new System.Drawing.Point(88, 48);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(57, 13);
            this.lblEncoder.TabIndex = 14;
            this.lblEncoder.Text = "lblEncoder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Channels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sample rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encoder";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMetadataTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(48, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 32);
            this.panel1.TabIndex = 7;
            // 
            // txtMetadataTitle
            // 
            this.txtMetadataTitle.Location = new System.Drawing.Point(40, 4);
            this.txtMetadataTitle.Name = "txtMetadataTitle";
            this.txtMetadataTitle.Size = new System.Drawing.Size(183, 20);
            this.txtMetadataTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // btnAutomate
            // 
            this.btnAutomate.Location = new System.Drawing.Point(56, 312);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(75, 23);
            this.btnAutomate.TabIndex = 27;
            this.btnAutomate.Text = "Automate";
            this.btnAutomate.UseVisualStyleBackColor = true;
            this.btnAutomate.Click += new System.EventHandler(this.btnAutomate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 589);
            this.Controls.Add(this.scOuter);
            this.Controls.Add(this.rtfResult);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.scOuter.Panel1.ResumeLayout(false);
            this.scOuter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOuter)).EndInit();
            this.scOuter.ResumeLayout(false);
            this.scNested.Panel1.ResumeLayout(false);
            this.scNested.Panel2.ResumeLayout(false);
            this.scNested.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scNested)).EndInit();
            this.scNested.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtfResult;
        private System.Windows.Forms.ImageList imgListFileIcons;
        private System.Windows.Forms.SplitContainer scOuter;
        private System.Windows.Forms.TreeView tvDirectories;
        private System.Windows.Forms.SplitContainer scNested;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader Name1;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader LastModified;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMetadataTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBitrate;
        private System.Windows.Forms.Label lblSampleRate;
        private System.Windows.Forms.Label lblChannels;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblEncoder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMetadataArtist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMetadataDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMetadataTrackNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMetadataAlbum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGetShowData;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAutomate;
    }
}

