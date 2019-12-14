using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Read_and_write_file_txt
{
    public partial class Form_Diemthi : Form
    {
        LinkedList<String> myList = new LinkedList<String>();
        LinkedList<String> List = new LinkedList<String>();
        LinkedList<String> list = new LinkedList<String>();
        LinkedList<string> DTN = new LinkedList<string>();
        LinkedList<string> Tongdiem = new LinkedList<string>();

        LinkedListNode<string> Node1;
        LinkedListNode<string> Node2;



        string path = "D:\\Do an 1\\Do an 1.2\\Read and write file txt\\DanhSach[441].txt";
        string path2 = "D:\\Do an 1\\Do an 1.2\\Read and write file txt\\DiemThi[440].txt";



        public Form_Diemthi()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            stream.File_to_linkedlist(myList, path);
            stream.File_to_linkedlist(List, path2);

            int dem = myList.Count - 12;
            Node1 = myList.Last;//danh sach
            Node2 = List.Last; //diem

            for (int i = 0; i < dem; i++)
            {
                string s = Node2.Value;
                string b = Regex.Replace(s, @"\s{2,}", " ");
                string[] a = b.Split(' ');
                float tongdiem = float.Parse(a[1]) + float.Parse(a[2]) + float.Parse(a[3]);
                float diemthapnhat = float.Parse(a[1]);
                if (float.Parse(a[2]) < diemthapnhat)
                {
                    diemthapnhat = float.Parse(a[2]);
                }
                if (float.Parse(a[3]) < diemthapnhat)
                {
                    diemthapnhat = float.Parse(a[3]);

                }
                string s1 = Node1.Value;
                string b1 = Regex.Replace(s1, @"\s{2,}", " ");
                string[] a1 = b1.Split(' ');
                float doi_tuong_ut = float.Parse(a1[6]);
                string xeploai="Trượt";
                if (doi_tuong_ut==1)
                {
                    tongdiem = tongdiem + 2;

                }
                else
                {
                    if (doi_tuong_ut == 2)
                    {
                        tongdiem = tongdiem + 1;
                    }
                }

                if(tongdiem>=24 && diemthapnhat>=7)
                {
                    xeploai = "Giỏi";
                }
                else
                {
                    if (tongdiem >= 21 && diemthapnhat >= 6)
                    {
                        xeploai = "Khá";
                    }
                    else
                    {
                        if (tongdiem >= 15 && diemthapnhat >=4)
                        {
                            xeploai = "Trung bình";
                        }
                    }

                }




                list.AddFirst(Node1.Value.ToString()+ "     " + Node2.Value.ToString().Substring(10, 40) +"       "+ string.Format("{0:0.00}", diemthapnhat) + "       "  + string.Format("{0:0.00}", tongdiem) +"     "+xeploai);
                Node1 = Node1.Previous;
                Node2 = Node2.Previous;
                


            }


            stream.linkedlist_to_file(list, @"D:\Do an 1\Do an 1.2\Read and write file txt\Tonghop.txt");
            StreamReader streamReader = new StreamReader(@"D:\Do an 1\Do an 1.2\Read and write file txt\Tonghop.txt");
            txb_Show.Text = streamReader.ReadToEnd();
            streamReader.Close();

            //string s = Node2.Value;
            //string b = Regex.Replace(s, @"\s{2,}", " ");
            //string[] a = b.Split(' ');
            //float d = float.Parse("8.99");

            //txb_Show.Text = "" + d;



            //int tuoi = DateTime.Now.Year;
            //DateTime nam = Convert.ToDateTime(a[5]);
            //txb_Show.Text = (tuoi-nam.Year).ToString();

          
        


            //StreamReader streamReader = new StreamReader(path);
            //txb_Show.Text = streamReader.ReadToEnd();
            //streamReader.Close();
            //  stream.LayID(myList, @"D:\Do an 1\Do an 1.2\Read and write file txt\Doituong.txt");
            //stream.linkedlist_to_file(List, @"D:\Do an 1\Do an 1.2\Read and write file txt\Doituong.txt");
            //StreamReader streamReader = new StreamReader(@"D:\Do an 1\Do an 1.2\Read and write file txt\Doituong.txt");
            //txb_Show.Text = streamReader.ReadToEnd();
            //streamReader.Close();
            //stream.File_to_linkedlist(List, @"D:\Do an 1\Do an 1.2\Read and write file txt\Doituong.txt");
            //label7.Text = List.Count.ToString();


        }
        Stream stream = new Stream();




        







        private void Btb_Read_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

             stream.Delete(stream.Findvtri(txb_Vitrixoa.Text));

        }
        void write(string s)
        {
            int SBD = Int32.Parse(txb_SBD.Text);
            string Ho = txb_Ho.Text.PadRight(15);
            string Ten = txb_Ten.Text.PadRight(7);
            string Phai = txb_Phai.Text.PadRight(2);
            string Ngaysinh = dtime_Ngaysinh.Text.PadRight(11);
            int DTDT = Int32.Parse(txb_Dtdt.Text);
            stream.Add(SBD, Ho, Ten, Phai, Ngaysinh, DTDT, s);
        }
        private void btn_Writefirst_Click_1(object sender, EventArgs e)
        {
            write("First");
        }
        private void btn_Writelast_Click(object sender, EventArgs e)
        {
            write("Last");
        }
        private void btn_Find_Click(object sender, EventArgs e)
        {

            stream.File_to_linkedlist(myList, path);
            int count = myList.Count;
            LinkedList<string> list = new LinkedList<string>();
            int sbd = Int32.Parse(txb_Find.Text);
            LinkedListNode<string> node = myList.First;
            int i = 0;
            while (i < count)
            {
                int SBD = Int32.Parse(node.Value.Substring(0, 11));
                if (sbd == SBD)
                {
                    txb_Show.Text = node.Value;
                    break;
                }
                node = node.Next;
            }


        }
        
        private void txb_Find_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void btn_Themsau_Click(object sender, EventArgs e)
        {
            stream.File_to_linkedlist(myList, path);
            LinkedListNode<string> node = myList.First;
            txb_Show.Text = node.Next.Value;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
