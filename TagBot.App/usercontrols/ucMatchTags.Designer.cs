
namespace TagBot.App
{
    partial class ucMatchTags
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
            this.lvMatchTags = new System.Windows.Forms.ListView();
            this.btnMatchDone = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslTagCount = new System.Windows.Forms.ToolStripLabel();
            this.btnAutomate = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // lvMatchTags
            // 
            this.lvMatchTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMatchTags.HideSelection = false;
            this.lvMatchTags.Location = new System.Drawing.Point(0, 24);
            this.lvMatchTags.Name = "lvMatchTags";
            this.lvMatchTags.Size = new System.Drawing.Size(368, 359);
            this.lvMatchTags.TabIndex = 9;
            this.lvMatchTags.TabStop = false;
            this.lvMatchTags.UseCompatibleStateImageBehavior = false;
            // 
            // btnMatchDone
            // 
            this.btnMatchDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatchDone.Location = new System.Drawing.Point(293, 408);
            this.btnMatchDone.Name = "btnMatchDone";
            this.btnMatchDone.Size = new System.Drawing.Size(75, 23);
            this.btnMatchDone.TabIndex = 10;
            this.btnMatchDone.Text = "Done";
            this.btnMatchDone.UseVisualStyleBackColor = true;
            this.btnMatchDone.Click += new System.EventHandler(this.btnMatchDone_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTagCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(368, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslTagCount
            // 
            this.tslTagCount.Name = "tslTagCount";
            this.tslTagCount.Size = new System.Drawing.Size(42, 22);
            this.tslTagCount.Text = "Tags: 0";
            // 
            // btnAutomate
            // 
            this.btnAutomate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutomate.Location = new System.Drawing.Point(208, 408);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(75, 23);
            this.btnAutomate.TabIndex = 10;
            this.btnAutomate.Text = "Automate";
            this.btnAutomate.UseVisualStyleBackColor = true;
            this.btnAutomate.Click += new System.EventHandler(this.btnAutomate_Click);
            // 
            // ucMatchTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAutomate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMatchDone);
            this.Controls.Add(this.lvMatchTags);
            this.Name = "ucMatchTags";
            this.Size = new System.Drawing.Size(368, 440);
            this.Load += new System.EventHandler(this.ucMatchTags_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Aga.Controls.Tree.TreeColumn tcFilename;
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
        public System.Windows.Forms.ListView lvMatchTags;
        private System.Windows.Forms.Button btnMatchDone;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslTagCount;
        private System.Windows.Forms.Button btnAutomate;
    }
}