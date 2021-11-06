
namespace TagBot.App
{
    partial class ucMatchFiles
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
            this.tvMatchFiles = new Aga.Controls.Tree.TreeViewAdv();
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
            this.SuspendLayout();
            // 
            // tvMatchFiles
            // 
            this.tvMatchFiles.BackColor = System.Drawing.SystemColors.Window;
            this.tvMatchFiles.Columns.Add(this.tcFilename);
            this.tvMatchFiles.Columns.Add(this.tcNumber);
            this.tvMatchFiles.Columns.Add(this.tcTitle);
            this.tvMatchFiles.Columns.Add(this.tcArtist);
            this.tvMatchFiles.Columns.Add(this.tcAlbum);
            this.tvMatchFiles.DefaultToolTipProvider = null;
            this.tvMatchFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMatchFiles.DragDropMarkColor = System.Drawing.Color.Black;
            this.tvMatchFiles.LineColor = System.Drawing.SystemColors.ControlDark;
            this.tvMatchFiles.Location = new System.Drawing.Point(0, 0);
            this.tvMatchFiles.Model = null;
            this.tvMatchFiles.Name = "tvMatchFiles";
            this.tvMatchFiles.NodeControls.Add(this.nodeIcon1);
            this.tvMatchFiles.NodeControls.Add(this.ntbFile);
            this.tvMatchFiles.NodeControls.Add(this.ntbNumber);
            this.tvMatchFiles.NodeControls.Add(this.ntbTitle);
            this.tvMatchFiles.NodeControls.Add(this.ntbArtist);
            this.tvMatchFiles.NodeControls.Add(this.ntbAlbum);
            this.tvMatchFiles.SelectedNode = null;
            this.tvMatchFiles.Size = new System.Drawing.Size(948, 450);
            this.tvMatchFiles.TabIndex = 8;
            this.tvMatchFiles.Text = "treeViewAdv1";
            this.tvMatchFiles.UseColumns = true;
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
            // ucMatchFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvMatchFiles);
            this.Name = "ucMatchFiles";
            this.Size = new System.Drawing.Size(948, 450);
            this.Load += new System.EventHandler(this.ucMatchFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv tvMatchFiles;
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
    }
}