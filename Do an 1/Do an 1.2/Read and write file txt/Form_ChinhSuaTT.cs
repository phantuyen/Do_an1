using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

using System.Text.RegularExpressions;


namespace Read_and_write_file_txt
{

    public partial class Form_ChinhsuaTT : System.Windows.Forms.Form
    {

        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        LinkedList<String> myList;
        LinkedList<String> mylist;
        LinkedList<String> List;
        LinkedList<String> list;
        LinkedList<string> DTN;
        LinkedList<string> Tongdiem;
        LinkedListNode<string> Node1;
        LinkedListNode<string> Node2;
        LinkedListNode<string> node;
        Stream stream = new Stream();
        string doituong = "SBD".PadRight(11) + "Ho".PadRight(15) + "Ten".PadRight(11) + "Phai".PadRight(6) + "NgaySinh".PadRight(15) + "DTUT";

        public Form_ChinhsuaTT()
        {
            InitializeComponent();
        }
        public bool Test_textbox(int flag)
        {

           
            if (flag == 1)
            {
                if (txb_SBD.Text == "" ||txb_Ho.Text == "" ||
                txb_Ten.Text == "" ||txb_Phai.Text == "" ||
               txb_Ngaythang.Text == "" ||txb_Dtdt.Text == "" ||
               txb_Toan.Text == "" ||txb_Van.Text == "" ||
               txb_Anhvan.Text == "" ||txb_Find.Text == "")
                {
                    return false;
                }
            }
            if (flag == 2)
            {
                if (txb_SBD.Text == "" ||txb_Ho.Text == "" ||
               txb_Ten.Text == "" ||txb_Phai.Text == "" ||
               txb_Ngaythang.Text == "" ||txb_Dtdt.Text == "" ||
               txb_Toan.Text == "" ||txb_Van.Text == "" ||
               txb_Anhvan.Text == "")
                {
                    return false;
                }

            }
            return true;

        }
        private void Form_Chitiet_Load(object sender, EventArgs e)
        {

            Stream stream = new Stream();
            list = new LinkedList<string>();//danh sach
            mylist = new LinkedList<string>();//danh sach can chinh
            stream.File_to_linkedlist(list, path + "DanhSach.txt");
            int sl = list.Count;
            node = list.First;
            mylist.AddFirst(doituong);

            for (int i = 0; i < list.Count; i++)
            {
                mylist.AddLast(node.Value.Substring(0, 32).PadRight(37) + node.Value.Substring(33, 1).PadRight(6) + node.Value.Substring(35, 10).PadRight(15) + node.Value.Substring(46, 1));
                node = node.Next;
            }

            stream.Linkedlist_to_file(mylist, path + "ds.txt");
            string text = File.ReadAllText(path + "ds.txt");
            txb_Show.Text = text;
            lbl_Thangnam.Text = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            lbl_Siso.Text = "Số lượng: " + sl;


        }
       
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(txb_Find.Text=="")
            {
                MessageBox.Show("Nhập SBD cần Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    stream.Deletes("DanhSach.txt", Int32.Parse(txb_Find.Text));
                    stream.Deletes("DiemThi.txt", Int32.Parse(txb_Find.Text));
                    Form_Chitiet_Load(sender, e);

                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_SBD.Text = "";
                    txb_Ho.Text = "";
                    txb_Ten.Text = "";
                    txb_Phai.Text = "";
                    txb_Ngaythang.Text = "";
                    txb_Dtdt.Text = "";
                    txb_Toan.Text = "";
                    txb_Van.Text = "";
                    txb_Anhvan.Text = "";
                    txb_Find.Text = "";
                    stream.Update(12, "DanhSach[441].txt", "DanhSach.txt");
                    stream.Update(9, "DiemThi[440].txt", "DiemThi.txt");
                }

            }






        }
        void write(int sbd, string vtri)
        {
            int SBD = Int32.Parse(txb_SBD.Text);
            string Ho = txb_Ho.Text.PadRight(15);
            string Ten = txb_Ten.Text.PadRight(7);
            string Phai = txb_Phai.Text.PadRight(2);
            string Ngaysinh = txb_Ngaythang.Text.PadRight(11);
            int DTDT = Int32.Parse(txb_Dtdt.Text);
            stream.Add_Thongtin(SBD, Ho, Ten, Phai, Ngaysinh, DTDT, sbd, vtri);

            float Toan = float.Parse(txb_Toan.Text);
            float Van = float.Parse(txb_Van.Text);
            float Anhvan = float.Parse(txb_Anhvan.Text);
            stream.Add_Diem(SBD, Toan, Van, Anhvan, sbd, vtri);

        }


        private void btn_Themsau_Click(object sender, EventArgs e)
        {
            if(!Test_textbox(1))
            {
                MessageBox.Show("Có ô rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                write(Int32.Parse(txb_Find.Text), "before");
                Form_Chitiet_Load(sender, e);
                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_SBD.Text = "";
                txb_Ho.Text = "";
                txb_Ten.Text = "";
                txb_Phai.Text = "";
                txb_Ngaythang.Text = "";
                txb_Dtdt.Text = "";
                txb_Toan.Text = "";
                txb_Van.Text = "";
                txb_Anhvan.Text = "";
                txb_Find.Text = "";
                stream.Update(12, "DanhSach[441].txt", "DanhSach.txt");
                stream.Update(9, "DiemThi[440].txt", "DiemThi.txt");
            }
            
           
        }

        private void btn_Themtruoc_Click(object sender, EventArgs e)
        {
            if (!Test_textbox(1))
            {
                MessageBox.Show("Có ô rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                write(Int32.Parse(txb_Find.Text), "after");
                Form_Chitiet_Load(sender, e);
                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_SBD.Text = "";
                txb_Ho.Text = "";
                txb_Ten.Text = "";
                txb_Phai.Text = "";
                txb_Ngaythang.Text = "";
                txb_Dtdt.Text = "";
                txb_Toan.Text = "";
                txb_Van.Text = "";
                txb_Anhvan.Text = "";
                txb_Find.Text = "";
                stream.Update(12, "DanhSach[441].txt", "DanhSach.txt");
                stream.Update(9, "DiemThi[440].txt", "DiemThi.txt");
            }
          
        }
        private void btn_Themthongtin_Click(object sender, EventArgs e)
        {
            if (!Test_textbox(2))
            {
                MessageBox.Show("Có ô rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                write(1, "addlast");
                Form_Chitiet_Load(sender, e);
                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_SBD.Text = "";
                txb_Ho.Text = "";
                txb_Ten.Text = "";
                txb_Phai.Text = "";
                txb_Ngaythang.Text = "";
                txb_Dtdt.Text = "";
                txb_Toan.Text = "";
                txb_Van.Text = "";
                txb_Anhvan.Text = "";
                txb_Find.Text = "";
                stream.Update(12, "DanhSach[441].txt", "DanhSach.txt");
                stream.Update(9, "DiemThi[440].txt", "DiemThi.txt");
            }
           
        }


        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (txb_Find.Text == "")
            {
                MessageBox.Show("Mời Nhập SBD cần tìm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                list = new LinkedList<string>();
                stream.File_to_linkedlist(list, path + "DanhSach.txt");
                mylist = new LinkedList<string>();
                mylist.AddLast(doituong);
                Node1 = list.First;
                int i;
                for (i = 0; i < list.Count; i++)
                {
                    if (Int32.Parse(Node1.Value.Substring(0, 11)) == Int32.Parse(txb_Find.Text))
                    {
                        mylist.AddLast(Node1.Value.Substring(0, 32).PadRight(37) + Node1.Value.Substring(33, 1).PadRight(6) + Node1.Value.Substring(35, 10).PadRight(15) + Node1.Value.Substring(46, 1));
                        stream.Linkedlist_to_file(mylist, path + "search.txt");
                        break;
                    }
                    else
                    {
                        Node1 = Node1.Next;
                    }
                }
                if (Node1 == null)
                {
                    MessageBox.Show("Sinh viên không có trong danh sách!!!", "Thông báo");
                }
                else
                {
                    string texts = File.ReadAllText(path + "search.txt");
                    txb_Show.Text = texts;
                }
            }
            
        }

        private void txb_Find_TextChanged(object sender, EventArgs e)
        {
            if (txb_Find.Text == "")
            {
                Form_Chitiet_Load(sender, e);
            }
        }

        private void txb_SBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_SBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txb_Phai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_Dtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_Toan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_Van_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txb_Anhvan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_Find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_Toan_TextChanged(object sender, EventArgs e)
        {
            if(txb_Toan.Text=="")
            {

                lbl_Thongbao.Text = "";
            }
            else
            {
                if (Int32.Parse(txb_Toan.Text) < 0 || Int32.Parse(txb_Toan.Text) > 10)
                {
                    lbl_Thongbao.Text = "(*) 0<=Điêm<=10";
                }
            }
            
        }

        private void txb_Van_TextChanged(object sender, EventArgs e)
        {
            if (txb_Van.Text == "")
            {

                lbl_Thongbao.Text = "";
            }
            else
            {
                if (Int32.Parse(txb_Van.Text) < 0 || Int32.Parse(txb_Van.Text) > 10)
                {
                    lbl_Thongbao.Text = "(*) 0<=Điêm<=10";
                }
            }
        }

        private void txb_Anhvan_TextChanged(object sender, EventArgs e)
        {
            if (txb_Anhvan.Text == "")
            {

                lbl_Thongbao.Text = "";
            }
            else
            {
                if (Int32.Parse(txb_Anhvan.Text) < 0 || Int32.Parse(txb_Anhvan.Text) > 10)
                {
                    lbl_Thongbao.Text = "(*) 0<=Điêm<=10";
                }
            }
        }

        private void txb_Phai_TextChanged(object sender, EventArgs e)
        {
        }

        private void txb_Dtdt_TextChanged(object sender, EventArgs e)
        {
            if (txb_Dtdt.Text == "")
            {

                 lbl_Tb.Text="";
            }
            else
            {
                if (Int32.Parse(txb_Dtdt.Text) < 1 || Int32.Parse(txb_Dtdt.Text) > 3)
                {
                    lbl_Tb.Text = "DTDT: 1, 2 or 3";
                }
            }
        }

        private void txb_Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_Ho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
