using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManager
{
    public partial class Form1 : Form
    {
        List<string> DirList = new List<string>();

        Manager manager = new Manager();

        string defaultPath;
        string path;
        List<string> pathHistory = new List<string>();

        public Form1()
        {
            InitializeComponent();

            defaultPath = @"C:\Anime";
            path = defaultPath;

            DirList = manager.GetAllFolderOrFileName(path);

            fileExplorerBox.DoubleClick += new EventHandler(fileExplorerBoxItem_Click);

            manager.BindListToListBox(fileExplorerBox, DirList, true);
        }

        private void fileExplorerBoxItem_Click(object sender, System.EventArgs e)
        {

            if (fileExplorerBox.SelectedItem.ToString() == "..")
            {
                pathHistory.RemoveAt(pathHistory.Count() - 1);

                path = defaultPath;

                foreach (string dir in pathHistory)
                {

                    path += @"\" + dir;

                }

            } else
            {
                path += @"\" + fileExplorerBox.SelectedItem.ToString();
                pathHistory.Add(fileExplorerBox.SelectedItem.ToString());
            }
            

            DirList.Clear();

            DirList = manager.GetAllFolderOrFileName(path);

            if (path == defaultPath)
            {
                manager.BindListToListBox(fileExplorerBox, DirList, true);
            }
            else
            {
                manager.BindListToListBox(fileExplorerBox, DirList, false);
            }
        }
    }
}
