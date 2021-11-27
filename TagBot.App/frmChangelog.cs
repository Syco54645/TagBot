using Markdig;
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

namespace TagBot.App
{
    public partial class frmChangelog : Form
    {
        Dictionary<string, string> changelog;
        public frmChangelog()
        {
            InitializeComponent();
        }

        public frmChangelog(Dictionary<string, string> changelog)
        {
            InitializeComponent();
            this.changelog = changelog;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangeLog_Load(object sender, EventArgs e)
        {
            string change = string.Empty;
            foreach (KeyValuePair<string, string> entry in changelog)
            {
                change += "# " + entry.Key + Environment.NewLine + Environment.NewLine + entry.Value + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
            string html = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/docs/credits.css") + Markdown.ToHtml(change);
            wbChangelog.DocumentText = html;
        }
    }
}
