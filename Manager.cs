using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManager
{
    public class Manager
    {

        public List<string> list = new List<string>();

        public void initList()
        {

            list.Add("item1");
            list.Add("item2");
            list.Add("item3");
            list.Add("item4");
            list.Add("item5");
            list.Add("item6");
            list.Add("item7");
            list.Add("item8");
            list.Add("item9");

        }

        public void BindListToListBox(ListBox listBox, List<string> list)
        {

            foreach (var i in list)
            {

                listBox.Items.Add(i);

            }

        }

    }
}
