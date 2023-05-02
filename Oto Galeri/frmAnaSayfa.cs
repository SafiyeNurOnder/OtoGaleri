using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Hide(); // yeni forma geçerken öncekini kapattı, anasayfadan giriş ekranına dönüş
            frmGiris girisForm = new frmGiris();
            girisForm.Show();
        }
        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            frmMusteriListesi musteriListesi = new frmMusteriListesi();
            musteriListesi.Show();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            frmAracEkle aracEkle = new frmAracEkle();
            aracEkle.Show();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            frmAracListesi aracListesi = new frmAracListesi();
            aracListesi.Show();
            
        }

        private void btnSatısKayıtları_Click(object sender, EventArgs e)
        {
            frmSatisKayitlari satisKayitlari = new frmSatisKayitlari();
            satisKayitlari.Show();
        }
    }
}
