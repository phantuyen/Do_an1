using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Read_and_write_file_txt
{
    public partial class Form_Hientat : Form
    {
        public Form_Hientat()
        {
            InitializeComponent();
        }
        Stream stream=new Stream();
        LinkedList<String> myList = new LinkedList<String>();
        string path = "D:\\Do an 1\\Read and write file txt\\";// text.txt";

        private void Form_Hientat_Load(object sender, EventArgs e)
        {
            stream.File_to_linkedlist(myList, path+ "DanhSach[441].txt");
            stream.File_to_linkedlist(myList, path + "ChiTietDT[439].txt");
            stream.File_to_linkedlist(myList, path + "DiemThi[440].txt");
            stream.linkedlist_to_file(myList, path + "Tonghop.txt");
            StreamReader streamReader = new StreamReader(path+"Tonghop.txt");           
            txb_Hientat.Text = streamReader.ReadToEnd();
            streamReader.Close();
           
        }
    }
}
