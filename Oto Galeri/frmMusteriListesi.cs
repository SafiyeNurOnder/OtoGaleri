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
    public partial class frmMusteriListesi : Form
    {
        SqlConnection baglanti;
        string baglantiStr = "Server=DESKTOP-B8C8LG5\\SQLEXPRESS;Database=OtoGaleriDB;Trusted_Connection=True;";
        SqlCommand cmd;
        public frmMusteriListesi()
        {
            InitializeComponent();
            baglanti = new SqlConnection(baglantiStr);
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle musteriEkle = new frmMusteriEkle();
            musteriEkle.Show();
            this.Close();
        }

        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdMusteriler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grdMusteriler.CurrentRow.Cells[0].Value.ToString();
            txtTC.Text = grdMusteriler.CurrentRow.Cells[1].Value.ToString();
            txtIsim.Text = grdMusteriler.CurrentRow.Cells[2].Value.ToString();
            txtSoyIsim.Text = grdMusteriler.CurrentRow.Cells[3].Value.ToString();
            maskedTxtTelefon.Text = grdMusteriler.CurrentRow.Cells[4].Value.ToString();
            txtEposta.Text = grdMusteriler.CurrentRow.Cells[5].Value.ToString();
            txtAdres.Text = grdMusteriler.CurrentRow.Cells[6].Value.ToString();
        }


        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            string sorguSil = "Delete from Musteri where ID = @ID";
            cmd = new SqlCommand(sorguSil, baglanti);
            cmd.Parameters.AddWithValue("@ID",Convert.ToInt32(txtID.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MusteriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorguGuncelle = "Update Musteri SET TCKimlikNo=@TCKimlikNo, Isim=@Isim," +
                "SoyIsim=@SoyIsim, Telefon=@Telefon, EPosta=@EPosta, Adres=@Adres WHERE ID=@ID";
            cmd = new SqlCommand(sorguGuncelle, baglanti);
            cmd.Parameters.AddWithValue("@ID",Convert.ToInt32(txtID.Text));
            cmd.Parameters.AddWithValue("@TCKimlikNo", txtTC.Text);
            cmd.Parameters.AddWithValue("@Isim", txtIsim.Text);
            cmd.Parameters.AddWithValue("@SoyIsim", txtSoyIsim.Text);
            cmd.Parameters.AddWithValue("@Telefon", maskedTxtTelefon.Text);
            cmd.Parameters.AddWithValue("@EPosta", txtEposta.Text);
            cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MusteriListele();
        }
        public void MusteriListele()
        {
            var sorgu = "Select * From Musteri";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            adapter.Fill(ds);
            grdMusteriler.ReadOnly = true;
            grdMusteriler.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
