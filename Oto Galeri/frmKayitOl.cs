using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class frmKayitOl : Form
    {
        SqlConnection baglanti;
        String BaglantiStr = "Server=DESKTOP-B8C8LG5\\SQLEXPRESS;Database=OtoGaleriDB;Trusted_Connection=True";
        SqlCommand cmd;
        public frmKayitOl()
        {
            InitializeComponent();
            baglanti = new SqlConnection (BaglantiStr);
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            baglanti.Open ();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into Kullanici" +
                "(KullaniciAdi,Sifre,SifreTekrar,Isim,SoyIsim,EPosta,Telefon) values " +
                "('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "','" + txtSifreTekrar.Text + "','" + txtIsim.Text + "','" + txtSoyIsim.Text + "'," +
                "'" + txtEposta.Text + "','" + maskedTxtTelefon.Text + "')";
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Kayıt Başarılı");
            baglanti.Close ();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
