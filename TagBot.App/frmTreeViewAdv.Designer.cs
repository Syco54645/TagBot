
namespace TagBot.App
{
    partial class frmTreeViewAdv
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
            this.tvDirectoriesAdv = new Aga.Controls.Tree.TreeViewAdv();
            this.lvMatchTags = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcFilename = new Aga.Controls.Tree.TreeColumn();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcNumber = new Aga.Controls.Tree.TreeColumn();
            this.ntbFile = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeIcon1 = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.tcTitle = new Aga.Controls.Tree.TreeColumn();
            this.tcArtist = new Aga.Controls.Tree.TreeColumn();
            this.tcAlbum = new Aga.Controls.Tree.TreeColumn();
            this.ntbNumber = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntbTitle = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntbArtist = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntbAlbum = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.SuspendLayout();
            // 
            // tvDirectoriesAdv
            // 
            this.tvDirectoriesAdv.BackColor = System.Drawing.SystemColors.Window;
            this.tvDirectoriesAdv.Columns.Add(this.tcFilename);
            this.tvDirectoriesAdv.Columns.Add(this.tcNumber);
            this.tvDirectoriesAdv.Columns.Add(this.tcTitle);
            this.tvDirectoriesAdv.Columns.Add(this.tcArtist);
            this.tvDirectoriesAdv.Columns.Add(this.tcAlbum);
            this.tvDirectoriesAdv.DefaultToolTipProvider = null;
            this.tvDirectoriesAdv.DragDropMarkColor = System.Drawing.Color.Black;
            this.tvDirectoriesAdv.LineColor = System.Drawing.SystemColors.ControlDark;
            this.tvDirectoriesAdv.Location = new System.Drawing.Point(432, 8);
            this.tvDirectoriesAdv.Model = null;
            this.tvDirectoriesAdv.Name = "tvDirectoriesAdv";
            this.tvDirectoriesAdv.NodeControls.Add(this.nodeIcon1);
            this.tvDirectoriesAdv.NodeControls.Add(this.ntbFile);
            this.tvDirectoriesAdv.NodeControls.Add(this.ntbNumber);
            this.tvDirectoriesAdv.NodeControls.Add(this.ntbTitle);
            this.tvDirectoriesAdv.NodeControls.Add(this.ntbArtist);
            this.tvDirectoriesAdv.NodeControls.Add(this.ntbAlbum);
            this.tvDirectoriesAdv.SelectedNode = null;
            this.tvDirectoriesAdv.Size = new System.Drawing.Size(512, 320);
            this.tvDirectoriesAdv.TabIndex = 8;
            this.tvDirectoriesAdv.Text = "treeViewAdv1";
            this.tvDirectoriesAdv.UseColumns = true;
            // 
            // lvMatchTags
            // 
            this.lvMatchTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvMatchTags.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMatchTags.HideSelection = false;
            this.lvMatchTags.Location = new System.Drawing.Point(8, 8);
            this.lvMatchTags.Name = "lvMatchTags";
            this.lvMatchTags.Size = new System.Drawing.Size(422, 317);
            this.lvMatchTags.TabIndex = 9;
            this.lvMatchTags.UseCompatibleStateImageBehavior = false;
            this.lvMatchTags.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
            // 
            // tcFilename
            // 
            this.tcFilename.Header = "Filename";
            this.tcFilename.SortOrder = System.Windows.Forms.SortOrder.None;
            this.tcFilename.TooltipText = null;
            this.tcFilename.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = global::TagBot.App.Properties.Settings.Default.databaseLocation;
            // 
            // tcNumber
            // 
            this.tcNumber.Header = "#";
            this.tcNumber.SortOrder = System.Windows.Forms.SortOrder.None;
            this.tcNumber.TooltipText = null;
            // 
            // ntbFile
            // 
            this.ntbFile.DataPropertyName = "Text";
            this.ntbFile.IncrementalSearchEnabled = true;
            this.ntbFile.LeftMargin = 3;
            this.ntbFile.ParentColumn = this.tcFilename;
            // 
            // nodeIcon1
            // 
            this.nodeIcon1.DataPropertyName = "Icon";
            this.nodeIcon1.LeftMargin = 1;
            this.nodeIcon1.ParentColumn = this.tcFilename;
            this.nodeIcon1.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Clip;
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
            // frmTreeViewAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.lvMatchTags);
            this.Controls.Add(this.tvDirectoriesAdv);
            this.Name = "frmTreeViewAdv";
            this.Text = "frmTreeViewAdv";
            this.Load += new System.EventHandler(this.frmTreeViewAdv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv tvDirectoriesAdv;
        private System.Windows.Forms.ListView lvMatchTags;
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
    }
}