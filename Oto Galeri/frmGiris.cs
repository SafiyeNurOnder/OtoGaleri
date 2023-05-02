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
    public partial class frmGiris : Form
    {
        SqlConnection baglanti;
        string baglantiStr = "Server=DESKTOP-B8C8LG5\\SQLEXPRESS;Database=OtoGaleriDB;Trusted_Connection=True;";
        SqlCommand cmd;
        public frmGiris()
        {
            InitializeComponent();
            baglanti = new SqlConnection(baglantiStr);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;


            if(kullaniciAdi!="" && sifre != "")
            {
                cmd = new SqlCommand();
                baglanti.Open();
                cmd.Connection = baglanti;  
                cmd.CommandText = $"Select * From Kullanici where KullaniciAdi='{kullaniciAdi}' and Sifre='{sifre}'";
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide(); // yeni forma geçerken diğerini kapatıyor
                    frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
                    frmAnaSayfa.ShowDialog();

                }
                else{
                    MessageBox.Show("Kullanıcı adı veya şifre geçersiz. !");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz !");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKayitOl kayitOl = new frmKayitOl();
            kayitOl.ShowDialog();
        }
    }
}
