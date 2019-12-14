using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Read_and_write_file_txt
{
    public partial class Form_Baodiem : Form
    {
        public Form_Baodiem()
        {
            InitializeComponent();
        }
        Stream stream = new Stream();
        LinkedList<string> list;//tat ca
        LinkedList<string> mylist1;//bao diem
        LinkedList<string> mylist2;//bao diem
        LinkedList<string> mylist3;//bao diem
        LinkedList<string> mylist4;//bao diem
        LinkedListNode<string> node;
        LinkedListNode<string> node1;
        LinkedListNode<string> node2;
        LinkedListNode<string> node3;
        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        
        public void Add(LinkedList<string>mylist)
        {
            
            string s= node.Value.Substring(11, 23);
            string b= Regex.Replace(s, @"\s{2,}", " ");
            string[] a= b.Split(' ');
            string Ten;
            mylist.AddLast("GIAY BAO DIEM");
            mylist.AddLast("So Bao Danh: " + Int32.Parse(node.Value.Substring(0, 11)));
            if (Int32.Parse(node.Value.Substring(34, 1)) == 1)
            {
                Ten = "Chi: " + b;
            }
            else
            {
                Ten = "Anh: " + b;
            }
            mylist.AddLast(Ten);
            mylist.AddLast("Toan:    " + node.Value.Substring(52, 5));
            mylist.AddLast("Van:     " + node.Value.Substring(65, 5));
            mylist.AddLast("Anh van: " + node.Value.Substring(78, 5));
            mylist.AddLast("Tong Diem: " + node.Value.Substring(103, 5));
            mylist.AddLast("Xep Loai: " + node.Value.Substring(116, 10));
        }


        private void Form_Baodiem_Load(object sender, EventArgs e)
        {
            stream.Tat_ca("Tatca.txt");
            list = new LinkedList<string>();
            mylist1 = new LinkedList<string>();
            mylist2 = new LinkedList<string>();
            mylist3 = new LinkedList<string>();
            mylist4 = new LinkedList<string>();

            stream.File_to_linkedlist(list, path + "Tatca.txt");
            int dem = list.Count - 1;
            int i;
            int mood= dem%3;
            node = list.First.Next;
            for (i = 0; i < dem-mood; i+=3)
            {
                Add(mylist1);
                node = node.Next;
                Add(mylist2);
                node = node.Next;
                Add(mylist3);
                node = node.Next;
            }
            if(mood==1)
            {
                Add(mylist1);
            }
            if(mood==2)
            {
                Add(mylist1);
                node = node.Next;
                Add(mylist2);
            }

         
            int dem1 = mylist1.Count;
            int dem2 = mylist2.Count;
            int dem3 = mylist3.Count;
            int min = dem1;
            if(min>dem2)
            {
                min = dem2;
            }
            if (min > dem3)
            {
                min = dem3;
            }
            node1 = mylist1.First;
            node2 = mylist2.First;
            node3 = mylist3.First;
          
            for ( i = 1; i <= min; i++)
            {
                mylist4.AddLast(node1.Value.PadRight(30)+ node2.Value.PadRight(30)+ node3.Value.PadRight(30));
                if (i > 1 && i % 8 == 0)
                {
                    mylist4.AddLast("".PadRight(90));
                }
                node1 = node1.Next;
                node2 = node2.Next;
                node3 = node3.Next;
               
            }
            if(mood==1)
            {

                for (i = 1; i <= 8; i++)
                {
                    mylist4.AddLast(node1.Value.PadRight(30) + "".PadRight(30) + "".PadRight(30));
                    node1 = node1.Next;
                }
               
            }
            if (mood == 2)
            {

                for (i = 1; i <= 8; i++)
                {
                    mylist4.AddLast(node1.Value.PadRight(30) + node2.Value.PadRight(30) + "".PadRight(30));
                    node1 = node1.Next;
                    node2=node2.Next;
                }

            }

            stream.Linkedlist_to_file(mylist4, path + "Giaybaodiem.txt");
            string texts = File.ReadAllText(path + "Giaybaodiem.txt");
            txb_Baodiem.Text = "" + texts;
            lbl_Siso.Text = "Số Lượng: " + dem+" SV";

        }
    }
}
