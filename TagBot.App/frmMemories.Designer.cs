
namespace TagBot.App
{
    partial class frmMemories
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
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.lblSetlist = new System.Windows.Forms.Label();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.gbTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbBackground.Location = new System.Drawing.Point(176, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(624, 497);
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.lblSetlist);
            this.gbTools.Location = new System.Drawing.Point(0, 0);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(168, 440);
            this.gbTools.TabIndex = 1;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Toolbox";
            // 
            // lblSetlist
            // 
            this.lblSetlist.AutoSize = true;
            this.lblSetlist.Location = new System.Drawing.Point(8, 24);
            this.lblSetlist.Name = "lblSetlist";
            this.lblSetlist.Size = new System.Drawing.Size(35, 13);
            this.lblSetlist.TabIndex = 2;
            this.lblSetlist.Text = "Setlist";
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(96, 472);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 23);
            this.btnRender.TabIndex = 2;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(8, 440);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // frmMemories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.pbBackground);
            this.Name = "frmMemories";
            this.Text = "frmMemories";
            this.Load += new System.EventHandler(this.frmMemories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Label lblSetlist;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnAnalyze;
    }
}