using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManager
{
    public class Setting
    {

        public Manager manager;

        public string defaultPath;

        public Setting()
        {
            defaultPath = @"C:\Anima";
        }

        public void SetManager(Manager manager)
        {
            this.manager = manager;
        }

        public void SetFileSettingListBox(ListBox listBox)
        {

            Button test = new Button();
            test.Text = "ceci est un test";
            
            listBox.Items.Add(test);

        }

        public void CheckDirectory()
        {
            if (!Directory.Exists(defaultPath))
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Choose a existing folder";
                dialog.ShowDialog();
                defaultPath = dialog.SelectedPath;
            }
        }
    }
}
