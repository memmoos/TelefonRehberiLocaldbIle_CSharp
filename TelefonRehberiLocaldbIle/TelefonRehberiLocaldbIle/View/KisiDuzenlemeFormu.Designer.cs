namespace TelefonRehberiLocaldbIle
{
    partial class KisiDuzenlemeFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiDuzenlemeFormu));
            this.cmbBx_AdListesi = new System.Windows.Forms.ComboBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.txtBx_Tel = new System.Windows.Forms.TextBox();
            this.txtBx_Soyad = new System.Windows.Forms.TextBox();
            this.txtBx_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBx_AdListesi
            // 
            this.cmbBx_AdListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_AdListesi.FormattingEnabled = true;
            this.cmbBx_AdListesi.Location = new System.Drawing.Point(112, 6);
            this.cmbBx_AdListesi.Name = "cmbBx_AdListesi";
            this.cmbBx_AdListesi.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_AdListesi.TabIndex = 0;
            this.cmbBx_AdListesi.SelectedIndexChanged += new System.EventHandler(this.cmbBx_AdListesi_SelectedIndexChanged);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(12, 116);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Vazgec.Location = new System.Drawing.Point(158, 116);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(75, 23);
            this.btn_Vazgec.TabIndex = 5;
            this.btn_Vazgec.Text = "İPTAL";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // txtBx_Tel
            // 
            this.txtBx_Tel.Location = new System.Drawing.Point(112, 90);
            this.txtBx_Tel.Name = "txtBx_Tel";
            this.txtBx_Tel.Size = new System.Drawing.Size(121, 20);
            this.txtBx_Tel.TabIndex = 3;
            // 
            // txtBx_Soyad
            // 
            this.txtBx_Soyad.Location = new System.Drawing.Point(112, 64);
            this.txtBx_Soyad.Name = "txtBx_Soyad";
            this.txtBx_Soyad.Size = new System.Drawing.Size(121, 20);
            this.txtBx_Soyad.TabIndex = 2;
            // 
            // txtBx_Ad
            // 
            this.txtBx_Ad.Location = new System.Drawing.Point(112, 38);
            this.txtBx_Ad.Name = "txtBx_Ad";
            this.txtBx_Ad.Size = new System.Drawing.Size(121, 20);
            this.txtBx_Ad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TELEFON :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADA GÖRE ARA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AD :";
            // 
            // RehberiGuncelle
            // 
            this.AcceptButton = this.btn_Guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Vazgec;
            this.ClientSize = new System.Drawing.Size(245, 157);
            this.Controls.Add(this.cmbBx_AdListesi);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.txtBx_Tel);
            this.Controls.Add(this.txtBx_Soyad);
            this.Controls.Add(this.txtBx_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RehberiGuncelle";
            this.Text = "Rehberi Güncelle";
            this.Load += new System.EventHandler(this.RehberiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBx_AdListesi;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Vazgec;
        private System.Windows.Forms.TextBox txtBx_Tel;
        private System.Windows.Forms.TextBox txtBx_Soyad;
        private System.Windows.Forms.TextBox txtBx_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}