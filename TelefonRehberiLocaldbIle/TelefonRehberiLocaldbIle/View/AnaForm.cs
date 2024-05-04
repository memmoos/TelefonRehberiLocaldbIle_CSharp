using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberiLocaldbIle
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            KisiEklemeFormu rEkle = new KisiEklemeFormu();
            rEkle.StartPosition = FormStartPosition.CenterParent;
            rEkle.ShowDialog();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            KisiSilmeFormu rSil = new KisiSilmeFormu();
            rSil.StartPosition = FormStartPosition.CenterParent;
            rSil.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            KisiDuzenlemeFormu rGuncelle = new KisiDuzenlemeFormu();
            rGuncelle.StartPosition = FormStartPosition.CenterParent;
            rGuncelle.ShowDialog();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            KisiListelemeFormu rListele = new KisiListelemeFormu();
            rListele.StartPosition = FormStartPosition.CenterParent;
            rListele.ShowDialog();
        }
    }
}
