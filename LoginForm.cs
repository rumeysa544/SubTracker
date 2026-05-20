using System;
using System.Windows.Forms;

namespace SubTracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kadi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            //Alphenumeric ve Türkçe Karaktersiz Kullanıcı Kontrolleri
            if ((kadi == "esragumruk61" && sifre == "esra123") || (kadi == "rumeysainlkc" && sifre == "rum456"))
            {
                MessageBox.Show("Giriş Başarılı! Sisteme yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainDashboard dashboard = new MainDashboard();
                dashboard.Show();
                this.Hide(); //Giriş Formunu Gizle
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


