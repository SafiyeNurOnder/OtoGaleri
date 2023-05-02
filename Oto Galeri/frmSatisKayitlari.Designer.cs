namespace Oto_Galeri
{
    partial class frmSatisKayitlari
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
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.grdSatis = new System.Windows.Forms.DataGridView();
            this.lblAracBilgi = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblArac = new System.Windows.Forms.Label();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(761, 511);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(104, 38);
            this.btnCıkıs.TabIndex = 0;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // grdSatis
            // 
            this.grdSatis.AllowUserToAddRows = false;
            this.grdSatis.AllowUserToDeleteRows = false;
            this.grdSatis.BackgroundColor = System.Drawing.Color.White;
            this.grdSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatis.Location = new System.Drawing.Point(12, 185);
            this.grdSatis.Name = "grdSatis";
            this.grdSatis.ReadOnly = true;
            this.grdSatis.RowHeadersWidth = 51;
            this.grdSatis.RowTemplate.Height = 24;
            this.grdSatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSatis.Size = new System.Drawing.Size(853, 320);
            this.grdSatis.TabIndex = 3;
            // 
            // lblAracBilgi
            // 
            this.lblAracBilgi.AutoSize = true;
            this.lblAracBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracBilgi.Location = new System.Drawing.Point(17, 146);
            this.lblAracBilgi.Name = "lblAracBilgi";
            this.lblAracBilgi.Size = new System.Drawing.Size(88, 18);
            this.lblAracBilgi.TabIndex = 6;
            this.lblAracBilgi.Text = "Araç Bilgileri";
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(659, 61);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(206, 35);
            this.btnSatis.TabIndex = 7;
            this.btnSatis.Text = "Satış Kaydet";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(12, 72);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(232, 24);
            this.cmbMusteri.TabIndex = 8;
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(17, 41);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(66, 16);
            this.lblMusteri.TabIndex = 9;
            this.lblMusteri.Text = "Müşteri (*)";
            // 
            // lblArac
            // 
            this.lblArac.AutoSize = true;
            this.lblArac.Location = new System.Drawing.Point(279, 41);
            this.lblArac.Name = "lblArac";
            this.lblArac.Size = new System.Drawing.Size(51, 16);
            this.lblArac.TabIndex = 11;
            this.lblArac.Text = "Araç (*)";
            // 
            // cmbArac
            // 
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(282, 72);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(232, 24);
            this.cmbArac.TabIndex = 10;
            // 
            // frmSatisKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(877, 551);
            this.Controls.Add(this.lblArac);
            this.Controls.Add(this.cmbArac);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.lblAracBilgi);
            this.Controls.Add(this.grdSatis);
            this.Controls.Add(this.btnCıkıs);
            this.Name = "frmSatisKayitlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Kayıtları";
            this.Load += new System.EventHandler(this.frmSatisKayitlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.DataGridView grdSatis;
        private System.Windows.Forms.Label lblAracBilgi;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblArac;
        private System.Windows.Forms.ComboBox cmbArac;
    }
}