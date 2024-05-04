using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TelefonRehberiLocaldbIle.Model;

namespace TelefonRehberiLocaldbIle
{
    public partial class KisiSilmeFormu : Form
    {
        public KisiSilmeFormu()
        {
            InitializeComponent();
        }

        List<Kisi> rehberListesi = new List<Kisi>();
        private void RehberdenSil_Load(object sender, EventArgs e)
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
            if(cmbBx_AdListesi.SelectedIndex > -1)
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

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (cmbBx_AdListesi.SelectedIndex > -1)
            {
                DialogResult dr = MessageBox.Show("Adı: " + txtBx_Ad.Text + "\nSoyadı: " + txtBx_Soyad.Text + "\nTelefonu: " + txtBx_Tel.Text + "\nolan kişiyi silmek istediğinize emin misiniz?", "Silme işlemini onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        KisiVeriErisimKatmani kisiVeriErisimKatmani = new KisiVeriErisimKatmani();
                        kisiVeriErisimKatmani.KisiSil((int)cmbBx_AdListesi.SelectedValue);
                        MessageBox.Show("Silme işlemi tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Silmek için bir ad seçmelisiniz!");
            }
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
