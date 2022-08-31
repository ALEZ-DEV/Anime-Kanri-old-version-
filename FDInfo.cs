using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AnimeManager
{
    public class FDInfo
    {

        List<string> fileName = new List<string>();
        List<long> dataSize = new List<long>();
        List<bool> isFile = new List<bool>();

        public void AddFile(string fileName, long dataSize)
        {

            this.fileName.Add(fileName);
            this.dataSize.Add(dataSize);
            isFile.Add(true);

        }

        public void AddDirectory(string DirectoryName)
        {

            fileName.Add(DirectoryName);
            isFile.Add(false);

        }

        public void Clear()
        {

            fileName.Clear();
            dataSize.Clear();
            isFile.Clear();

        }

        public List<string> GetName()
        {
            return fileName;
        }

        public List<long> GetDataSize()
        {
            return dataSize;
        }

        public List<bool> GetIsFile()
        {
            return isFile;
        }

    }
}
