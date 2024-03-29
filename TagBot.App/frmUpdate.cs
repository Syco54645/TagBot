﻿using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagBot.App.Properties;

namespace TagBot.App
{
    public partial class frmUpdate : Form
    {
        public frmMain frmMain;

        public frmUpdate()
        {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;
            btnInfo.Enabled = false;
            CheckGitHubNewerVersion();
        }

        private void btnCheckForUpdate_Click(object sender, EventArgs e)
        {
            CheckGitHubNewerVersion();
        }

        private async System.Threading.Tasks.Task CheckGitHubNewerVersion()
        {
            try
            {
                lvUpdates.Items.Clear();

                getReleases(UpdateObjectType.Database);
                getReleases(UpdateObjectType.Application);
            }
            catch (Exception e)
            {
                frmMain.log.AddErrorToRtf(e.Message);
            }
        }

        private async void getReleases(UpdateObjectType objectType)
        {
            string localVersion = "TagBot-" + frmMain.getAssemblyVersion();
            try
            {
                bool updateAvailable = false;
                GitHubClient client = new GitHubClient(new ProductHeaderValue("SomeName"));
                Uri repoUri = new Uri(getUpdateUrlForObject(objectType), UriKind.Absolute);
                string[] urlParts = repoUri.LocalPath.TrimStart('/').Split('/');
                IReadOnlyList<Release> releases = await client.Repository.Release.GetAll(urlParts[0], urlParts[1]);
                List<Release> entityReleases;

                string releaseTitle = string.Empty;
                string githubVersion = string.Empty;
                if (objectType == UpdateObjectType.Database)
                {
                    githubVersion = releases.Select(x => x).Where(x => x.Name.StartsWith(frmMain.databaseMeta.Name)).FirstOrDefault().TagName;
                    entityReleases = releases.Select(x => x).Where(x => x.Name.StartsWith(frmMain.databaseMeta.Name)).ToList();
                    localVersion = convertDataVersionToGithubDatabaseVersion();
                    releaseTitle = ": " + frmMain.databaseMeta.Name;
                }
                else
                {
                    githubVersion = releases.Select(x => x).Where(x => x.Name.StartsWith("TagBot") && !x.Name.StartsWith("TagBot.Api")).FirstOrDefault().TagName;
                    entityReleases = releases.Select(x => x).Where(x => x.Name.StartsWith("TagBot") && !x.Name.StartsWith("TagBot.Api")).ToList();
                }
                ListViewItem item = new ListViewItem(new string[] { objectType + releaseTitle, localVersion, githubVersion });

                if (githubVersion != localVersion)
                {
                    updateAvailable = true;
                }

                item.Tag = new UpdateItem()
                {
                    ObjectType = objectType,
                    UpdateAvailable = updateAvailable,
                    UpdateUrl = getUpdateUrlForObject(objectType),
                    Changelog = entityReleases.TakeWhile(x => x.TagName != localVersion).ToDictionary(x => x.TagName, x => x.Body)
                    //entityReleases.TakeWhile(x => x.TagName != localVersion).Select(x => x.Body).ToList(),
                };

                if (updateAvailable)
                {
                    item.Font = new Font(lvUpdates.Font, FontStyle.Bold);
                    item.ForeColor = Color.Blue;
                }
                lvUpdates.Items.Add(item);
            }
            catch (Exception e)
            {
                frmMain.log.AddErrorToRtf(e.Message);

                ListViewItem item = new ListViewItem(new string[] { objectType.ToString() , localVersion, "Error Fetching Repo" });
                item.Tag = new UpdateItem()
                {
                    ObjectType = objectType,
                    UpdateAvailable = false,
                };
                item.ForeColor = Color.LightGray;
                lvUpdates.Items.Add(item);
            }
            lvUpdates.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvUpdates.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public string getUpdateUrlForObject(UpdateObjectType objectType)
        {
            if (objectType == UpdateObjectType.Database)
            {
                return frmMain.databaseMeta.DatabaseRepo;
            }
            return Settings.Default.applicationRepo;
        }

        public string convertDataVersionToGithubDatabaseVersion()
        {
            return frmMain.databaseMeta.Name + "-" + frmMain.databaseMeta.DataVersion.Replace('-', '.').Replace(':', '.').Replace(' ', '.');
        }

        private void lvUpdates_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;
            btnInfo.Enabled = false;
            ListView lv = (sender as ListView);
            if (lv.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedItem = lv.SelectedItems[0];
            UpdateItem tag = (UpdateItem)selectedItem.Tag;
            btnDownload.Enabled = tag.UpdateAvailable;
            btnInfo.Enabled = tag.Changelog.Count > 0;
            btnDownload.Tag = tag.UpdateUrl;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            System.Diagnostics.Process.Start((string)btn.Tag);
        }

        public enum UpdateObjectType
        {
            Application,
            Database
        }

        public class UpdateItem
        {
            public bool UpdateAvailable { get; set; } = false;
            public UpdateObjectType ObjectType { get; set; }
            public string UpdateUrl { get; set; } = string.Empty;
            public Dictionary<string, string> Changelog { get; set; } = new Dictionary<string, string>();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lvUpdates.SelectedItems.Count > 0)
            {
                UpdateItem tag = (UpdateItem)lvUpdates.SelectedItems[0].Tag;
                frmChangelog frmChangelog = new frmChangelog(tag.Changelog);
                frmMain.centerToMainForm(frmChangelog);
                frmChangelog.Show();
            }
        }
    }
}
