using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagBot.App.Properties;
using System.Configuration;

namespace TagBot.App
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                string major = Assembly.GetExecutingAssembly().GetName().Version.Major.ToString();
                string minor = Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
                string build = Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
                string revision = Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
                var appSettings = ConfigurationManager.AppSettings;
                if (appSettings.GetValues("releaseStage").FirstOrDefault() == "debug")
                {
                    revision += " Debug";
                }
                return major + "." + minor + "." + build + "." + revision;
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.Text = "About TagBot";
            lblName.Text = "TagBot";
            lblVersion.Text = String.Format("Version {0}", AssemblyVersion);
            lblCopyright.Text = AssemblyCopyright;
            lblWebsite.Text = Settings.Default.applicationRepo;
            string html = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/docs/credits.css") + Markdown.ToHtml(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/docs/credits.md"));
            wbDescription.DocumentText = html;

            rtbLegal.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/docs/LICENSE");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)lblWebsite.Text);
        }

        public void wbDescription_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!(e.Url.ToString().Equals("about:blank", StringComparison.InvariantCultureIgnoreCase)))
            {
                System.Diagnostics.Process.Start(e.Url.ToString());
                e.Cancel = true;
            }
        }

    }
}
