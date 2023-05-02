namespace Oto_Galeri
{
    partial class frmAracListesi
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
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.grdAraclar = new System.Windows.Forms.DataGridView();
            this.lblaraclar = new System.Windows.Forms.Label();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnAracGuncelle = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYakit = new System.Windows.Forms.Label();
            this.lblDurumu = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtYakit = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtDurumu = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.lblSeri = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.Location = new System.Drawing.Point(580, 12);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(160, 48);
            this.btnAracEkle.TabIndex = 0;
            this.btnAracEkle.Text = "Yeni Araç";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // grdAraclar
            // 
            this.grdAraclar.AllowUserToAddRows = false;
            this.grdAraclar.AllowUserToDeleteRows = false;
            this.grdAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAraclar.Location = new System.Drawing.Point(22, 258);
            this.grdAraclar.Name = "grdAraclar";
            this.grdAraclar.ReadOnly = true;
            this.grdAraclar.RowHeadersWidth = 51;
            this.grdAraclar.RowTemplate.Height = 24;
            this.grdAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAraclar.Size = new System.Drawing.Size(756, 234);
            this.grdAraclar.TabIndex = 1;
            this.grdAraclar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAraclar_CellEnter);
            // 
            // lblaraclar
            // 
            this.lblaraclar.AutoSize = true;
            this.lblaraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaraclar.Location = new System.Drawing.Point(19, 12);
            this.lblaraclar.Name = "lblaraclar";
            this.lblaraclar.Size = new System.Drawing.Size(54, 18);
            this.lblaraclar.TabIndex = 2;
            this.lblaraclar.Text = "Araçlar";
            // 
            // btnAracSil
            // 
            this.btnAracSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracSil.Location = new System.Drawing.Point(580, 79);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(160, 48);
            this.btnAracSil.TabIndex = 3;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracGuncelle.Location = new System.Drawing.Point(580, 146);
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(160, 48);
            this.btnAracGuncelle.TabIndex = 4;
            this.btnAracGuncelle.Text = "Araç Güncelle";
            this.btnAracGuncelle.UseVisualStyleBackColor = true;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(140, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(140, 32);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(45, 16);
            this.lblMarka.TabIndex = 6;
            this.lblMarka.Text = "Marka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(140, 76);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 16);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.Location = new System.Drawing.Point(140, 98);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(22, 16);
            this.lblYil.TabIndex = 8;
            this.lblYil.Text = "Yıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 9;
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakit.Location = new System.Drawing.Point(140, 120);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(37, 16);
            this.lblYakit.TabIndex = 10;
            this.lblYakit.Text = "Yakıt";
            // 
            // lblDurumu
            // 
            this.lblDurumu.AutoSize = true;
            this.lblDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurumu.Location = new System.Drawing.Point(140, 186);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(53, 16);
            this.lblDurumu.TabIndex = 11;
            this.lblDurumu.Text = "Durumu";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKM.Location = new System.Drawing.Point(140, 142);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(26, 16);
            this.lblKM.TabIndex = 12;
            this.lblKM.Text = "KM";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(140, 208);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(36, 16);
            this.lblFiyat.TabIndex = 13;
            this.lblFiyat.Text = "Fiyat";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(231, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 22);
            this.txtID.TabIndex = 14;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(231, 29);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(113, 22);
            this.txtMarka.TabIndex = 15;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(231, 73);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(113, 22);
            this.txtModel.TabIndex = 16;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(231, 95);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(113, 22);
            this.txtYil.TabIndex = 17;
            // 
            // txtYakit
            // 
            this.txtYakit.Location = new System.Drawing.Point(231, 117);
            this.txtYakit.Name = "txtYakit";
            this.txtYakit.Size = new System.Drawing.Size(113, 22);
            this.txtYakit.TabIndex = 18;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(231, 139);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(113, 22);
            this.txtKM.TabIndex = 19;
            // 
            // txtDurumu
            // 
            this.txtDurumu.Location = new System.Drawing.Point(231, 183);
            this.txtDurumu.Name = "txtDurumu";
            this.txtDurumu.Size = new System.Drawing.Size(113, 22);
            this.txtDurumu.TabIndex = 20;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(231, 205);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(113, 22);
            this.txtFiyat.TabIndex = 21;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(580, 498);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(160, 23);
            this.btnGeriDon.TabIndex = 22;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(231, 51);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(113, 22);
            this.txtSeri.TabIndex = 24;
            // 
            // lblSeri
            // 
            this.lblSeri.AutoSize = true;
            this.lblSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeri.Location = new System.Drawing.Point(140, 54);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(31, 16);
            this.lblSeri.TabIndex = 23;
            this.lblSeri.Text = "Seri";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(231, 161);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(113, 22);
            this.txtRenk.TabIndex = 26;
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(140, 164);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(39, 16);
            this.lblRenk.TabIndex = 25;
            this.lblRenk.Text = "Renk";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(231, 227);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(113, 22);
            this.txtPlaka.TabIndex = 28;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(140, 230);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(42, 16);
            this.lblPlaka.TabIndex = 27;
            this.lblPlaka.Text = "Plaka";
            // 
            // frmAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.txtSeri);
            this.Controls.Add(this.lblSeri);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtDurumu);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtYakit);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblDurumu);
            this.Controls.Add(this.lblYakit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAracGuncelle);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.lblaraclar);
            this.Controls.Add(this.grdAraclar);
            this.Controls.Add(this.btnAracEkle);
            this.Name = "frmAracListesi";
            this.Text = "Araç Listesi";
            this.Load += new System.EventHandler(this.frmAracListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.DataGridView grdAraclar;
        private System.Windows.Forms.Label lblaraclar;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnAracGuncelle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYakit;
        private System.Windows.Forms.Label lblDurumu;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtYakit;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtDurumu;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label lblPlaka;
    }
}