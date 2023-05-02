using System;

namespace Oto_Galeri
{
    partial class frmMusteriEkle
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
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblEPosta = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.maskedTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.musteriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(30, 54);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(83, 25);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "TC No *";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(30, 99);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(45, 25);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad*";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonNo.Location = new System.Drawing.Point(30, 199);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(116, 25);
            this.lblTelefonNo.TabIndex = 3;
            this.lblTelefonNo.Text = "Telefon No*";
            // 
            // lblEPosta
            // 
            this.lblEPosta.AutoSize = true;
            this.lblEPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEPosta.Location = new System.Drawing.Point(30, 244);
            this.lblEPosta.Name = "lblEPosta";
            this.lblEPosta.Size = new System.Drawing.Size(88, 25);
            this.lblEPosta.TabIndex = 4;
            this.lblEPosta.Text = "E-Posta:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(30, 289);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(70, 25);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres:";
            // 
            // maskedTxtTelefon
            // 
            this.maskedTxtTelefon.Location = new System.Drawing.Point(191, 195);
            this.maskedTxtTelefon.Mask = "(999) 000-0000";
            this.maskedTxtTelefon.Name = "maskedTxtTelefon";
            this.maskedTxtTelefon.Size = new System.Drawing.Size(173, 22);
            this.maskedTxtTelefon.TabIndex = 6;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(191, 46);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(173, 22);
            this.txtTcNo.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(191, 93);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(173, 22);
            this.txtAd.TabIndex = 8;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(191, 242);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(173, 22);
            this.txtEPosta.TabIndex = 9;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(191, 289);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(173, 69);
            this.TxtAdres.TabIndex = 10;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(191, 143);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(173, 22);
            this.txtSoyad.TabIndex = 14;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(30, 149);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(77, 25);
            this.lblSoyad.TabIndex = 13;
            this.lblSoyad.Text = "Soyad*";
            // 
            // btnIptal
            // 
            this.btnIptal.Image = global::Oto_Galeri.Properties.Resources.cıkıs;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIptal.Location = new System.Drawing.Point(264, 386);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 79);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // musteriEkle
            // 
            this.musteriEkle.Image = global::Oto_Galeri.Properties.Resources.kaydet;
            this.musteriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.musteriEkle.Location = new System.Drawing.Point(35, 386);
            this.musteriEkle.Name = "musteriEkle";
            this.musteriEkle.Size = new System.Drawing.Size(100, 79);
            this.musteriEkle.TabIndex = 11;
            this.musteriEkle.Text = "Ekle";
            this.musteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteriEkle.UseVisualStyleBackColor = true;
            this.musteriEkle.Click += new System.EventHandler(this.musteriEkle_Click);
            // 
            // frmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(418, 521);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.musteriEkle);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.maskedTxtTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblEPosta);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTc);
            this.Name = "frmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblEPosta;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefon;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Button musteriEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
    }
}