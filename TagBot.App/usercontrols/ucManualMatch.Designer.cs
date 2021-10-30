
namespace TagBot.App.usercontrols
{
    partial class ucManualMatch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scFileMatch = new System.Windows.Forms.SplitContainer();
            this.tvMatchFiles = new System.Windows.Forms.TreeView();
            this.lvMatchTags = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOverallDate = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOverallArtist = new System.Windows.Forms.TextBox();
            this.txtOverallAlbum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOriginalComment = new System.Windows.Forms.Label();
            this.lblOriginalDate = new System.Windows.Forms.Label();
            this.lblOriginalAlbum = new System.Windows.Forms.Label();
            this.lblOriginalArtist = new System.Windows.Forms.Label();
            this.lblOriginalTitle = new System.Windows.Forms.Label();
            this.lblOriginalNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scAudioText = new System.Windows.Forms.SplitContainer();
            this.pnlTextFiles = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scFileMatch)).BeginInit();
            this.scFileMatch.Panel1.SuspendLayout();
            this.scFileMatch.Panel2.SuspendLayout();
            this.scFileMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAudioText)).BeginInit();
            this.scAudioText.Panel1.SuspendLayout();
            this.scAudioText.Panel2.SuspendLayout();
            this.scAudioText.SuspendLayout();
            this.SuspendLayout();
            // 
            // scFileMatch
            // 
            this.scFileMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFileMatch.Location = new System.Drawing.Point(0, 0);
            this.scFileMatch.Name = "scFileMatch";
            // 
            // scFileMatch.Panel1
            // 
            this.scFileMatch.Panel1.Controls.Add(this.tvMatchFiles);
            // 
            // scFileMatch.Panel2
            // 
            this.scFileMatch.Panel2.Controls.Add(this.lvMatchTags);
            this.scFileMatch.Size = new System.Drawing.Size(785, 317);
            this.scFileMatch.SplitterDistance = 359;
            this.scFileMatch.TabIndex = 2;
            // 
            // tvMatchFiles
            // 
            this.tvMatchFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMatchFiles.Location = new System.Drawing.Point(0, 0);
            this.tvMatchFiles.Name = "tvMatchFiles";
            this.tvMatchFiles.Size = new System.Drawing.Size(359, 317);
            this.tvMatchFiles.TabIndex = 0;
            this.tvMatchFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvMatchFiles_ItemDrag);
            this.tvMatchFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMatchFiles_NodeMouseClick);
            this.tvMatchFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragDrop);
            this.tvMatchFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragEnter);
            this.tvMatchFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragOver);
            // 
            // lvMatchTags
            // 
            this.lvMatchTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvMatchTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMatchTags.HideSelection = false;
            this.lvMatchTags.Location = new System.Drawing.Point(0, 0);
            this.lvMatchTags.Name = "lvMatchTags";
            this.lvMatchTags.Size = new System.Drawing.Size(422, 317);
            this.lvMatchTags.TabIndex = 0;
            this.lvMatchTags.UseCompatibleStateImageBehavior = false;
            this.lvMatchTags.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvMatchTags_ItemDrag);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.label7);
            this.scMain.Panel1.Controls.Add(this.textBox1);
            this.scMain.Panel1.Controls.Add(this.label6);
            this.scMain.Panel1.Controls.Add(this.txtOverallDate);
            this.scMain.Panel1.Controls.Add(this.btnDone);
            this.scMain.Panel1.Controls.Add(this.label2);
            this.scMain.Panel1.Controls.Add(this.label1);
            this.scMain.Panel1.Controls.Add(this.txtOverallArtist);
            this.scMain.Panel1.Controls.Add(this.txtOverallAlbum);
            this.scMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scAudioText);
            this.scMain.Size = new System.Drawing.Size(1181, 426);
            this.scMain.SplitterDistance = 392;
            this.scMain.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Comment";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(88, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date";
            // 
            // txtOverallDate
            // 
            this.txtOverallDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverallDate.Location = new System.Drawing.Point(88, 48);
            this.txtOverallDate.Name = "txtOverallDate";
            this.txtOverallDate.Size = new System.Drawing.Size(296, 20);
            this.txtOverallDate.TabIndex = 14;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Location = new System.Drawing.Point(309, 104);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Artist";
            // 
            // txtOverallArtist
            // 
            this.txtOverallArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverallArtist.Location = new System.Drawing.Point(88, 0);
            this.txtOverallArtist.Name = "txtOverallArtist";
            this.txtOverallArtist.Size = new System.Drawing.Size(296, 20);
            this.txtOverallArtist.TabIndex = 10;
            // 
            // txtOverallAlbum
            // 
            this.txtOverallAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverallAlbum.Location = new System.Drawing.Point(88, 24);
            this.txtOverallAlbum.Name = "txtOverallAlbum";
            this.txtOverallAlbum.Size = new System.Drawing.Size(296, 20);
            this.txtOverallAlbum.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOriginalComment);
            this.groupBox1.Controls.Add(this.lblOriginalDate);
            this.groupBox1.Controls.Add(this.lblOriginalAlbum);
            this.groupBox1.Controls.Add(this.lblOriginalArtist);
            this.groupBox1.Controls.Add(this.lblOriginalTitle);
            this.groupBox1.Controls.Add(this.lblOriginalNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing Track Info";
            // 
            // lblOriginalComment
            // 
            this.lblOriginalComment.AutoSize = true;
            this.lblOriginalComment.Location = new System.Drawing.Point(80, 104);
            this.lblOriginalComment.Name = "lblOriginalComment";
            this.lblOriginalComment.Size = new System.Drawing.Size(51, 13);
            this.lblOriginalComment.TabIndex = 14;
            this.lblOriginalComment.Text = "Comment";
            // 
            // lblOriginalDate
            // 
            this.lblOriginalDate.AutoSize = true;
            this.lblOriginalDate.Location = new System.Drawing.Point(80, 88);
            this.lblOriginalDate.Name = "lblOriginalDate";
            this.lblOriginalDate.Size = new System.Drawing.Size(30, 13);
            this.lblOriginalDate.TabIndex = 10;
            this.lblOriginalDate.Text = "Date";
            // 
            // lblOriginalAlbum
            // 
            this.lblOriginalAlbum.AutoSize = true;
            this.lblOriginalAlbum.Location = new System.Drawing.Point(80, 72);
            this.lblOriginalAlbum.Name = "lblOriginalAlbum";
            this.lblOriginalAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblOriginalAlbum.TabIndex = 11;
            this.lblOriginalAlbum.Text = "Album";
            // 
            // lblOriginalArtist
            // 
            this.lblOriginalArtist.AutoSize = true;
            this.lblOriginalArtist.Location = new System.Drawing.Point(80, 56);
            this.lblOriginalArtist.Name = "lblOriginalArtist";
            this.lblOriginalArtist.Size = new System.Drawing.Size(30, 13);
            this.lblOriginalArtist.TabIndex = 12;
            this.lblOriginalArtist.Text = "Artist";
            // 
            // lblOriginalTitle
            // 
            this.lblOriginalTitle.AutoSize = true;
            this.lblOriginalTitle.Location = new System.Drawing.Point(80, 24);
            this.lblOriginalTitle.Name = "lblOriginalTitle";
            this.lblOriginalTitle.Size = new System.Drawing.Size(27, 13);
            this.lblOriginalTitle.TabIndex = 13;
            this.lblOriginalTitle.Text = "Title";
            // 
            // lblOriginalNumber
            // 
            this.lblOriginalNumber.AutoSize = true;
            this.lblOriginalNumber.Location = new System.Drawing.Point(80, 40);
            this.lblOriginalNumber.Name = "lblOriginalNumber";
            this.lblOriginalNumber.Size = new System.Drawing.Size(14, 13);
            this.lblOriginalNumber.TabIndex = 9;
            this.lblOriginalNumber.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comment:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Album:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Artist:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "#:";
            // 
            // scAudioText
            // 
            this.scAudioText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAudioText.Location = new System.Drawing.Point(0, 0);
            this.scAudioText.Name = "scAudioText";
            this.scAudioText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAudioText.Panel1
            // 
            this.scAudioText.Panel1.Controls.Add(this.scFileMatch);
            // 
            // scAudioText.Panel2
            // 
            this.scAudioText.Panel2.Controls.Add(this.pnlTextFiles);
            this.scAudioText.Size = new System.Drawing.Size(785, 426);
            this.scAudioText.SplitterDistance = 317;
            this.scAudioText.TabIndex = 3;
            // 
            // pnlTextFiles
            // 
            this.pnlTextFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextFiles.Location = new System.Drawing.Point(0, 0);
            this.pnlTextFiles.Name = "pnlTextFiles";
            this.pnlTextFiles.Size = new System.Drawing.Size(785, 105);
            this.pnlTextFiles.TabIndex = 0;
            // 
            // ucManualMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "ucManualMatch";
            this.Size = new System.Drawing.Size(1181, 426);
            this.Load += new System.EventHandler(this.manualMatch_Load);
            this.scFileMatch.Panel1.ResumeLayout(false);
            this.scFileMatch.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFileMatch)).EndInit();
            this.scFileMatch.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.scAudioText.Panel1.ResumeLayout(false);
            this.scAudioText.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scAudioText)).EndInit();
            this.scAudioText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scFileMatch;
        private System.Windows.Forms.TreeView tvMatchFiles;
        private System.Windows.Forms.ListView lvMatchTags;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOverallArtist;
        private System.Windows.Forms.TextBox txtOverallAlbum;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOverallDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOriginalComment;
        private System.Windows.Forms.Label lblOriginalDate;
        private System.Windows.Forms.Label lblOriginalAlbum;
        private System.Windows.Forms.Label lblOriginalArtist;
        private System.Windows.Forms.Label lblOriginalTitle;
        private System.Windows.Forms.Label lblOriginalNumber;
        private System.Windows.Forms.SplitContainer scAudioText;
        private System.Windows.Forms.Panel pnlTextFiles;
    }
}
