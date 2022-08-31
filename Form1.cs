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
        FDInfo DirList = new FDInfo();

        Manager manager = new Manager();
        SettingMenu settingMenu;
        Setting settingRef = new Setting();

        string path;
        List<string> pathHistory = new List<string>();

        public Form1()
        {
            settingRef.CheckDirectory();

            InitializeComponent();

            path = settingRef.defaultPath;

            fileExplorerDataGrid.CellDoubleClick += new DataGridViewCellEventHandler(fileExplorerBoxItem_Click);

            RefreshFileExplorerBox();
        }

        public void RefreshFileExplorerBox()
        {
            path = settingRef.defaultPath;
            DirList.Clear();
            pathHistory.Clear();

            DirList = manager.GetAllFolderOrFile(path);

            manager.BindListToDataGridView(fileExplorerDataGrid, DirList, true);
        }

        private void fileExplorerBoxItem_Click(object sender, System.EventArgs e)
        {

            string fileName = fileExplorerDataGrid.SelectedRows[0].Cells[0].Value.ToString();

            if (fileName == "..")
            {
                pathHistory.RemoveAt(pathHistory.Count() - 1);

                path = settingRef.defaultPath;

                foreach (string dir in pathHistory)
                {

                    path += @"\" + dir;

                }

            } else
            {
                path += @"\" + fileName;
                pathHistory.Add(fileName);
            }
            

            DirList.Clear();

            DirList = manager.GetAllFolderOrFile(path);

            if (path == settingRef.defaultPath)
            {
                manager.BindListToDataGridView(fileExplorerDataGrid, DirList, true);
            }
            else
            {
                manager.BindListToDataGridView(fileExplorerDataGrid, DirList, false);
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            settingMenu = new SettingMenu(settingRef, this);
            settingMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
