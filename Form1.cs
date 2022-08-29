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

        Manager manager;
        SettingMenu settingMenu;
        Setting settingRef;

        string path;
        List<string> pathHistory = new List<string>();

        public Form1()
        {
            settingRef = new Setting();
            settingRef.CheckDirectory();

            manager = new Manager();

            InitializeComponent();

            path = settingRef.defaultPath;

            fileExplorerBox.DoubleClick += new EventHandler(fileExplorerBoxItem_Click);

            RefreshFileExplorerBox();
        }

        public void RefreshFileExplorerBox()
        {
            path = settingRef.defaultPath;
            DirList.Clear();
            pathHistory.Clear();

            DirList = manager.GetAllFolderOrFileName(path);

            manager.BindListToListBox(fileExplorerBox, DirList, true);
        }

        private void fileExplorerBoxItem_Click(object sender, System.EventArgs e)
        {

            if (fileExplorerBox.SelectedItem.ToString() == "..")
            {
                pathHistory.RemoveAt(pathHistory.Count() - 1);

                path = settingRef.defaultPath;

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

            if (path == settingRef.defaultPath)
            {
                manager.BindListToListBox(fileExplorerBox, DirList, true);
            }
            else
            {
                manager.BindListToListBox(fileExplorerBox, DirList, false);
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            settingMenu = new SettingMenu(settingRef, this);
            settingMenu.Show();
        }
    }
}
