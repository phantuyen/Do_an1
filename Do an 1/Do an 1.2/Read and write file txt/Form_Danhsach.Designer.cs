namespace Read_and_write_file_txt
{
    partial class Form_Danhsach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Danhsach = new System.Windows.Forms.TextBox();
            this.lbl_Soluong = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.txb_Danhsach.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Danhsach.Location = new System.Drawing.Point(12, 54);
            this.txb_Danhsach.Multiline = true;
            this.txb_Danhsach.Name = "txb_Danhsach";
            this.txb_Danhsach.ReadOnly = true;
            this.txb_Danhsach.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Danhsach.Size = new System.Drawing.Size(844, 372);
            this.txb_Danhsach.TabIndex = 2;
            this.txb_Danhsach.WordWrap = false;
            // 
            // lbl_Soluong
            // 
            this.lbl_Soluong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Soluong.AutoSize = true;
            this.lbl_Soluong.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Soluong.Location = new System.Drawing.Point(353, 443);
            this.lbl_Soluong.Name = "lbl_Soluong";
            this.lbl_Soluong.Size = new System.Drawing.Size(94, 24);
            this.lbl_Soluong.TabIndex = 3;
            this.lbl_Soluong.Text = "So luong";
            // 
            // Form_Danhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(868, 489);
            this.Controls.Add(this.lbl_Soluong);
            this.Controls.Add(this.txb_Danhsach);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Danhsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách";
            this.Load += new System.EventHandler(this.Form_Danhsach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txb_Danhsach;
        private System.Windows.Forms.Label lbl_Soluong;
    }
}