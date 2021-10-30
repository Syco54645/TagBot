
namespace TagBot.App.usercontrols
{
    partial class ucTextFiles
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
            this.lvTextFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTextFiles
            // 
            this.lvTextFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvTextFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTextFiles.FullRowSelect = true;
            this.lvTextFiles.HideSelection = false;
            this.lvTextFiles.Location = new System.Drawing.Point(0, 0);
            this.lvTextFiles.MultiSelect = false;
            this.lvTextFiles.Name = "lvTextFiles";
            this.lvTextFiles.Size = new System.Drawing.Size(836, 150);
            this.lvTextFiles.TabIndex = 12;
            this.lvTextFiles.UseCompatibleStateImageBehavior = false;
            this.lvTextFiles.View = System.Windows.Forms.View.Details;
            this.lvTextFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTextFiles_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 300;
            // 
            // ucTextFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvTextFiles);
            this.Name = "ucTextFiles";
            this.Size = new System.Drawing.Size(836, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTextFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
