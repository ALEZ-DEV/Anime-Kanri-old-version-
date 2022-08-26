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
    public partial class SettingMenu : Form
    {

        Setting setting;
        Form1 form1;

        public SettingMenu(Setting settingRef, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            setting = settingRef;

            textBoxDefaultPath.Text = setting.defaultPath;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog.ShowDialog();

            string path = folderBrowserDialog.SelectedPath;

            setting.defaultPath = path;

            textBoxDefaultPath.Text = path;

            form1.RefreshFileExplorerBox();

        }
    }
}
