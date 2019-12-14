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

namespace Read_and_write_file_txt
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        Stream stream = new Stream();
        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        private void btn_DanhsachSV_Click(object sender, EventArgs e)
        {
            Form frm = new Form_Danhsach();
            if (!CheckExitForm("Form_Danhsach"))
            {
               
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
              
                ActiveChildrentForm("Form_Danhsach");
            }
        }

  
        private void btn_ThemXoa_Click(object sender, EventArgs e)
        {

            if (!CheckExitForm("Form_ChinhsuaTT"))
            {
                Form frm = new Form_ChinhsuaTT();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildrentForm("Form_ChinhsuaTT");

            }
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            BackColor = Color.BurlyWood;
            stream.Tat_ca("Tatca.txt");
            stream.Chuyen_CSDL(12, "DanhSach[441].txt", "DanhSach.txt");
            stream.Chuyen_CSDL(9, "DiemThi[440].txt", "DiemThi.txt");
            stream.Chuyen_CSDL(9, "ChiTietDT[439].txt", "ChinhSach.txt");
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.DodgerBlue;
                }
            }
        }
        private void btn_ChinhsachUT_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("Form_Chinhsach"))
            {
                Form frm = new Form_Chinhsach();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildrentForm("Form_Chinhsach");
            }
        }
        private bool CheckExitForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name==name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildrentForm(string name)
        {
            foreach  (Form frm in this.MdiChildren)
            {
                if(frm.Name==name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void btn_XeploaiSV_Click(object sender, EventArgs e)
        {
            
            if (!CheckExitForm("Form_Xeploai"))
            {
                Form frm = new Form_Xeploai();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildrentForm("Form_Xeploai");

            }
        }

        private void btn_Diem_Click(object sender, EventArgs e)
        {
            

            Form frm = new Form_Diemthi();
            if (!CheckExitForm("Form_Diemthi"))
            {
                
                frm.MdiParent = this;
                frm.Show();
                
                
            }
            else
            {
               
               ActiveChildrentForm("Form_Diemthi");

            }
        }

        private void btn_Doituongduthi_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("Form_Doituongduthi"))
            {
                Form frm = new Form_Doituongduthi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildrentForm("Form_Doituongduthi");


            }
        }

      

        private void btn_Baodiem_Click(object sender, EventArgs e)
        {
            Form_Baodiem frm = new Form_Baodiem();
            if (!CheckExitForm("Form_Baodiem"))
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildrentForm("Form_Baodiem");
            }
        }

    }
}
