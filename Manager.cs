using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnimeManager
{
    public class Manager
    {

        public Manager()
        {



        }

        public void BindListToListBox(ListBox listBox, List<string> list, bool rootDir)
        {

            listBox.Items.Clear();

            if (!rootDir)
            {
                listBox.Items.Add("..");
            }

            foreach (var i in list)
            {

                listBox.Items.Add(i);

            }

        }

        public List<string> GetAllFolderOrFileName(string filePath)
        {

            DirectoryInfo dir = new DirectoryInfo(filePath);

            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] directory = dir.GetDirectories();

            List<string> allFolderAndFileName = new List<string>();

            foreach (DirectoryInfo dirN in directory)
            {

                allFolderAndFileName.Add(dirN.Name);

            }

            foreach (FileInfo file in files)
            {

                allFolderAndFileName.Add(file.Name);

            }

            return allFolderAndFileName;

        }

    }
}
