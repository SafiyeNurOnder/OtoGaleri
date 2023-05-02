using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Oto_Galeri
{
    public partial class frmMusteriEkle : Form
    {
        SqlConnection baglanti;
        string baglantiStr = "Server=DESKTOP-B8C8LG5\\SQLEXPRESS;Database=OtoGaleriDB;Trusted_Connection=True;";
        SqlCommand cmd;
        public frmMusteriEkle()
        {
            InitializeComponent();
            baglanti = new SqlConnection(baglantiStr);
        }

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into Musteri" +
                "(TCKimlikNo,Isim,SoyIsim,Telefon,EPosta,Adres) values " +
                "(" + txtTcNo.Text + ",'" + txtAd.Text + "','" + txtSoyad.Text + "','" + maskedTxtTelefon.Text + "'" +
                ",'" + txtEPosta.Text + "','" + TxtAdres.Text + "')";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            var frm = new frmMusteriListesi();
            frm.Show();
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
