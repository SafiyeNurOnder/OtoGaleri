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
    public partial class frmSatisKayitlari : Form
    {
        SqlConnection baglanti;
        string baglantiStr = "Server=DESKTOP-B8C8LG5\\SQLEXPRESS;Database=OtoGaleriDB;Trusted_Connection=True;";
        SqlCommand cmd;
        
        public frmSatisKayitlari()
        {
            InitializeComponent();
            baglanti = new SqlConnection(baglantiStr);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeleArac()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID,  Marka +' '+ Model+' '+ Plaka As MarkModPlak FROM Araclar WHERE Araclar.ID NOT IN (SELECT AracId FROM Satis)", baglanti);
            cmbArac.Items.Clear();
            baglanti.Open();
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            baglanti.Close();

            cmbArac.DataSource = tbl;
            cmbArac.DisplayMember = "MarkModPlak";  // comboboxta görünecek alanlar
            cmbArac.ValueMember = "ID";  // arkaplanda tutulacak değer

        }
        private void ListeleMusteri()
        {
           
            SqlCommand cmd = new SqlCommand("Select ID, Isim+' '+SoyIsim As IsimSoyIsim From Musteri", baglanti);
            cmbMusteri.Items.Clear();
            baglanti.Open();
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            baglanti.Close();

            cmbMusteri.DataSource = tbl;
            cmbMusteri.DisplayMember = "IsimSoyIsim";
            cmbMusteri.ValueMember = "ID";
        }
        private void frmSatisKayitlari_Load(object sender, EventArgs e)
        {
            ListeleMusteri();
            ListeleArac();
            ListeleSatis();
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
           int arac=Convert.ToInt32(cmbArac.SelectedValue);
           int musteri= Convert.ToInt32(cmbMusteri.SelectedValue);
            SqlCommand cmd = new SqlCommand("Insert into Satis (MusteriId,AracId) values" +
                "(" + musteri + ", " +arac + ")", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            ListeleSatis();
        }
        private void ListeleSatis()
        {
            var sorgu = "SELECT s.Id as 'Satış ID', m.Isim + ' ' + m.SoyIsim As 'Isim Soyisim', m.Telefon as 'Telefon', a.Marka, a.Model, a.Plaka, a.SatisFiyati " +
                "FROM Satis S " +
                "INNER JOIN Araclar A ON S.AracId=A.ID " +
                "INNER JOIN Musteri M ON S.MusteriId=M.ID ";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            adapter.Fill(ds);
            grdSatis.ReadOnly = true;
            grdSatis.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
