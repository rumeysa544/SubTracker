namespace SubTracker
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblToplamGider = new System.Windows.Forms.Label();
            this.dgvAbonelikler = new System.Windows.Forms.DataGridView();
            this.txtHizmetAdi = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonelikler)).BeginInit();
            this.SuspendLayout();

            //Tablo
            this.dgvAbonelikler.Name = "dgvAbonelikler";
            this.dgvAbonelikler.Location = new System.Drawing.Point(20, 20);
            this.dgvAbonelikler.Size = new System.Drawing.Size(500, 300);

            //Toplam Gider Etiketi
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Location = new System.Drawing.Point(20, 340);
            this.lblToplamGider.Size = new System.Drawing.Size(300, 30);
            this.lblToplamGider.Text = "Toplam Aylik Gider: 0 TL";

            //Giriş Kutuları ve Butonlar
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Location = new System.Drawing.Point(550, 20);
            this.txtHizmetAdi.Size = new System.Drawing.Size(150, 20);

            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Location = new System.Drawing.Point(550, 60);
            this.txtUcret.Size = new System.Drawing.Size(150, 20);

            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(550, 100);
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(150, 20);

            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Location = new System.Drawing.Point(550, 140);
            this.cbKategori.Size = new System.Drawing.Size(150, 20);

            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Location = new System.Drawing.Point(550, 190);
            this.btnEkle.Size =new System.Drawing.Size(150, 30);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Location = new System.Drawing.Point(550, 230);
            this.btnGuncelle.Size = new System.Drawing.Size(150, 30);
            this.btnGuncelle.Text = "Güncelle";

            this.btnSil.Name = "btnSil";
            this.btnSil.Location = new System.Drawing.Point(550, 230);
            this.btnSil.Size = new System.Drawing.Size(150, 30);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            //Ana Dashboard Penceresi
            this.ClientSize = new System.Drawing.Size(750, 420);
            this.Controls.Add(this.dgvAbonelikler);
            this.Controls.Add(this.lblToplamGider);
            this.Controls.Add(this.txtHizmetAdi);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.dtpOdemeTarihi);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Name = "MainDashboard";
            this.Text = "Subscription Tracking System Dashboard";

            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonelikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.DataGridView dgvAbonelikler;
        private System.Windows.Forms.TextBox txtHizmetAdi;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}
            

 
            
    