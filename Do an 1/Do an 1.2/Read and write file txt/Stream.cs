using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Read_and_write_file_txt
{

    class Stream
    {
        string line, path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        LinkedList<String> myList;
        LinkedList<String> List;
        LinkedList<String> list;
        LinkedList<String> Diem;
        LinkedListNode<string> node;
        LinkedListNode<string> Node;
        LinkedListNode<string> Node1;
        LinkedListNode<string> Node2;


        public void LayID(LinkedList<string> ds, string path)
        {
            myList = new LinkedList<String>();
            list = new LinkedList<string>();
            node = ds.First;
            int soluong = ds.Count;
            for (int i = 0; i < soluong; i++)
            {
                list.AddLast(node.Value.ToString().Substring(0, 11));
                node = node.Next;
            }
            Linkedlist_to_file(list, path);
        }

        public void Chuyen_CSDL(int bd, string tencsdl, string newtencsdl)
        {
            myList = new LinkedList<String>();
            string[] lines = File.ReadAllLines(path + tencsdl);
            for (int i = bd; i < lines.Length; i++)
            {

                myList.AddLast(lines[i]);

            }
            Linkedlist_to_file(myList, path + newtencsdl);
        }



        public void Update(int end,string csdl, string newcsdl)
        {
            myList = new LinkedList<string>();
            string[] lines =File.ReadAllLines(path + csdl);
            for (int i = 0; i < end; i++)
            {
                myList.AddLast(lines[i]);
            }
            File_to_linkedlist(myList, path + newcsdl);
            Linkedlist_to_file(myList, path + csdl);
        }
        public void Deletes(string Ten_file, int SBD)
        {
            myList = new LinkedList<string>();
            File_to_linkedlist(myList, path + Ten_file);
            int count = myList.Count;
            if (SBD <= 0)
            {

                MessageBox.Show("Sinh viên không có trong danh sách !!!", "Thông báo");
            }
            else
            {
                node = myList.First;

                int i;
                for (i = 0; i < count; i++)
                {
                    if (Int32.Parse(node.Value.Substring(0, 11)) == SBD)
                    {
                        myList.Remove(node.Value);

                        break;
                    }
                    node = node.Next;
                }

                if (node == null)
                {
                    MessageBox.Show("Sinh viên không có trong danh sách !!!", "Thông báo");
                }
                Linkedlist_to_file(myList, path + Ten_file);
            }
        }

        public void File_to_linkedlist(LinkedList<string> DanhSach, string path)
        {
            StreamReader streamReader = new StreamReader(path);
            while ((line = streamReader.ReadLine()) != null)
            {
                DanhSach.AddLast(line);
            }
            streamReader.Close();
        }
        public void Linkedlist_to_file(LinkedList<string> ds, string path)
        {

            //  StreamWriter streamWriter = new StreamWriter(path + "Xeploai_truot.txt");
            StreamWriter streamWriter = new StreamWriter(path);
            int dem = ds.Count;

            // streamWriter.WriteLine(doituong);
            for (int i = 0; i < dem; i++)
            {

                streamWriter.WriteLine(ds.First.Value);
                ds.RemoveFirst();
            }
            streamWriter.Close();
        }



        public void Add_Thongtin(int SBD, string Ho, string Ten, string Phai, string Ngaysinh, int DTDT, int sbd, string vtri)
        {
            myList = new LinkedList<string>();
            File_to_linkedlist(myList, path + "DanhSach.txt");
            node = myList.First;
            int i;

            for (i = 0; i < myList.Count; i++)
            {
                if (Int32.Parse(node.Value.Substring(0, 11)) == sbd)
                {
                    if (vtri == "after")
                    {
                        myList.AddBefore(node, Convert.ToString(SBD).PadRight(11) + Ho + Ten + Phai + Ngaysinh + Convert.ToString(DTDT).PadRight(3));
                    }
                    if (vtri == "before")
                    {
                        myList.AddAfter(node, Convert.ToString(SBD).PadRight(11) + Ho + Ten + Phai + Ngaysinh + Convert.ToString(DTDT).PadRight(3));

                    }
                    if (vtri == "addlast")
                    {
                        node = myList.Last;
                        myList.AddAfter(node, Convert.ToString(SBD).PadRight(11) + Ho + Ten + Phai + Ngaysinh + Convert.ToString(DTDT).PadRight(3));

                    }


                    Linkedlist_to_file(myList, path + "DanhSach.txt");
                    break;
                }
                node = node.Next;
            }
            if (node == null)
            {
                MessageBox.Show("Khong tim thay vi tri can them !!!");
            }

        }

        public void Add_Diem(int SBD, float Toan, float Van, float Anhvan, int sbd, string vtri)
        {
            myList = new LinkedList<string>();
            File_to_linkedlist(myList, path + "DiemThi.txt");
            node = myList.First;
            int i;

            for (i = 0; i < myList.Count; i++)
            {
                if (Int32.Parse(node.Value.Substring(0, 11)) == sbd)
                {
                    if (vtri == "after")
                    {
                        myList.AddBefore(node, Convert.ToString(SBD).PadRight(11) + string.Format("{0:0.00}", Toan).PadRight(13) + string.Format("{0:0.00}", Van).PadRight(13) + string.Format("{0:0.00}", Anhvan).PadRight(13));
                    }
                    if (vtri == "before")
                    {
                        myList.AddAfter(node, Convert.ToString(SBD).PadRight(11) + string.Format("{0:0.00}", Toan).PadRight(13) + string.Format("{0:0.00}", Van).PadRight(13) + string.Format("{0:0.00}", Anhvan).PadRight(13));

                    }
                    if (vtri == "addlast")
                    {
                        node = myList.Last;
                        myList.AddAfter(node, Convert.ToString(SBD).PadRight(11) + string.Format("{0:0.00}", Toan).PadRight(13) + string.Format("{0:0.00}", Van).PadRight(13) + string.Format("{0:0.00}", Anhvan).PadRight(13));

                    }


                    Linkedlist_to_file(myList, path + "DiemThi.txt");
                    break;
                }
                node = node.Next;
            }
            if (node == null)
            {
                MessageBox.Show("Khong tim thay vi tri can them !!!");
            }

        }

        public void Tinhdiem(string tenfile)
        {
            List = new LinkedList<string>();//diem thi
            File_to_linkedlist(List, path + "DiemThi.txt");

            myList = new LinkedList<string>();//danh sach
            File_to_linkedlist(myList, path + "DanhSach.txt");

            Diem = new LinkedList<string>();
            Node1 = List.First;//diem thi
            Node2 = myList.First;

            for (int i = 0; i < List.Count; i++)
            {
                string s = Node1.Value;
                string b = Regex.Replace(s, @"\s{2,}", " ");
                string[] a = b.Split(' ');
                string xeploai = "Trượt     ";
                float tongdiem = float.Parse(a[1]) + float.Parse(a[2]) + float.Parse(a[3]);


                if (Int32.Parse(Node2.Value.Substring(46, 1)) == 1)
                {
                    tongdiem = (tongdiem + 2);
                }
                if (Int32.Parse(Node2.Value.Substring(46, 1)) == 2)
                {
                    tongdiem = (tongdiem + 1);
                }

                float diemthapnhat = float.Parse(a[1]);
                if (float.Parse(a[2]) < diemthapnhat)
                {
                    diemthapnhat = float.Parse(a[2]);
                }
                if (float.Parse(a[3]) < diemthapnhat)
                {
                    diemthapnhat = float.Parse(a[3]);

                }

                if (tongdiem >= 24 && diemthapnhat >= 7)
                {
                    xeploai = "Giỏi      ";
                }
                else
                {
                    if (tongdiem >= 21 && diemthapnhat >= 6)
                    {
                        xeploai = "Khá       ";
                    }
                    else
                    {
                        if (tongdiem >= 15 && diemthapnhat >= 4)
                        {
                            xeploai = "Trung bình";
                        }
                    }

                }

                Diem.AddLast(Node1.Value.Substring(11, 38) + string.Format("{0:0.00}", diemthapnhat).PadRight(13) + string.Format("{0:0.00}", tongdiem).PadRight(13) + xeploai);
                Node1 = Node1.Next;
                Node2 = Node2.Next;
            }
            Linkedlist_to_file(Diem, path + tenfile);

        }
        public void Tat_ca(string namelist)
        {
            string s;
            string b;
            Tinhdiem("Diem_DTN_TD.txt"); //tao ra file Diem_DTN_TD.txt
            list = new LinkedList<string>();
            Diem = new LinkedList<string>();
            myList = new LinkedList<string>();//tat ca

            File_to_linkedlist(list, path + "DanhSach.txt");
            File_to_linkedlist(Diem, path + "Diem_DTN_TD.txt");

            int dem = list.Count;
            Node1 = list.First;//danh sach
            Node2 = Diem.First;//diem

            for (int i = 0; i < dem; i++)
            {
                s = Node1.Value;
                int tuoi = (DateTime.Now.Year - Int32.Parse(s.Substring(s.Length - 8, 4)));
                //add infor into myList
                myList.AddLast(Node1.Value.Substring(0, 32).PadRight(34) + Node1.Value.Substring(33, 1).PadRight(9) + tuoi.ToString().PadRight(9) + Node2.Value.PadRight(76) + s.Substring(s.Length - 3, 3));
                Node1 = Node1.Next;
                Node2 = Node2.Next;
            }
            string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(8) + "Phai".PadRight(9) + "Tuoi".PadRight(9) + "Toan".PadRight(13) + "Van".PadRight(13) + "AnhVan".PadRight(12) + "DTN".PadRight(13) + "TongDiem".PadRight(13) + "XepLoai".PadRight(12) + "DTDT".PadRight(1);
            myList.AddFirst(doituong);
            Linkedlist_to_file(myList, path + namelist);//tao ra fiel tat ca
        }
       


    }

}



