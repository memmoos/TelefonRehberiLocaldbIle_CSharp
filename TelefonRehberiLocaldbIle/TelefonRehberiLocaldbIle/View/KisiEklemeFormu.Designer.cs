namespace TelefonRehberiLocaldbIle
{
    partial class KisiEklemeFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiEklemeFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_Ad = new System.Windows.Forms.TextBox();
            this.txtBx_Soyad = new System.Windows.Forms.TextBox();
            this.txtBx_Tel = new System.Windows.Forms.TextBox();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TELEFON :";
            // 
            // txtBx_Ad
            // 
            this.txtBx_Ad.Location = new System.Drawing.Point(91, 10);
            this.txtBx_Ad.Name = "txtBx_Ad";
            this.txtBx_Ad.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Ad.TabIndex = 0;
            // 
            // txtBx_Soyad
            // 
            this.txtBx_Soyad.Location = new System.Drawing.Point(91, 36);
            this.txtBx_Soyad.Name = "txtBx_Soyad";
            this.txtBx_Soyad.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Soyad.TabIndex = 1;
            // 
            // txtBx_Tel
            // 
            this.txtBx_Tel.Location = new System.Drawing.Point(91, 62);
            this.txtBx_Tel.Name = "txtBx_Tel";
            this.txtBx_Tel.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Tel.TabIndex = 2;
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Vazgec.Location = new System.Drawing.Point(116, 88);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(75, 23);
            this.btn_Vazgec.TabIndex = 4;
            this.btn_Vazgec.Text = "İPTAL";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(12, 88);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // RehbereEkle
            // 
            this.AcceptButton = this.btn_Ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Vazgec;
            this.ClientSize = new System.Drawing.Size(203, 120);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.txtBx_Tel);
            this.Controls.Add(this.txtBx_Soyad);
            this.Controls.Add(this.txtBx_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RehbereEkle";
            this.Text = "RehbereEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_Ad;
        private System.Windows.Forms.TextBox txtBx_Soyad;
        private System.Windows.Forms.TextBox txtBx_Tel;
        private System.Windows.Forms.Button btn_Vazgec;
        private System.Windows.Forms.Button btn_Ekle;
    }
}