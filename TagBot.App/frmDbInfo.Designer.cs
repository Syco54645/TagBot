
namespace TagBot.App
{
    partial class frmDbInfo
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
            this.lblLoadedDatabaseVersion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLoadedDatabase = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblShowCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArtistCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSongCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLoadedDatabaseVersion
            // 
            this.lblLoadedDatabaseVersion.AutoSize = true;
            this.lblLoadedDatabaseVersion.Location = new System.Drawing.Point(104, 39);
            this.lblLoadedDatabaseVersion.Name = "lblLoadedDatabaseVersion";
            this.lblLoadedDatabaseVersion.Size = new System.Drawing.Size(98, 13);
            this.lblLoadedDatabaseVersion.TabIndex = 9;
            this.lblLoadedDatabaseVersion.Text = "lblDatabaseVersion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Supported Artists";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Schema Version";
            // 
            // txtLoadedDatabase
            // 
            this.txtLoadedDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoadedDatabase.Location = new System.Drawing.Point(104, 24);
            this.txtLoadedDatabase.Name = "txtLoadedDatabase";
            this.txtLoadedDatabase.ReadOnly = true;
            this.txtLoadedDatabase.Size = new System.Drawing.Size(224, 13);
            this.txtLoadedDatabase.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Database";
            // 
            // lblShowCount
            // 
            this.lblShowCount.AutoSize = true;
            this.lblShowCount.Location = new System.Drawing.Point(105, 54);
            this.lblShowCount.Name = "lblShowCount";
            this.lblShowCount.Size = new System.Drawing.Size(72, 13);
            this.lblShowCount.TabIndex = 14;
            this.lblShowCount.Text = "lblShowCount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shows";
            // 
            // lblArtistCount
            // 
            this.lblArtistCount.AutoSize = true;
            this.lblArtistCount.Location = new System.Drawing.Point(104, 84);
            this.lblArtistCount.Name = "lblArtistCount";
            this.lblArtistCount.Size = new System.Drawing.Size(68, 13);
            this.lblArtistCount.TabIndex = 16;
            this.lblArtistCount.Text = "lblArtistCount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Artists";
            // 
            // lblSongCount
            // 
            this.lblSongCount.AutoSize = true;
            this.lblSongCount.Location = new System.Drawing.Point(103, 69);
            this.lblSongCount.Name = "lblSongCount";
            this.lblSongCount.Size = new System.Drawing.Size(70, 13);
            this.lblSongCount.TabIndex = 18;
            this.lblSongCount.Text = "lblSongCount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Songs";
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(104, 99);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(224, 95);
            this.lbArtists.TabIndex = 19;
            // 
            // frmDbInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 233);
            this.Controls.Add(this.lbArtists);
            this.Controls.Add(this.lblSongCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArtistCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblShowCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoadedDatabase);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLoadedDatabaseVersion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDbInfo";
            this.Text = "frmDbInfo";
            this.Load += new System.EventHandler(this.frmDbInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoadedDatabaseVersion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLoadedDatabase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblShowCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArtistCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSongCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbArtists;
    }
}