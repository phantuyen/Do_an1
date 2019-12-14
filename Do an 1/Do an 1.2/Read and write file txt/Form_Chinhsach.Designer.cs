namespace Read_and_write_file_txt
{
    partial class Form_Chinhsach
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
            this.txb_Chinhsach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = " Chính Sách Ưu Tiên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_Chinhsach
            // 
            this.txb_Chinhsach.AcceptsReturn = true;
            this.txb_Chinhsach.AcceptsTab = true;
            this.txb_Chinhsach.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.txb_Chinhsach.AllowDrop = true;
            this.txb_Chinhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Chinhsach.Cursor = System.Windows.Forms.Cursors.Default;
            this.txb_Chinhsach.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Chinhsach.Location = new System.Drawing.Point(12, 54);
            this.txb_Chinhsach.Multiline = true;
            this.txb_Chinhsach.Name = "txb_Chinhsach";
            this.txb_Chinhsach.ReadOnly = true;
            this.txb_Chinhsach.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Chinhsach.Size = new System.Drawing.Size(912, 157);
            this.txb_Chinhsach.TabIndex = 5;
            this.txb_Chinhsach.WordWrap = false;
            // 
            // Form_Chinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(936, 223);
            this.Controls.Add(this.txb_Chinhsach);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Chinhsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Chinhsach";
            this.Load += new System.EventHandler(this.Form_Chinhsach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txb_Chinhsach;
    }
}