using System;
using System.Data;
using System.Windows.Forms;

namespace SubTracker
{
    public partial class MainDashboard : Form
    {
        private DataTable dtAbonelikler;

        public MainDashboard()
        {
            InitializeComponent();
            AbonelikTablosunuHazirla();
            KategorileriYukle();
            HesaplaToplamGider();
        }

        private void AbonelikTablosunuHazirla()
        {
            dtAbonelikler = new DataTable();
            dtAbonelikler.Columns.Add("ID", typeof(int));
            dtAbonelikler.Columns.Add("Hizmet Adi", typeof(string));
            dtAbonelikler.Columns.Add("Odeme Tarihi", typeof(double));
            dtAbonelikler.Columns.Add("Kategori", typeof(string));
            dgvAbonelikler.DataSource = dtAbonelikler;
        }

        private void KategorileriYukle()
        {
            cbKategori.Items.AddRange(new string[] {"Eğlence", "Eğitim", "Yazilim", "Diğer"});
            if (cbKategori.Items.Count > 0) cbKategori.SelectedIndex = 0;
        }

        private void HesaplaToplamGider()
        {
            double toplam = 0;
            foreach (DataRow row in dtAbonelikler.Rows)
            {
                if (row["Aylik Ucret"] != DBNull.Value)
                toplam +=Convert.ToDouble(row["Aylik Ucret"]);
            }
            lblToplamGider.Text = "Toplam Aylik Gider: " + toplam.ToString("C2");
            }

            private void KontrolEtYaklasacakOdemeler()
            {
                foreach (DataGridViewRow row in dgvAbonelikler.Rows)
                {
                    if (row.Cells["Odeme Tarihi"].Value != null)
                    {
                        DateTime odemeTarihi = Convert.ToDateTime(row.Cells["Odeme Tarihi"].Value);
                        if ((odemeTarihi - DateTime.Today).TotalDays <= 3 && (odemeTarihi - DateTime.Today).TotalDays >= 0)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                        }
                    }
                }
            }

            private void btnEkle_Click(object sender, EventArgs e)
            {
                if(!string.IsNullOrEmpty(txtHizmetAdi.Text) && !string.IsNullOrEmpty(txtUcret.Text))
                {
                    int yeniId = dtAbonelikler.Rows.Count + 1;
                    dtAbonelikler.Rows.Add(yeniId, txtHizmetAdi.Text, Convert.ToDouble(txtUcret.Text), dtpOdemeTarihi.Value, cbKategori.SelectedItem.ToString());
                    HesaplaToplamGider();
                    KontrolEtYaklasacakOdemeler();
                }
            }

            private void btnSil_Click(object sender, EventArgs e)
            {
                if(dgvAbonelikler.SelectedRows.Count > 0)
                {
                    dgvAbonelikler.Rows.RemoveAt(dgvAbonelikler.SelectedRows[0].Index);
                    HesaplaToplamGider();
                }
            }
    }
}

        


    
