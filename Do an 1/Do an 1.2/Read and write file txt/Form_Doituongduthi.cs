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
    public partial class Form_Doituongduthi : Form
    {
        public Form_Doituongduthi()
        {
            InitializeComponent();
        }
        Stream stream = new Stream();
        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        LinkedList<string> list;
        LinkedList<string> mylist;
        LinkedList<string> List;
        LinkedListNode<string> node;
        LinkedListNode<string> Node;
        string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(8) + "Phai".PadRight(9) + "NgaySinh".PadRight(14) + "Toan".PadRight(13) + "Van".PadRight(13) + "AnhVan".PadRight(12) + "TongDiem".PadRight(13) + "XepLoai".PadRight(12) + "DTDT".PadRight(3);
        string texts;
        private void Form_Doituongduthi_Load(object sender, EventArgs e)
        {
            txb_Doituongduthi_TextChanged(sender, e);
        }
        private void txb_Doituongduthi_TextChanged(object sender, EventArgs e)
        {
            list = new LinkedList<string>();
            mylist = new LinkedList<string>();
            List = new LinkedList<string>();
            stream.File_to_linkedlist(list, path + "Tatca.txt");//tat ca
            stream.File_to_linkedlist(mylist, path + "DanhSach.txt");//danh sach
            node = list.First.Next;
            Node = mylist.First;
            double truot = 0;
           
            if (txb_Doituongduthi.Text=="")
            {
                for (int i = 0; i < mylist.Count; i++)
                {

                    List.AddLast(node.Value.Substring(0, 43) + Node.Value.Substring(35, 10).PadRight(14) + node.Value.Substring(52, 38) + node.Value.Substring(103, node.Value.Length - 103));
                    if (node.Value.Substring(116, 10) == "Trượt     ")
                    {
                        truot++;
                    }
                    node = node.Next;
                    Node = Node.Next;
                }
            }
            else
            {
                int DT = Int32.Parse(txb_Doituongduthi.Text);
                for (int i = 0; i < mylist.Count; i++)
                {
                    if (DT == Int32.Parse(node.Value.Substring(128, 1)))
                    {
                        List.AddLast(node.Value.Substring(0, 43) + Node.Value.Substring(35, 10).PadRight(14) + node.Value.Substring(52, 38) + node.Value.Substring(103, node.Value.Length - 103));
                        if (node.Value.Substring(116, 10) == "Trượt     ")
                        {
                            truot++;
                        }
                    }
                    node = node.Next;
                    Node = Node.Next;
                }
               
            }
            double soluong = List.Count;
            List.AddFirst(doituong);
            stream.Linkedlist_to_file(List, path + "searchdoituong.txt");
            texts = File.ReadAllText(path + "searchdoituong.txt");
            txb_Danhsach.Text = texts;
            lbl_Soluong.Text = "Tổng: " + soluong + " đối tượng";
            double ptramD = ((soluong - truot) / soluong) * 100;
            double ptramT = (truot / soluong) * 100;
            lbl_Dau.Text = "Đậu:   " + (soluong - truot) + " ( " + Math.Round(ptramD, 2) + " % )";            lbl_Truot.Text = "Trượt: " + truot + "   ( " + Math.Round(ptramT, 2) + " % )";
        }
    }
}
