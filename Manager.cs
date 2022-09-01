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

        public void BindListToDataGridView(DataGridView DataGridView, FDInfo list, bool rootDir)
        {

            DataGridView.Rows.Clear();

            List<string> name = list.GetName();
            List<long> dataSize = list.GetDataSize();
            List<bool> isFile = list.GetIsFile();

            if (!rootDir)
            {
                DataGridView.Rows.Add("..");
            }

            int fileIndex = 0;

            for (int i = 0; i < name.Count(); i++)
            {

                if (isFile[i])
                {
                    DataGridView.Rows.Add(name[i], GetDataSizeString(dataSize[fileIndex]));
                    fileIndex++;
                } 
                else
                {

                    DataGridView.Rows.Add(name[i]);

                }
            }

        }

        public FDInfo GetAllFolderOrFile(string filePath)
        {

            DirectoryInfo dir = new DirectoryInfo(filePath);

            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] directory = dir.GetDirectories();

            FDInfo allFolderAndFileName = new FDInfo();

            foreach (DirectoryInfo dirN in directory)
            {

                allFolderAndFileName.AddDirectory(dirN.Name);

            }

            foreach (FileInfo file in files)
            {

                allFolderAndFileName.AddFile(file.Name, file.Length);

            }

            return allFolderAndFileName;

        }

        string GetDataSizeString(long dataSizeByte)
        {

            double dataSizeKB = dataSizeByte / 1024;

            if (dataSizeKB < 1)
            {
                return $"{Math.Round(Convert.ToDouble(dataSizeByte), 2)} Byte";
            }

            double dataSizeMB = dataSizeKB / 1024;

            if (dataSizeMB < 1)
            {
                return $"{Math.Round(dataSizeKB, 2)} KB";
            }

            double dataSizeGB = dataSizeMB / 1024;

            if (dataSizeGB < 1)
            {
                return $"{Math.Round(dataSizeMB, 2)} MB";
            }

            return $"{Math.Round(dataSizeGB, 2)} GB";

        }

    }
}
