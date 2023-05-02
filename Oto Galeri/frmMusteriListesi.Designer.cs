namespace Oto_Galeri
{
    partial class frmMusteriListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdMusteriler = new System.Windows.Forms.DataGridView();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.lblMusteriler = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEPosta = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.maskedTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMusteriler
            // 
            this.grdMusteriler.AllowUserToAddRows = false;
            this.grdMusteriler.AllowUserToDeleteRows = false;
            this.grdMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMusteriler.Location = new System.Drawing.Point(12, 175);
            this.grdMusteriler.Name = "grdMusteriler";
            this.grdMusteriler.ReadOnly = true;
            this.grdMusteriler.RowHeadersWidth = 51;
            this.grdMusteriler.RowTemplate.Height = 24;
            this.grdMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMusteriler.Size = new System.Drawing.Size(776, 310);
            this.grdMusteriler.TabIndex = 0;
            this.grdMusteriler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMusteriler_CellEnter);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(590, 12);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(148, 39);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Yeni Müşteri";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // lblMusteriler
            // 
            this.lblMusteriler.AutoSize = true;
            this.lblMusteriler.Location = new System.Drawing.Point(28, 12);
            this.lblMusteriler.Name = "lblMusteriler";
            this.lblMusteriler.Size = new System.Drawing.Size(65, 16);
            this.lblMusteriler.TabIndex = 2;
            this.lblMusteriler.Text = "Müşteriler";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(590, 491);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(148, 23);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(134, 32);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(28, 16);
            this.lblTC.TabIndex = 5;
            this.lblTC.Text = "TC ";
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Location = new System.Drawing.Point(134, 55);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(31, 16);
            this.lblİsim.TabIndex = 6;
            this.lblİsim.Text = "İsim";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(134, 78);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(55, 16);
            this.lblSoyisim.TabIndex = 7;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(134, 101);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEPosta
            // 
            this.lblEPosta.AutoSize = true;
            this.lblEPosta.Location = new System.Drawing.Point(134, 124);
            this.lblEPosta.Name = "lblEPosta";
            this.lblEPosta.Size = new System.Drawing.Size(55, 16);
            this.lblEPosta.TabIndex = 9;
            this.lblEPosta.Text = "E-Posta";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(134, 147);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(43, 16);
            this.lblAdres.TabIndex = 10;
            this.lblAdres.Text = "Adres";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(134, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(236, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 12;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(236, 29);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 13;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(236, 52);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 22);
            this.txtIsim.TabIndex = 14;
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Location = new System.Drawing.Point(236, 75);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(100, 22);
            this.txtSoyIsim.TabIndex = 15;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(236, 121);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 22);
            this.txtEposta.TabIndex = 17;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(236, 144);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 18;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(590, 68);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(148, 39);
            this.btnMusteriSil.TabIndex = 19;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(590, 124);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(148, 39);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Müşteri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // maskedTxtTelefon
            // 
            this.maskedTxtTelefon.Location = new System.Drawing.Point(236, 98);
            this.maskedTxtTelefon.Mask = "(999) 000-0000";
            this.maskedTxtTelefon.Name = "maskedTxtTelefon";
            this.maskedTxtTelefon.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtTelefon.TabIndex = 21;
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.maskedTxtTelefon);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblEPosta);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblİsim);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblMusteriler);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.grdMusteriler);
            this.Name = "frmMusteriListesi";
            this.Text = "MusteriListesi";
            this.Load += new System.EventHandler(this.MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMusteriler;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label lblMusteriler;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEPosta;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefon;
    }
}