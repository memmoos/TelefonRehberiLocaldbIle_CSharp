using System;
using System.Windows.Forms;
using System.Collections.Generic;
using TelefonRehberiLocaldbIle.Model;

namespace TelefonRehberiLocaldbIle
{
    public partial class KisiListelemeFormu : Form
    {
        public KisiListelemeFormu()
        {
            InitializeComponent();
        }

        private void RehberiListele_Load(object sender, EventArgs e)
        {             
            try
            {
                KisiVeriErisimKatmani kisiVeriErisimKatmani = new KisiVeriErisimKatmani();
                List<Kisi> rehberListesi = kisiVeriErisimKatmani.TumKisileriGetir();
                if (rehberListesi.Count > 0)
                {
                    dataGridView1.DataSource = rehberListesi;
                    dataGridView1.Columns[0].Visible = false;
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
    }
}
