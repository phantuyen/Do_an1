namespace Read_and_write_file_txt
{
    partial class Form_Baodiem
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
            this.txb_Baodiem = new System.Windows.Forms.TextBox();
            this.lbl_Siso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(474, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giấy Báo Điểm";
            // 
            // txb_Baodiem
            // 
            this.txb_Baodiem.AcceptsReturn = true;
            this.txb_Baodiem.AcceptsTab = true;
            this.txb_Baodiem.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.txb_Baodiem.AllowDrop = true;
            this.txb_Baodiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Baodiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.txb_Baodiem.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Baodiem.Location = new System.Drawing.Point(12, 59);
            this.txb_Baodiem.Multiline = true;
            this.txb_Baodiem.Name = "txb_Baodiem";
            this.txb_Baodiem.ReadOnly = true;
            this.txb_Baodiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_Baodiem.Size = new System.Drawing.Size(1031, 488);
            this.txb_Baodiem.TabIndex = 10;
            this.txb_Baodiem.WordWrap = false;
            // 
            // lbl_Siso
            // 
            this.lbl_Siso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Siso.AutoSize = true;
            this.lbl_Siso.BackColor = System.Drawing.Color.Pink;
            this.lbl_Siso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Siso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Siso.ForeColor = System.Drawing.Color.Black;
            this.lbl_Siso.Location = new System.Drawing.Point(42, 30);
            this.lbl_Siso.Name = "lbl_Siso";
            this.lbl_Siso.Size = new System.Drawing.Size(80, 26);
            this.lbl_Siso.TabIndex = 11;
            this.lbl_Siso.Text = "soluong";
            // 
            // Form_Baodiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1055, 559);
            this.Controls.Add(this.lbl_Siso);
            this.Controls.Add(this.txb_Baodiem);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Baodiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Baodiem";
            this.Load += new System.EventHandler(this.Form_Baodiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txb_Baodiem;
        private System.Windows.Forms.Label lbl_Siso;
    }
}