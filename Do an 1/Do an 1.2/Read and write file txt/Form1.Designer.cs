namespace Read_and_write_file_txt
{
    partial class Form_Diemthi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btb_Read = new System.Windows.Forms.Button();
            this.txb_Show = new System.Windows.Forms.TextBox();
            this.txb_SBD = new System.Windows.Forms.TextBox();
            this.btn_Writefirst = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Ho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Phai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Dtdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtime_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Writelast = new System.Windows.Forms.Button();
            this.txb_Vitrixoa = new System.Windows.Forms.TextBox();
            this.txb_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Themsau = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btb_Read
            // 
            this.btb_Read.Location = new System.Drawing.Point(123, 278);
            this.btb_Read.Name = "btb_Read";
            this.btb_Read.Size = new System.Drawing.Size(75, 23);
            this.btb_Read.TabIndex = 0;
            this.btb_Read.Text = "Read";
            this.btb_Read.UseVisualStyleBackColor = true;
            this.btb_Read.Click += new System.EventHandler(this.Btb_Read_Click);
            // 
            // txb_Show
            // 
            this.txb_Show.AcceptsReturn = true;
            this.txb_Show.AcceptsTab = true;
            this.txb_Show.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.txb_Show.AllowDrop = true;
            this.txb_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Show.Cursor = System.Windows.Forms.Cursors.Default;
            this.txb_Show.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Show.Location = new System.Drawing.Point(432, 10);
            this.txb_Show.Multiline = true;
            this.txb_Show.Name = "txb_Show";
            this.txb_Show.ReadOnly = true;
            this.txb_Show.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Show.Size = new System.Drawing.Size(399, 311);
            this.txb_Show.TabIndex = 1;
            this.txb_Show.WordWrap = false;
            // 
            // txb_SBD
            // 
            this.txb_SBD.Location = new System.Drawing.Point(73, 15);
            this.txb_SBD.Name = "txb_SBD";
            this.txb_SBD.Size = new System.Drawing.Size(133, 20);
            this.txb_SBD.TabIndex = 2;
            // 
            // btn_Writefirst
            // 
            this.btn_Writefirst.Location = new System.Drawing.Point(41, 241);
            this.btn_Writefirst.Name = "btn_Writefirst";
            this.btn_Writefirst.Size = new System.Drawing.Size(75, 23);
            this.btn_Writefirst.TabIndex = 3;
            this.btn_Writefirst.Text = "WriteFirst";
            this.btn_Writefirst.UseVisualStyleBackColor = true;
            this.btn_Writefirst.Click += new System.EventHandler(this.btn_Writefirst_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(122, 241);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SBD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ:";
            // 
            // txb_Ho
            // 
            this.txb_Ho.Location = new System.Drawing.Point(73, 53);
            this.txb_Ho.Name = "txb_Ho";
            this.txb_Ho.Size = new System.Drawing.Size(133, 20);
            this.txb_Ho.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên:";
            // 
            // txb_Ten
            // 
            this.txb_Ten.Location = new System.Drawing.Point(73, 91);
            this.txb_Ten.Name = "txb_Ten";
            this.txb_Ten.Size = new System.Drawing.Size(133, 20);
            this.txb_Ten.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phái:";
            // 
            // txb_Phai
            // 
            this.txb_Phai.Location = new System.Drawing.Point(73, 126);
            this.txb_Phai.Name = "txb_Phai";
            this.txb_Phai.Size = new System.Drawing.Size(133, 20);
            this.txb_Phai.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày sinh:";
            // 
            // txb_Dtdt
            // 
            this.txb_Dtdt.Location = new System.Drawing.Point(73, 200);
            this.txb_Dtdt.Name = "txb_Dtdt";
            this.txb_Dtdt.Size = new System.Drawing.Size(133, 20);
            this.txb_Dtdt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "DTDT:";
            // 
            // dtime_Ngaysinh
            // 
            this.dtime_Ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtime_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_Ngaysinh.Location = new System.Drawing.Point(73, 162);
            this.dtime_Ngaysinh.Name = "dtime_Ngaysinh";
            this.dtime_Ngaysinh.Size = new System.Drawing.Size(136, 20);
            this.dtime_Ngaysinh.TabIndex = 23;
            // 
            // btn_Writelast
            // 
            this.btn_Writelast.Location = new System.Drawing.Point(42, 278);
            this.btn_Writelast.Name = "btn_Writelast";
            this.btn_Writelast.Size = new System.Drawing.Size(75, 23);
            this.btn_Writelast.TabIndex = 25;
            this.btn_Writelast.Text = "WriteLast";
            this.btn_Writelast.UseVisualStyleBackColor = true;
            this.btn_Writelast.Click += new System.EventHandler(this.btn_Writelast_Click);
            // 
            // txb_Vitrixoa
            // 
            this.txb_Vitrixoa.Location = new System.Drawing.Point(203, 241);
            this.txb_Vitrixoa.Name = "txb_Vitrixoa";
            this.txb_Vitrixoa.Size = new System.Drawing.Size(70, 20);
            this.txb_Vitrixoa.TabIndex = 26;
            // 
            // txb_Find
            // 
            this.txb_Find.Location = new System.Drawing.Point(293, 55);
            this.txb_Find.Name = "txb_Find";
            this.txb_Find.Size = new System.Drawing.Size(133, 20);
            this.txb_Find.TabIndex = 28;
            this.txb_Find.TextChanged += new System.EventHandler(this.txb_Find_TextChanged);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(212, 55);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 27;
            this.btn_Find.Text = "Find:";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "label7";
            // 
            // btn_Themsau
            // 
            this.btn_Themsau.Location = new System.Drawing.Point(212, 278);
            this.btn_Themsau.Name = "btn_Themsau";
            this.btn_Themsau.Size = new System.Drawing.Size(101, 23);
            this.btn_Themsau.TabIndex = 29;
            this.btn_Themsau.Text = "Them sau SBD:";
            this.btn_Themsau.UseVisualStyleBackColor = true;
            this.btn_Themsau.Click += new System.EventHandler(this.btn_Themsau_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Diemthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Themsau);
            this.Controls.Add(this.txb_Find);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txb_Vitrixoa);
            this.Controls.Add(this.btn_Writelast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtime_Ngaysinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Dtdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Phai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Ho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Writefirst);
            this.Controls.Add(this.txb_SBD);
            this.Controls.Add(this.txb_Show);
            this.Controls.Add(this.btb_Read);
            this.Name = "Form_Diemthi";
            this.Text = "Form_Diemthi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btb_Read;
        private System.Windows.Forms.TextBox txb_SBD;
        private System.Windows.Forms.Button btn_Writefirst;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Ho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Phai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Dtdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtime_Ngaysinh;
        private System.Windows.Forms.Button btn_Writelast;
        internal System.Windows.Forms.TextBox txb_Show;
        public System.Windows.Forms.TextBox txb_Vitrixoa;
        public System.Windows.Forms.TextBox txb_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Themsau;
        private System.Windows.Forms.Button button1;
    }
}

