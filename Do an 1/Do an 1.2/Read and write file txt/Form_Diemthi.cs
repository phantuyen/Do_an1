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
    public partial class Form_Diemthi : System.Windows.Forms.Form
    {
        public Form_Diemthi()
        {
            InitializeComponent();
        }
        LinkedList<string> list;
        string path = @"D:\Do an 1\Do an 1.2\Read and write file txt\database\";
        private void Form_Diemthi_Load(object sender, EventArgs e)
        {
            Stream stream = new Stream();
            list = new LinkedList<string>();
            string doituong = "SBD".PadRight(11) + "Toan".PadRight(13) + "Van".PadRight(13) + "AnhVan".PadRight(13);
            list.AddLast(doituong);
            stream.File_to_linkedlist(list, path + "DiemThi.txt");
            int sl = list.Count - 1;
            stream.Linkedlist_to_file(list, path + "dt.txt");
            string text = File.ReadAllText(path + "dt.txt");
            txb_Diemthi.Text = text;
            lbl_Soluong.Text = "Sỉ số: " + sl+" SV";
        }


    }
}
