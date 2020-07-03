using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FileTraverser.UI
{
    public partial class MainForm : Form
    {
        Core.Interfaces.IFileTraverser traverser;
        public MainForm()
        {
            InitializeComponent();
            dayCountTxt.Text = "0";
            displayExtentionTxt.Text = "txt";
            selectFolderDialog = new FolderBrowserDialog();
        }

        private void SelectDirectoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = selectFolderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFolderDialog.SelectedPath))
            {
                displayDirectoryTxt.Text = selectFolderDialog.SelectedPath;
                traverser = new Core.FileTraverser();

                traverser.PopulateFiles(selectFolderDialog.SelectedPath,
                    displayExtentionTxt.Text,
                    double.Parse(dayCountTxt.Text));
            }

            SetListViewTree();
        }

        private void SetListViewTree()
        {
            FileListView.Items.Clear();
            FileListView.Groups.Clear();

            var files = traverser.GetFiles();

            foreach (string directoryGroup in files.Select(f => f.Directory).Distinct())
            {
                var groupToAdd = new ListViewGroup(directoryGroup);
                groupToAdd.Name = directoryGroup;
                FileListView.Groups.Add(groupToAdd);
            }

            var groupsPresent = FileListView.Groups.Cast<ListViewGroup>().ToList();

            foreach (Core.MyFile file in files)
            {
                var group = groupsPresent.Find(g => g.Header == file.Directory);
                FileListView.Items.Add(new ListViewItem(new[] { file.Name, file.Directory, file.LastModify.ToString() }, group));
            }
        }
    }
}
