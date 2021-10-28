
namespace TagBot.App
{
    partial class frmMatch
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
            this.tvMatchFiles = new System.Windows.Forms.TreeView();
            this.lvMatchTags = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tvMatchFiles
            // 
            this.tvMatchFiles.Location = new System.Drawing.Point(0, 24);
            this.tvMatchFiles.Name = "tvMatchFiles";
            this.tvMatchFiles.Size = new System.Drawing.Size(384, 288);
            this.tvMatchFiles.TabIndex = 0;
            this.tvMatchFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvMatchFiles_ItemDrag);
            this.tvMatchFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragDrop);
            this.tvMatchFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragEnter);
            this.tvMatchFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragOver);
            // 
            // lvMatchTags
            // 
            this.lvMatchTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvMatchTags.HideSelection = false;
            this.lvMatchTags.Location = new System.Drawing.Point(422, 24);
            this.lvMatchTags.Name = "lvMatchTags";
            this.lvMatchTags.Size = new System.Drawing.Size(376, 288);
            this.lvMatchTags.TabIndex = 0;
            this.lvMatchTags.UseCompatibleStateImageBehavior = false;
            this.lvMatchTags.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvMatchTags_ItemDrag);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // frmMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvMatchTags);
            this.Controls.Add(this.tvMatchFiles);
            this.Name = "frmMatch";
            this.Text = "frmMatch";
            this.Load += new System.EventHandler(this.frmMatch_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.tvMatchFiles_DragOver);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvMatchFiles;
        private System.Windows.Forms.ListView lvMatchTags;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}