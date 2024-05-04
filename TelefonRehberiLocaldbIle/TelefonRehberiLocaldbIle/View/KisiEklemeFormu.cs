using System;
using System.Windows.Forms;
using TelefonRehberiLocaldbIle.Model;

namespace TelefonRehberiLocaldbIle
{
    public partial class KisiEklemeFormu : Form
    {
        public KisiEklemeFormu()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txtBx_Ad.TextLength > 0 && txtBx_Soyad.TextLength > 0 && txtBx_Tel.TextLength > 0)
            {
                try
                {
                    Kisi eklenecekKisi = new Kisi(txtBx_Ad.Text, txtBx_Soyad.Text, txtBx_Tel.Text);
                    KisiVeriErisimKatmani kisiVeriErisimKatmani = new KisiVeriErisimKatmani();
                    kisiVeriErisimKatmani.KisiEkle(eklenecekKisi);
                    DialogResult dr = MessageBox.Show("Rehbere kayıt eklendi, yeni kayıt eklemeğe devam etmek ister misiniz?", "Ekleme Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {                       
                        txtBx_Ad.Text = "";                        
                        txtBx_Soyad.Text = "";
                        txtBx_Tel.Text = "";
                        txtBx_Ad.Select();
                    }
                    else
                    {
                        Close();
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ad, Soyad ve Telefon alanlarının tümü gerekli alanlardır, boş geçilemezler!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
