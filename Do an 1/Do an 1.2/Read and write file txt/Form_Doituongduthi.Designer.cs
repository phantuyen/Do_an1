namespace Read_and_write_file_txt
{
    partial class Form_Doituongduthi
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
            this.lbl_Truot = new System.Windows.Forms.Label();
            this.txb_Doituongduthi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Soluong = new System.Windows.Forms.Label();
            this.txb_Danhsach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Dau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Truot
            // 
            this.lbl_Truot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Truot.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Truot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Truot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Truot.Location = new System.Drawing.Point(321, 518);
            this.lbl_Truot.Name = "lbl_Truot";
            this.lbl_Truot.Size = new System.Drawing.Size(214, 24);
            this.lbl_Truot.TabIndex = 14;
            this.lbl_Truot.Text = "Truot                     ";
            // 
            // txb_Doituongduthi
            // 
            this.txb_Doituongduthi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Doituongduthi.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.txb_Doituongduthi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txb_Doituongduthi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txb_Doituongduthi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Doituongduthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Doituongduthi.Location = new System.Drawing.Point(918, 33);
            this.txb_Doituongduthi.Multiline = true;
            this.txb_Doituongduthi.Name = "txb_Doituongduthi";
            this.txb_Doituongduthi.Size = new System.Drawing.Size(63, 25);
            this.txb_Doituongduthi.TabIndex = 12;
            this.txb_Doituongduthi.TextChanged += new System.EventHandler(this.txb_Doituongduthi_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(778, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đối tượng DT:";
            // 
            // lbl_Soluong
            // 
            this.lbl_Soluong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Soluong.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Soluong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Soluong.Location = new System.Drawing.Point(321, 470);
            this.lbl_Soluong.Name = "lbl_Soluong";
            this.lbl_Soluong.Size = new System.Drawing.Size(214, 24);
            this.lbl_Soluong.TabIndex = 10;
            this.lbl_Soluong.Text = "So luong               ";
            // 
            // txb_Danhsach
            // 
            this.txb_Danhsach.AcceptsReturn = true;
            this.txb_Danhsach.AcceptsTab = true;
            this.txb_Danhsach.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.txb_Danhsach.AllowDrop = true;
            this.txb_Danhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Danhsach.Cursor = System.Windows.Forms.Cursors.Default;
            this.txb_Danhsach.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Danhsach.Location = new System.Drawing.Point(21, 59);
            this.txb_Danhsach.Multiline = true;
            this.txb_Danhsach.Name = "txb_Danhsach";
            this.txb_Danhsach.ReadOnly = true;
            this.txb_Danhsach.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Danhsach.Size = new System.Drawing.Size(986, 392);
            this.txb_Danhsach.TabIndex = 9;
            this.txb_Danhsach.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Dau
            // 
            this.lbl_Dau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Dau.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Dau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dau.Location = new System.Drawing.Point(321, 494);
            this.lbl_Dau.Name = "lbl_Dau";
            this.lbl_Dau.Size = new System.Drawing.Size(214, 24);
            this.lbl_Dau.TabIndex = 15;
            this.lbl_Dau.Text = "Dau                       ";
            // 
            // Form_Doituongduthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1029, 560);
            this.Controls.Add(this.lbl_Dau);
            this.Controls.Add(this.lbl_Truot);
            this.Controls.Add(this.txb_Doituongduthi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Soluong);
            this.Controls.Add(this.txb_Danhsach);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Doituongduthi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đối Tượng Dự Thi";
            this.Load += new System.EventHandler(this.Form_Doituongduthi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Truot;
        private System.Windows.Forms.TextBox txb_Doituongduthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Soluong;
        internal System.Windows.Forms.TextBox txb_Danhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Dau;
    }
}