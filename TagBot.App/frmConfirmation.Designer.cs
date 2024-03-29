﻿
namespace TagBot.App
{
    partial class frmConfirmation
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
            this.dgvChanges = new System.Windows.Forms.DataGridView();
            this.dgcFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOldVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcNewVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbTagProgress = new System.Windows.Forms.ProgressBar();
            this.chkDisableConfirmation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChanges
            // 
            this.dgvChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcFilename,
            this.dgcTagName,
            this.dgcOldVal,
            this.dgcNewVal});
            this.dgvChanges.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvChanges.Location = new System.Drawing.Point(0, 0);
            this.dgvChanges.Name = "dgvChanges";
            this.dgvChanges.ReadOnly = true;
            this.dgvChanges.Size = new System.Drawing.Size(800, 392);
            this.dgvChanges.TabIndex = 0;
            // 
            // dgcFilename
            // 
            this.dgcFilename.HeaderText = "File Name";
            this.dgcFilename.Name = "dgcFilename";
            this.dgcFilename.ReadOnly = true;
            // 
            // dgcTagName
            // 
            this.dgcTagName.HeaderText = "Tag";
            this.dgcTagName.Name = "dgcTagName";
            this.dgcTagName.ReadOnly = true;
            // 
            // dgcOldVal
            // 
            this.dgcOldVal.HeaderText = "Old Value";
            this.dgcOldVal.Name = "dgcOldVal";
            this.dgcOldVal.ReadOnly = true;
            // 
            // dgcNewVal
            // 
            this.dgcNewVal.HeaderText = "New Value";
            this.dgcNewVal.Name = "dgcNewVal";
            this.dgcNewVal.ReadOnly = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(720, 400);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(632, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbTagProgress
            // 
            this.pbTagProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbTagProgress.Location = new System.Drawing.Point(0, 424);
            this.pbTagProgress.Name = "pbTagProgress";
            this.pbTagProgress.Size = new System.Drawing.Size(800, 15);
            this.pbTagProgress.TabIndex = 29;
            // 
            // chkDisableConfirmation
            // 
            this.chkDisableConfirmation.AutoSize = true;
            this.chkDisableConfirmation.Location = new System.Drawing.Point(12, 404);
            this.chkDisableConfirmation.Name = "chkDisableConfirmation";
            this.chkDisableConfirmation.Size = new System.Drawing.Size(333, 17);
            this.chkDisableConfirmation.TabIndex = 30;
            this.chkDisableConfirmation.Text = "Disable Confirmation Screen (This can be undone in preferences)";
            this.chkDisableConfirmation.UseVisualStyleBackColor = true;
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.chkDisableConfirmation);
            this.Controls.Add(this.pbTagProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvChanges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirm Changes";
            this.Load += new System.EventHandler(this.frmConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOldVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNewVal;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ProgressBar pbTagProgress;
        private System.Windows.Forms.CheckBox chkDisableConfirmation;
    }
}