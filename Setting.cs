using System;
using System.Collections.Generic;
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
            defaultPath = @"C:\Anime";
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

    }
}
