
namespace TagBot.App
{
    partial class frmMultipleShowsFound
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
            this.lvShows = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUseSelectedShow = new System.Windows.Forms.Button();
            this.rtbTracks = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvShows
            // 
            this.lvShows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvShows.FullRowSelect = true;
            this.lvShows.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvShows.HideSelection = false;
            this.lvShows.Location = new System.Drawing.Point(0, 0);
            this.lvShows.Name = "lvShows";
            this.lvShows.Size = new System.Drawing.Size(457, 232);
            this.lvShows.TabIndex = 0;
            this.lvShows.UseCompatibleStateImageBehavior = false;
            this.lvShows.View = System.Windows.Forms.View.Details;
            this.lvShows.SelectedIndexChanged += new System.EventHandler(this.lvShows_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Artist";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Venue";
            // 
            // btnUseSelectedShow
            // 
            this.btnUseSelectedShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseSelectedShow.Location = new System.Drawing.Point(712, 245);
            this.btnUseSelectedShow.Name = "btnUseSelectedShow";
            this.btnUseSelectedShow.Size = new System.Drawing.Size(75, 23);
            this.btnUseSelectedShow.TabIndex = 1;
            this.btnUseSelectedShow.Text = "Continue";
            this.btnUseSelectedShow.UseVisualStyleBackColor = true;
            this.btnUseSelectedShow.Click += new System.EventHandler(this.btnUseSelectedShow_Click);
            // 
            // rtbTracks
            // 
            this.rtbTracks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTracks.Location = new System.Drawing.Point(0, 0);
            this.rtbTracks.Name = "rtbTracks";
            this.rtbTracks.ReadOnly = true;
            this.rtbTracks.Size = new System.Drawing.Size(339, 232);
            this.rtbTracks.TabIndex = 2;
            this.rtbTracks.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvShows);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbTracks);
            this.splitContainer1.Size = new System.Drawing.Size(800, 232);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 3;
            // 
            // frmMultipleShowsFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnUseSelectedShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMultipleShowsFound";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Multiple Shows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMultipleShowsFound_FormClosing);
            this.Load += new System.EventHandler(this.frmMultipleShowsFound_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShows;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnUseSelectedShow;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RichTextBox rtbTracks;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}