using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_and_write_file_txt
{
    public partial class Form_Chinhsach : System.Windows.Forms.Form
    {
        public Form_Chinhsach()
        {
            InitializeComponent();
        }
        Stream stream = new Stream();
        LinkedList<string> list;
        LinkedList<string> mylist;
        LinkedListNode<string> node;
        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        string doituong ="DTDT".PadRight(8)+"Dien giai DT".PadRight(50)+"Diem UT";

        private void Form_Chinhsach_Load(object sender, EventArgs e)
        {
            list = new LinkedList<string>();
            stream.File_to_linkedlist(list, path + "ChinhSach.txt");
            mylist = new LinkedList<string>();
            mylist.AddFirst(doituong);
            node = list.First;
            for (int i = 0; i < list.Count; i++)
            {
                mylist.AddLast(node.Value.Substring(0, 1).PadRight(8) + node.Value.Substring(3, 39).PadRight(50) + node.Value.Substring(53, 1));
                node = node.Next;
            }
            stream.Linkedlist_to_file(mylist, path + "cs.txt");
            string text = File.ReadAllText(path + "cs.txt");
            txb_Chinhsach.Text = text;
        }

    }
}
