namespace SubTracker
{
    partial class LoginForm
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();

            //Kullanıcı Adı Kutusu
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Location = new System.Drawing.Point(100, 50);
            this.txtKullaniciAdi.Size = new System.Drawing.Size(150, 20);

            //Şifre Kutusu
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Location = new System.Drawing.Point(100, 90);
            this.txtSifre.Size = new System.Drawing.Size(150, 20);
            this.txtSifre.PasswordChar = '*';

            //Beni Hatırla
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Location = new System.Drawing.Point(100, 130);
            this.chkBeniHatirla.Text = "Beni Hatırla";

            //Giriş Butonu
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Location = new System.Drawing.Point(100, 170);
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);

            //Giriş Formu Penceresi
            this.ClientSize = new System.Drawing.Size(350, 260);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.btnGiris);
            this.Name = "LoginForm";
            this.Text = "SubTracker - Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox chkBeniHatirla;
        private System.Windows.Forms.Button btnGiris;
    }
}
         
        