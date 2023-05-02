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
    public partial class frmAracEkle : Form
    {
        SqlConnection baglanti;
        string baglantiStr = "Server=DESKTOP-B8C8LG5\\SQLEXPRESS;Database=OtoGaleriDB;Trusted_Connection=True;";
        SqlCommand cmd;
        public frmAracEkle()
        {
            InitializeComponent();
            baglanti = new SqlConnection(baglantiStr);
        }



        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into Araclar" +
                "(Marka,Seri,Model,Yil,Yakit,KM,Renk,Durumu,AlisFiyati,SatisFiyati,Plaka,SatildiMi) values " +
                "('" + txtMarka.Text + "','" + txtSeri.Text + "','" + txtModel.Text + "','" +Convert.ToInt32(txtYil.Text) + "','" + txtYakit.Text + "'" +
                ",'" +Convert.ToInt32(txtKM.Text) + "','" + txtRenk.Text + "','" + txtDurumu.Text + "','" + txtAlisFiyati.Text + "'," +
                "'" + txtSatisFiyati.Text + "','" + txtPlaka.Text + "','" + txtSatildiMi.Text + "')";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
