﻿namespace Read_and_write_file_txt
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
            this.txb_Diemthi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Soluong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Diemthi
            // 
            this.txb_Diemthi.AcceptsReturn = true;
            this.txb_Diemthi.AcceptsTab = true;
            this.txb_Diemthi.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.txb_Diemthi.AllowDrop = true;
            this.txb_Diemthi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Diemthi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txb_Diemthi.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Diemthi.Location = new System.Drawing.Point(12, 58);
            this.txb_Diemthi.Multiline = true;
            this.txb_Diemthi.Name = "txb_Diemthi";
            this.txb_Diemthi.ReadOnly = true;
            this.txb_Diemthi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Diemthi.Size = new System.Drawing.Size(635, 429);
            this.txb_Diemthi.TabIndex = 4;
            this.txb_Diemthi.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Điểm Thi ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Soluong
            // 
            this.lbl_Soluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Soluong.AutoSize = true;
            this.lbl_Soluong.BackColor = System.Drawing.Color.White;
            this.lbl_Soluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Soluong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Soluong.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Soluong.Location = new System.Drawing.Point(507, 29);
            this.lbl_Soluong.Name = "lbl_Soluong";
            this.lbl_Soluong.Size = new System.Drawing.Size(102, 26);
            this.lbl_Soluong.TabIndex = 5;
            this.lbl_Soluong.Text = "Số lượng:";
            this.lbl_Soluong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_Diemthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(659, 499);
            this.Controls.Add(this.lbl_Soluong);
            this.Controls.Add(this.txb_Diemthi);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Diemthi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm Thi";
            this.Load += new System.EventHandler(this.Form_Diemthi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txb_Diemthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Soluong;
    }
}