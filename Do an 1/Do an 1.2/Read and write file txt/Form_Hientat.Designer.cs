namespace Read_and_write_file_txt
{
    partial class Form_Hientat
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
            this.txb_Hientat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_Hientat
            // 
            this.txb_Hientat.Location = new System.Drawing.Point(12, 12);
            this.txb_Hientat.Multiline = true;
            this.txb_Hientat.Name = "txb_Hientat";
            this.txb_Hientat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Hientat.Size = new System.Drawing.Size(847, 472);
            this.txb_Hientat.TabIndex = 0;
            // 
            // Form_Hientat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 496);
            this.Controls.Add(this.txb_Hientat);
            this.Name = "Form_Hientat";
            this.Text = "Form_Hientat";
            this.Load += new System.EventHandler(this.Form_Hientat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Hientat;
    }
}