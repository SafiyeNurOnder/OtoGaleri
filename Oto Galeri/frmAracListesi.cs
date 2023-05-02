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
    public partial class frmAracListesi : Form
    {
        SqlConnection baglanti;
        string baglantiStr = "Server=DESKTOP-B8C8LG5\\SQLEXPRESS;Database=OtoGaleriDB;Trusted_Connection=True;";
        SqlCommand cmd;
        public frmAracListesi()
        {
            InitializeComponent();
            baglanti = new SqlConnection(baglantiStr);
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            frmAracEkle aracEkle = new frmAracEkle();
            aracEkle.ShowDialog();
        }

        private void frmAracListesi_Load(object sender, EventArgs e)
        {
            AracListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdAraclar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grdAraclar.CurrentRow.Cells[0].Value.ToString();
            txtMarka.Text = grdAraclar.CurrentRow.Cells[1].Value.ToString();
            txtSeri.Text = grdAraclar.CurrentRow.Cells[2].Value.ToString();
            txtModel.Text = grdAraclar.CurrentRow.Cells[3].Value.ToString();
            txtYil.Text = grdAraclar.CurrentRow.Cells[4].Value.ToString();
            txtYakit.Text = grdAraclar.CurrentRow.Cells[5].Value.ToString();
            txtKM.Text = grdAraclar.CurrentRow.Cells[6].Value.ToString();
            txtRenk.Text = grdAraclar.CurrentRow.Cells[7].Value.ToString();
            txtDurumu.Text = grdAraclar.CurrentRow.Cells[8].Value.ToString();
            txtFiyat.Text = grdAraclar.CurrentRow.Cells[9].Value.ToString();
            txtPlaka.Text = grdAraclar.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Araclar WHERE ID = @ID";
            cmd = new SqlCommand(sorgu,baglanti);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            AracListele();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Araclar SET Marka=@Marka, Seri=@Seri, Model=@Model, Yil=@Yil, Yakit=@Yakit," +
                " KM=@KM, Renk=@Renk, Durumu=@Durumu, SatisFiyati=@SatisFiyati, Plaka=@Plaka WHERE ID=@ID";
            cmd = new SqlCommand(sorgu,baglanti);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            cmd.Parameters.AddWithValue("@Marka", txtMarka.Text);
            cmd.Parameters.AddWithValue("@Seri", txtSeri.Text);
            cmd.Parameters.AddWithValue("@Model", txtModel.Text);
            cmd.Parameters.AddWithValue("@Yil",Convert.ToInt32(txtYil.Text));
            cmd.Parameters.AddWithValue("@Yakit", txtYakit.Text);
            cmd.Parameters.AddWithValue("@KM", Convert.ToInt32(txtKM.Text));
            cmd.Parameters.AddWithValue("@Renk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@Durumu", txtDurumu.Text);
            cmd.Parameters.AddWithValue("@SatisFiyati",txtFiyat.Text);
            cmd.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            AracListele();
        }
        public void AracListele()
        {
            var sorgu = "Select * From Araclar";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti); //tüm kayıtları çekiyoruz
            DataSet ds = new DataSet(); //verileri almak için
            baglanti.Open();
            adapter.Fill(ds);
            grdAraclar.ReadOnly = true;
            grdAraclar.DataSource = ds.Tables[0];
            baglanti.Close();
        }

    }
}
