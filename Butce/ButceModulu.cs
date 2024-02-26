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

namespace Verda_Hukuk_Raporlama.Butce
{
    public partial class ButceModulu : Form
    {
        public ButceModulu()
        {
            InitializeComponent();
        }

        public AnaForm anaFrm
        {
            get;
            set;
        }

        SqlConnection conFnk;
        SqlCommand cmdFnk;
        SqlDataReader drFnk;
        string veritabani;
        string Cs = Properties.Settings.Default.Cs;

        Task SorumlulukMerkezleriGetir1, SorumlulukMerkezleriGetir2, 
             SorumlulukKodlariGetir1, SorumlulukKodlariGetir2;

        string[] srmMrkzParcala;
        string[] srmMrkzParcala2;

        private void ButceModulu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRaporlama.tblSrmMrkzAdi' table. You can move, or remove it, as needed.
            this.tblSrmMrkzAdiTableAdapter.Fill(this.dsRaporlama.tblSrmMrkzAdi);
            this.butceTableAdapter.Fill(this.dsRaporlama.Butce);

            int Yil = Convert.ToInt32(DateTime.Now.Year);
            int Yil2 = Yil + 1;

            if (!IsDisposed)
            {
                cmbYil.Items.Add(Yil);
                cmbYil.Items.Add(Yil2);
            }
            cmbYil.SelectedIndex = 0;

            foreach (DataRow dr in dsRaporlama.tblSrmMrkzAdi.Rows)
            {
                cmbSrmMrkzAdi.Items.Add(dr["SorumlulukMerkeziAdi"].ToString());
            }

            cmbSrmMrkzAdi.SelectedIndex = 0;

        }

        private void btnButceTanimiKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtButceGelir.Text))
            {
                MessageBox.Show("Gelir Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz.");
                return;
            }
            else if (string.IsNullOrEmpty(txtButceGider.Text))
            {
                MessageBox.Show("Gider Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz");
                return;
            }
            else
            {
                Degiskenler.SrmMrkzAdi = cmbSrmMrkzAdi.SelectedItem.ToString();
                Degiskenler.SrmMrkzKodu = cmbSrmMrkzKodu.SelectedItem.ToString();

                srmMrkzParcala = Degiskenler.SrmMrkzKodu.Split('<');
                Degiskenler.SrmMrkzKodu = srmMrkzParcala[1].ToString();

                Degiskenler.SrmMrkzKodu = Degiskenler.SrmMrkzKodu.Replace(">", "");

                Degiskenler.ButceGelir = Convert.ToDecimal(txtButceGelir.Text);
                Degiskenler.ButceGider = Convert.ToDecimal(txtButceGider.Text);
                Degiskenler.ButceYil = Convert.ToInt32(cmbYil.SelectedItem.ToString());

                this.butceTableAdapter.ButceEkle(Degiskenler.SrmMrkzAdi, Degiskenler.SrmMrkzKodu, Degiskenler.ButceGelir,
                    Degiskenler.ButceGider, Degiskenler.ButceYil);

                MessageBox.Show("Bütçeniz Başarılı Bir Şekilde Eklenmiştir.");
                this.butceTableAdapter.Fill(this.dsRaporlama.Butce);
            }
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.butceTableAdapter.Fill(this.dsRaporlama.Butce);
        }

        private void btnYeniButce_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtButceGelir.Clear();
            txtButceGider.Clear();
            txtID.Text = "";
        }

        private void btnButceSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (MessageBox.Show("Kayıt Silincek! Onaylıyor musunuz?", "Kayıt Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    this.butceTableAdapter.ButceSil(Convert.ToInt32(txtID.Text));
                    butceBindingSource.RemoveCurrent();

                }
            }
        }

        private void btnButceDuzenle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtButceGelir.Text))
            {
                MessageBox.Show("Gelir Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz.");
                return;
            }
            else if (string.IsNullOrEmpty(txtButceGider.Text))
            {
                MessageBox.Show("Gider Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz");
                return;
            }
            else
            {

                Degiskenler.SrmMrkzAdi = cmbSrmMrkzAdi.SelectedItem.ToString();
                Degiskenler.SrmMrkzKodu = cmbSrmMrkzKodu.SelectedItem.ToString();

                srmMrkzParcala2 = Degiskenler.SrmMrkzKodu.Split('<');
                Degiskenler.SrmMrkzKodu = srmMrkzParcala2[1].ToString();

                Degiskenler.SrmMrkzKodu = Degiskenler.SrmMrkzKodu.Replace(">", "");

                Degiskenler.ButceGelir = Convert.ToDecimal(txtButceGelir.Text);
                Degiskenler.ButceGider = Convert.ToDecimal(txtButceGider.Text);
                Degiskenler.ButceYil = Convert.ToInt32(cmbYil.SelectedItem.ToString());
                Degiskenler.ButceID = Convert.ToInt32(txtID.Text);

                this.butceTableAdapter.ButceEdit(Degiskenler.SrmMrkzAdi, Degiskenler.SrmMrkzKodu, Degiskenler.ButceGelir,
                    Degiskenler.ButceGider, Degiskenler.ButceYil, Degiskenler.ButceID);

                MessageBox.Show("Bütçeniz Başarılı Bir Şekilde Düzenlenmiştir");

                this.butceTableAdapter.Fill(this.dsRaporlama.Butce);
            }
        }

        private void cmbSrmMrkzAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSrmMrkzKodu.Items.Clear();
            txtButceGelir.Clear();
            txtButceGider.Clear();
            txtID.Text = "";

            string SrmMrkzSecimi = cmbSrmMrkzAdi.SelectedItem.ToString();

            this.tblSrmMrkzKoduTableAdapter.Fill(this.dsRaporlama.tblSrmMrkzKodu, SrmMrkzSecimi.ToString());

            if (!IsDisposed)
            {
                foreach (DataRow dr in dsRaporlama.tblSrmMrkzKodu.Rows)
                {
                    cmbSrmMrkzKodu.Items.Add(dr["SorumlulukKodlari"].ToString());
                }
            }

            cmbSrmMrkzKodu.SelectedIndex = 0;
        }
    }
}
