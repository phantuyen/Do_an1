using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_and_write_file_txt
{
    public partial class Form_Danhsach : System.Windows.Forms.Form
    {
       
        public Form_Danhsach()
        {
            InitializeComponent();
        }
        LinkedList<string> list;
        LinkedList<string> mylist;
        LinkedListNode<string> node;
        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        private void Form_Danhsach_Load(object sender, EventArgs e)
        {
            Stream stream = new Stream();
            list = new LinkedList<string>();//danh sach
            mylist = new LinkedList<string>();//danh sach can chinh
            stream.File_to_linkedlist(list, path + "DanhSach.txt");
            node = list.First;
            string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(11) + "Phai".PadRight(6) + "NgaySinh".PadRight(15) + "DTUT";

            mylist.AddFirst(doituong);
            for (int i = 0; i < list.Count; i++)
            {
                mylist.AddLast(node.Value.Substring(0, 32).PadRight(37) + node.Value.Substring(33, 1).PadRight(6) + node.Value.Substring(35, 10).PadRight(15) + node.Value.Substring(46, 1));
                node = node.Next;
            }
           
          
            stream.Linkedlist_to_file(mylist, path + "ds.txt");
            string text = File.ReadAllText(path + "ds.txt");
            txb_Danhsach.Text = text;
            lbl_Soluong.Text = "Tổng số: "+list.Count+" sinh viên";
        }

     
    }
}
