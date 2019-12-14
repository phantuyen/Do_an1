using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_and_write_file_txt
{
    public partial class Form_Xeploai : System.Windows.Forms.Form
    {
        public Form_Xeploai()
        {
            InitializeComponent();
        }
        Stream stream = new Stream();
        LinkedListNode<string> Node1;
        LinkedListNode<string> Node2;
        LinkedList<string> list;
        LinkedList<string> List;
        LinkedList<string> myList;
        LinkedList<string> Diem;
        LinkedList<string> mylist;
        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        private void Form3_Load(object sender, EventArgs e)
        {
            btn_Tatca_Click(sender, e);
           // btn_Khagioi_Click(sender, e);
           // btn_Truot_Click(sender, e);
           // btn_Thukhoa_Click(sender, e);
           // btn_Tatca_Click(sender, e);
        }
        private void btn_Tatca_Click(object sender, EventArgs e)
        {
            //string s;
            //string b;
            //stream.Tinhdiem("Diem_DTN_TD.txt"); //tao ra file Diem_DTN_TD.txt
            //list = new LinkedList<string>();
            //Diem = new LinkedList<string>();
            //myList = new LinkedList<string>();//tat ca

            //stream.File_to_linkedlist(list, path + "DanhSach.txt");
            //stream.File_to_linkedlist(Diem, path + "Diem_DTN_TD.txt");

            //int dem = list.Count;
            //Node1 = list.First;//danh sach
            //Node2 = Diem.First;//diem

            //for (int i = 0; i <dem; i++)
            //{
            //    s = Node1.Value;
            //    int tuoi = (DateTime.Now.Year - Int32.Parse(s.Substring(s.Length - 8, 4)));
            //    //add infor into myList
            //    myList.AddLast(Node1.Value.Substring(0, 32).PadRight(34) + Node1.Value.Substring(33, 1).PadRight(9) + tuoi.ToString().PadRight(9) + Node2.Value.PadRight(76)+ s.Substring(s.Length - 3, 3));
            //    Node1 = Node1.Next;
            //    Node2 = Node2.Next;
            //}
            //string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(8) + "Phai".PadRight(9) + "Tuoi".PadRight(9) + "Toan".PadRight(13) + "Van".PadRight(13) + "AnhVan".PadRight(12) + "DTN".PadRight(13) + "TongDiem".PadRight(13) + "XepLoai".PadRight(12) + "DTDT".PadRight(1);
            //myList.AddFirst(doituong);
            //stream.Linkedlist_to_file(myList, path + "Tatca.txt");//tao ra fiel tat ca
            stream.Tat_ca("Tatca.txt");
            /////
          
            string[] lines=File.ReadAllLines(path + "Tatca.txt");
            string text = File.ReadAllText(path + "Tatca.txt");
            txb_Xeploai.Text = text;
            lbl_Soluong.Text = "Tổng: "+(lines.Length-1);
            lbl_XepLoai.Text = "Danh Sách Chi Tiết ";
        }
        //private void Tinhdiem()
        //{
        //    List = new LinkedList<string>();//diem thi
        //    stream.File_to_linkedlist(List, path + "DiemThi.txt");

        //    myList = new LinkedList<string>();//danh sach
        //    stream.File_to_linkedlist(myList, path + "DanhSach.txt");

        //    Diem = new LinkedList<string>();
        //    Node1 = List.First;//diem thi
        //    Node2 = myList.First;
            
        //    for (int i = 0; i < List.Count; i++)
        //    {
        //        string s = Node1.Value;
        //        string b = Regex.Replace(s, @"\s{2,}", " ");
        //        string[] a = b.Split(' ');
        //        string xeploai = "Trượt     ";
        //        float tongdiem = float.Parse(a[1]) + float.Parse(a[2]) + float.Parse(a[3]);
          

        //        if (Int32.Parse(Node2.Value.Substring(46,1))==1)
        //        {
        //            tongdiem=(tongdiem + 2);
        //        }
        //        if (Int32.Parse(Node2.Value.Substring(46, 1)) == 2)
        //        {
        //            tongdiem = (tongdiem + 1);
        //        }

        //        float diemthapnhat = float.Parse(a[1]);
        //        if (float.Parse(a[2]) < diemthapnhat)
        //        {
        //            diemthapnhat = float.Parse(a[2]);
        //        }
        //        if (float.Parse(a[3]) < diemthapnhat)
        //        {
        //            diemthapnhat = float.Parse(a[3]);

        //        }

        //        if (tongdiem >= 24 && diemthapnhat >= 7)
        //        {
        //            xeploai = "Giỏi      ";
        //        }
        //        else
        //        {
        //            if (tongdiem >= 21 && diemthapnhat >= 6)
        //            {
        //                xeploai = "Khá       ";
        //            }
        //            else
        //            {
        //                if (tongdiem >= 15 && diemthapnhat >= 4)
        //                {
        //                    xeploai = "Trung bình";
        //                }
        //            }

        //        }

        //        Diem.AddLast(Node1.Value.Substring(11, 38) + string.Format("{0:0.00}", diemthapnhat).PadRight(13) + string.Format("{0:0.00}", tongdiem).PadRight(13) + xeploai);
        //        Node1 = Node1.Next;
        //        Node2 = Node2.Next;
        //    }
        //    stream.Linkedlist_to_file(Diem, path + "Diem_DTN_TD.txt");

        //}
        private void btn_Khagioi_Click(object sender, EventArgs e)
        {
            list = new LinkedList<string>();
            List = new LinkedList<string>();//gioi
            myList = new LinkedList<string>();
            mylist = new LinkedList<string>();//kha

            stream.File_to_linkedlist(list, path + "Tatca.txt");
            stream.File_to_linkedlist(myList, path + "Danhsach.txt");
            Node1 = list.First.Next;//tat ca
            Node2 = myList.First;//danh sach
            int soluong_gioi = 0;
            int soluong_kha = 0;

           
            for (int i = 0; i < list.Count-1; i++)
            {
                if (float.Parse(Node1.Value.Substring(52, 5)) == 10 || float.Parse(Node1.Value.Substring(65, 5)) == 10 || float.Parse(Node1.Value.Substring(78, 5)) == 10)
                {
                    if(Node1.Value.Substring(116, 10) == "Giỏi      ")
                    {
                        List.AddLast(Node1.Value.Substring(0, 43) + Node2.Value.Substring(35, 10).PadRight(14) + Node1.Value.Substring(52,38)+ Node1.Value.Substring(103, Node1.Value.Length-103));
                    }
                    else
                    {
                        if (Node1.Value.Substring(116, 10) == "Khá       ")
                        {
                            mylist.AddLast(Node1.Value.Substring(0, 43) + Node2.Value.Substring(35, 10).PadRight(14) + Node1.Value.Substring(52, 38)+ Node1.Value.Substring(103, Node1.Value.Length - 103));
                        }
                    }
                    

                }
                Node1 = Node1.Next;
                Node2 = Node2.Next;
            }
            soluong_gioi = List.Count;
            soluong_kha = mylist.Count;

            Sapxep(List, 82, 5, "giam");//gioi
            Sapxep(mylist, 82, 5, "giam");//kha


            stream.Linkedlist_to_file(List, path + "Xeploai_gioi.txt");
            stream.Linkedlist_to_file(mylist, path + "Xeploai_kha.txt");


            string text1 = File.ReadAllText(path + "Xeploai_gioi.txt");
            string text2 = File.ReadAllText(path + "Xeploai_kha.txt");
            stream.File_to_linkedlist(List, path + "Xeploai_kha.txt");
            stream.File_to_linkedlist(List, path + "Xeploai_gioi.txt");


            string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(8) + "Phai".PadRight(9) + "NgaySinh".PadRight(14) + "Toan".PadRight(13) + "Van".PadRight(13) + "AnhVan".PadRight(12) + "TongDiem".PadRight(13) + "XepLoai".PadRight(12) + "DTDT".PadRight(3);
            List.AddFirst(doituong);
            stream.Linkedlist_to_file(List, path + "Xeploai_gioi_kha.txt");

            string text3 = File.ReadAllText(path + "Xeploai_gioi_kha.txt");

            txb_Xeploai.Text = text3;
            int tong = soluong_gioi + soluong_kha;
            lbl_Soluong.Text = "Tổng " + tong + ":   " + soluong_gioi + " Giỏi  |  " + soluong_kha + " Khá";
            lbl_XepLoai.Text = "Danh Sách Giỏi-Khá";
        }
      
        public void Noi(LinkedList<string> ds1, LinkedList<string> ds2)
        {
            Node2 = ds2.First;
            for (int i = 0; i < ds2.Count; i++)
            {
                ds1.AddLast(Node2.Value);
                Node2 = Node2.Next;
            }
        }
        private void Sapxep(LinkedList<string> ds, int a, int b,string kieu)
        {
            for (Node1 = ds.First; Node1.Next != null; Node1 = Node1.Next)
            {
                for (Node2 = Node1.Next; Node2 != null; Node2 = Node2.Next)
                {
                    if(kieu=="giam")
                    {
                        if (float.Parse(Node1.Value.Substring(a, b)) < float.Parse(Node2.Value.Substring(a, b)))
                        {

                            string tmp = Node1.Value;
                            Node1.Value = Node2.Value;
                            Node2.Value = tmp;

                        }
                    }
                    if (kieu == "tang")
                    {
                        if (float.Parse(Node1.Value.Substring(a, b)) > float.Parse(Node2.Value.Substring(a, b)))
                        {

                            string tmp = Node1.Value;
                            Node1.Value = Node2.Value;
                            Node2.Value = tmp;

                        }
                    }

                }
            }
        }

        private void btn_Truot_Click(object sender, EventArgs e)
        {
            list = new LinkedList<string>();//tat ca
            List = new LinkedList<string>();//truot
            myList = new LinkedList<string>();//danh sach
            mylist = new LinkedList<string>();


            stream.File_to_linkedlist(list, path + "Tatca.txt");
            stream.File_to_linkedlist(myList, path + "Danhsach.txt");
            Node1 = list.First.Next;//tat ca
            Node2 = myList.First;//danh sach
            int soluong_truot = 0;

            for (int i = 0; i < list.Count-1; i++)
            {

                if (Node1.Value.Substring(116,10) == "Trượt     ")
                {
                    //truot tong hop
                    List.AddLast(Node1.Value.Substring(0, 43) + Node2.Value.Substring(35, 10).PadRight(14) + Node1.Value.Substring(52, 38) + Node1.Value.Substring(103, Node1.Value.Length - 103));
                }
                Node1 = Node1.Next;
                Node2 = Node2.Next;
            }
            list.Clear();
            myList.Clear();

            Sapxep(List, 120, 1, "tang");//tang dan theo doi tuong du thi
            Node1 = List.First;


            for (int i = 0; i < List.Count; i++)
            {
                if (Int32.Parse(Node1.Value.Substring(120, 1)) == 3)
                {
                    //doi tuong 3
                    list.AddLast(Node1.Value);

                }
                if (Int32.Parse(Node1.Value.Substring(120, 1)) == 2)
                {
                    //doi tuong 2
                    myList.AddLast(Node1.Value);

                }
                if (Int32.Parse(Node1.Value.Substring(120, 1)) == 1)
                {
                    //doi tuong 1
                    mylist.AddLast(Node1.Value);

                }
                Node1 = Node1.Next;
            }

            Sapxep(list, 95, 5, "giam");
            Sapxep(myList, 95, 5, "giam");
            Sapxep(mylist, 95, 5, "giam");

            List.Clear();

            Noi(List, mylist);
            Noi(List, myList);
            Noi(List, list);

            soluong_truot = List.Count;


            string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(8) + "Phai".PadRight(9) + "NgaySinh".PadRight(14) + "Toan".PadRight(13) + "Van".PadRight(13) + "AnhVan".PadRight(12) + "TongDiem".PadRight(13) + "XepLoai".PadRight(12) + "DTDT".PadRight(3);
            List.AddFirst(doituong);
            stream.Linkedlist_to_file(List, path + "Xeploai_truot.txt");
            string text1 = File.ReadAllText(path + "Xeploai_truot.txt");

            txb_Xeploai.Text = text1;
            lbl_Soluong.Text = "Có " + soluong_truot + " Trượt";
            lbl_XepLoai.Text = "Danh Sách Trượt ";

        }
       
        private void btn_Thukhoa_Click(object sender, EventArgs e)
        {
            list = new LinkedList<string>();//diem gioi
            mylist = new LinkedList<string>();//thu khoa
            stream.File_to_linkedlist(list, path + "Xeploai_gioi.txt");
            Sapxep(list, 95, 5,"giam");
            float diem_max = float.Parse(list.First.Value.Substring(95, 5));
            Node1 = list.First;//xeo loai gioi
            float diem;
            for (int i = 0; i < list.Count; i++)
            {
                diem = float.Parse(Node1.Value.Substring(95, 5));
                if (diem == diem_max)
                {
                    mylist.AddLast(Node1.Value);
                    Node1 = Node1.Next;
                }
            }
            int sl = mylist.Count;
          
            string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(8) + "Phai".PadRight(9) + "NgaySinh".PadRight(14) + "Toan".PadRight(13) + "Van".PadRight(13) + "AnhVan".PadRight(12) + "TongDiem".PadRight(13) + "XepLoai".PadRight(12) + "DTDT".PadRight(3);
            mylist.AddFirst(doituong);
            stream.Linkedlist_to_file(mylist, path + "Thukhoa.txt");
            txb_Xeploai.Text = File.ReadAllText(path + "Thukhoa.txt");
            lbl_Soluong.Text = "Có " + sl + " Thủ khoa";
        }

    }
}
