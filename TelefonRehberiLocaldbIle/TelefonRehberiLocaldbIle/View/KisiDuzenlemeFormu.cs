using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TelefonRehberiLocaldbIle.Model;

namespace TelefonRehberiLocaldbIle
{
    public partial class KisiDuzenlemeFormu : Form
    {
        public KisiDuzenlemeFormu()
        {
            InitializeComponent();
        }

        List<Kisi> rehberListesi = new List<Kisi>();

        private void RehberiGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                KisiVeriErisimKatmani kisiVeriErisimKatmani = new KisiVeriErisimKatmani();
                rehberListesi = kisiVeriErisimKatmani.TumKisileriGetir();
                if (rehberListesi.Count > 0)
                {
                    cmbBx_AdListesi.DisplayMember = "Ad";
                    cmbBx_AdListesi.ValueMember = "Id";
                    cmbBx_AdListesi.DataSource = new BindingSource(rehberListesi, null);
                }
                else
                {
                    MessageBox.Show("Rehber listesi boş", "Kayıt yok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void cmbBx_AdListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBx_AdListesi.SelectedIndex > -1)
            {
                try
                {
                    txtBx_Ad.Text = rehberListesi[(int)cmbBx_AdListesi.SelectedIndex].Ad;
                    txtBx_Soyad.Text = rehberListesi[(int)cmbBx_AdListesi.SelectedIndex].Soyad;
                    txtBx_Tel.Text = rehberListesi[(int)cmbBx_AdListesi.SelectedIndex].Telefon;
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (cmbBx_AdListesi.SelectedIndex > -1)
            {
                DialogResult dr = MessageBox.Show("Adı: " + txtBx_Ad.Text + "\nSoyadı: " + txtBx_Soyad.Text + "\nTelefonu: " + txtBx_Tel.Text + "\n şeklinde güncellemek istediğinize emin misiniz?", "Güncelleme işlemini onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        KisiVeriErisimKatmani kisiVeriErisimKatmani = new KisiVeriErisimKatmani();
                        Kisi guncellenecekKisi = new Kisi((int)cmbBx_AdListesi.SelectedValue, txtBx_Ad.Text, txtBx_Soyad.Text, txtBx_Tel.Text);
                        kisiVeriErisimKatmani.KisiGuncelle(guncellenecekKisi);
                        MessageBox.Show("Güncelleme işlemi tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir ad seçmelisiniz!");
            }
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
