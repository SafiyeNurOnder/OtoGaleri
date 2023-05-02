namespace Oto_Galeri
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnSatısKayıtları = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCıkıs);
            this.panel1.Controls.Add(this.btnSatısKayıtları);
            this.panel1.Controls.Add(this.btnAracListele);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 119);
            this.panel1.TabIndex = 0;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.MistyRose;
            this.btnCıkıs.Image = global::Oto_Galeri.Properties.Resources.cıkıs;
            this.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCıkıs.Location = new System.Drawing.Point(561, 12);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(135, 95);
            this.btnCıkıs.TabIndex = 6;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnSatısKayıtları
            // 
            this.btnSatısKayıtları.BackColor = System.Drawing.Color.MistyRose;
            this.btnSatısKayıtları.Image = global::Oto_Galeri.Properties.Resources.satis;
            this.btnSatısKayıtları.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatısKayıtları.Location = new System.Drawing.Point(378, 12);
            this.btnSatısKayıtları.Name = "btnSatısKayıtları";
            this.btnSatısKayıtları.Size = new System.Drawing.Size(135, 95);
            this.btnSatısKayıtları.TabIndex = 5;
            this.btnSatısKayıtları.Text = "Satış Kayıtları";
            this.btnSatısKayıtları.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatısKayıtları.UseVisualStyleBackColor = false;
            this.btnSatısKayıtları.Click += new System.EventHandler(this.btnSatısKayıtları_Click);
            // 
            // btnAracListele
            // 
            this.btnAracListele.BackColor = System.Drawing.Color.MistyRose;
            this.btnAracListele.Image = global::Oto_Galeri.Properties.Resources.musteriListele1;
            this.btnAracListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracListele.Location = new System.Drawing.Point(195, 12);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(135, 95);
            this.btnAracListele.TabIndex = 3;
            this.btnAracListele.Text = "Araç Listele";
            this.btnAracListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracListele.UseVisualStyleBackColor = false;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.Color.MistyRose;
            this.btnMusteriListele.Image = global::Oto_Galeri.Properties.Resources.musteriListele;
            this.btnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriListele.Location = new System.Drawing.Point(12, 12);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(135, 95);
            this.btnMusteriListele.TabIndex = 1;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(587, 393);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Safiye Nur Önder";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Oto_Galeri.Properties.Resources.ekran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 412);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnSatısKayıtları;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Label lblName;
    }
}

