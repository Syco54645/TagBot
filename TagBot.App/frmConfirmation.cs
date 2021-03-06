using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagBot.App.Properties;
using TagBot.Service;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmConfirmation : Form
    {
        public frmMain frmMain;
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            pbTagProgress.Value = 0;
            dgvChanges.Rows.Clear();
            dgvChanges.Font = new Font(this.Font.FontFamily.Name, 8);
            
            foreach (var item in frmMain.proposedMetadata)
            {
                string filename = item.Key;
                Metadata proposedMetadata = item.Value.Metadata;
                Metadata originalMetadata = frmMain.originalMetadata[filename].Metadata;
                bool addedFilename = false;
                List<string> metadataKeys = new List<string>
                {
                    "Title",
                    "Album",
                    "Artist",
                    "Date",
                    "Tracknumber",
                    "Comment"
                };
                foreach (string mdk in metadataKeys)
                {
                    List<string> row = new List<string>();
                    string originalValue = "";
                    string proposedValue = "";
                    if (!string.IsNullOrEmpty((string)proposedMetadata[mdk]))
                    {
                        proposedValue = (string)proposedMetadata[mdk];
                    }
                    if (!string.IsNullOrEmpty((string)originalMetadata[mdk]))
                    {
                        originalValue = (string)originalMetadata[mdk];
                    }
                    if (false) { }
                    if (proposedValue.Trim() != originalValue.Trim())
                    {
                        if (!addedFilename)
                        {
                            row.Add(filename);
                            addedFilename = true;
                            dgvChanges.Rows.Add(row.ToArray());
                            row = new List<string>();
                        }
                        
                        row.Add(string.Empty);    
                        row.Add(mdk);
                        row.Add(originalValue);
                        row.Add(proposedValue);
                        if (row.Count > 0)
                        {
                            dgvChanges.Rows.Add(row.ToArray());
                        }
                        if (false) { }
                    }
                }
                if (false) { }
            }
            dgvChanges.AutoResizeColumns(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                pbTagProgress.Value = i;
                foreach (var item in frmMain.proposedMetadata)
                {
                    string filename = item.Key;
                    Metadata proposedMetadata = item.Value.Metadata;
                    string path = frmMain.currentPath + "\\" + filename;
                    FileInfo fileInfo = new FileInfo(filename);

                    if (fileInfo.Extension == ".flac")
                    {
                        Flac.writeTags(path, proposedMetadata);
                    }
                    else
                    {
                        if (Settings.Default.enableMp3)
                        {
                            Mp3.writeTags(path, proposedMetadata);
                        }
                        else
                        {
                            frmMain.log.AddErrorToRtf("Not sure how you got here because mp3 isn't enabled. Try to remember what you did and please report a bug.");
                        }
                    }

                    int incrementAmount = 100 / frmMain.tvMatchFilesModel.Nodes.Count;
                    pbTagProgress.Increment(incrementAmount * (i));
                    i++;
                }
                MessageBox.Show("Tagging Complete");
                this.Close();
            }
            catch (Exception ex)
            {
                frmMain.log.AddErrorToRtf(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
    }
}
