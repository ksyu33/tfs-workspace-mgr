using Microsoft.TeamFoundation.Build.WebApi;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_test
{
    public partial class MainForm : Form
    {
        private Uri _serverUri = new Uri("https://simpleisbest.visualstudio.com/");
        private TfsTeamProjectCollection _collection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void GetWorkspaces()
        {
            lvWorkspaces.Items.Clear();
            var vc = _collection.GetService<VersionControlServer>();
            var wss = vc.QueryWorkspaces(null, null, null, WorkspacePermissions.Administer).OrderBy(ws => ws.Name);
            foreach (var ws in wss)
            {
                var item = new ListViewItem();
                item.Text = ws.Name;
                item.Tag = ws;
                item.SubItems.Add(ws.OwnerDisplayName);
                item.SubItems.Add(ws.Computer);
                item.SubItems.Add(ws.LastAccessDate.ToString("yyyy-MM-dd HH:mm:ss"));
                item.SubItems.Add(ws.Comment);
                lvWorkspaces.Items.Add(item);
            }
        }

        private void btnGetWorkspaces_Click(object sender, EventArgs e)
        {
            GetWorkspaces();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _collection = new TfsTeamProjectCollection(_serverUri, System.Net.CredentialCache.DefaultCredentials);
            if (_collection == null)
            {
                var tfsPicker = new TeamProjectPicker();
                var result = tfsPicker.ShowDialog(this);
                _collection = tfsPicker.SelectedTeamProjectCollection;
            }
        }

        private void btnDeleteWorkspace_Click(object sender, EventArgs e)
        {
            var deleteList = new List<Workspace>();
            foreach(ListViewItem item in lvWorkspaces.CheckedItems)
            {
                var ws = item.Tag as Workspace;
                if (ws != null && ws.IsDeleted == false)
                {
                    ws.Delete();
                }
            }
            GetWorkspaces();
        }
    }
}
