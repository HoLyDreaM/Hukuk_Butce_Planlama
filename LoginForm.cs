using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Verda_Hukuk_Raporlama
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        AnaForm frmAnafrm;
        private string version;
        string yol, yol2;
        SqlConnection conLink = new SqlConnection();
        SqlConnection conButce = new SqlConnection();
        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\LoginSettings.ini");
        public Boolean kontrol = true;

        #region "Sifrele_Şifreçöz"
        static public string Sifrele(string veri)
        {
            byte[] veriByteDizisi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
            string sifrelenmisVeri = System.Convert.ToBase64String(veriByteDizisi);
            return sifrelenmisVeri;
        }
        static public string Coz(string cozVeri)
        {
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }
        #endregion

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            conLink.Close();
            conButce.Close();

            Properties.Settings.Default["Cs"] = "Data Source=" + txtLinkServer.Text + ";Initial Catalog=YNS" + txtLinkSirketAdi.Text + ";User ID=YNS" + txtLinkSirketAdi.Text + ";Password=PSW" + txtLinkSirketAdi.Text + "";
            Properties.Settings.Default["CsRaporlama"] = "Data Source=" + txtButceServerAdi.Text + ";Initial Catalog=" + txtButceSirketAdi.Text + ";User ID=" + txtButceKullAdi.Text + ";Password=" + txtButceSifre.Text + "";

            yol = Properties.Settings.Default.Cs;
            yol2 = Properties.Settings.Default.CsRaporlama;

            conLink.ConnectionString = yol;
            conButce.ConnectionString = yol2;

            try
            {
                conLink.Open();
                conButce.Open();
                conButce.Close();
                conLink.Close();
                frmAnafrm = new AnaForm();

                if (kontrol) Program.ac.MainForm = frmAnafrm;
                iniOku.IniYaz("Ayar", "LinkServer", txtLinkServer.Text);
                iniOku.IniYaz("Ayar", "LinkSirket", txtLinkSirketAdi.Text);
                iniOku.IniYaz("Ayar", "ButceServer", txtButceServerAdi.Text);
                iniOku.IniYaz("Ayar", "ButceVeritabani", txtButceSirketAdi.Text);
                iniOku.IniYaz("Ayar", "ButceKullAdi", txtButceKullAdi.Text);
                iniOku.IniYaz("Ayar", "ButceSifre", Sifrele(txtButceSifre.Text));
                frmAnafrm.Versiyon = version;
                iniOku.IniYaz("Ayar", "oto", oto.Checked.ToString());

                

                conLink.Close();
                conButce.Close();

                if (kontrol)
                {
                    frmAnafrm.sirketAdi = txtLinkSirketAdi.Text;
                    frmAnafrm.Show();
                }
                else
                {
                    Application.Restart();
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Sağlanamadı");
                lblDurum.Text = "Bağlantı Sağlanamadı!"; 
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                txtLinkServer.Text = iniOku.IniOku("Ayar", "LinkServer");
                txtLinkSirketAdi.Text = iniOku.IniOku("Ayar", "LinkSirket");
                txtButceServerAdi.Text = iniOku.IniOku("Ayar", "ButceServer");
                txtButceSirketAdi.Text = iniOku.IniOku("Ayar", "ButceVeritabani");
                txtButceKullAdi.Text = iniOku.IniOku("Ayar", "ButceKullAdi");
                txtButceSifre.Text = Coz(iniOku.IniOku("Ayar", "ButceSifre"));
                oto.Checked = Convert.ToBoolean(iniOku.IniOku("Ayar", "oto"));
                version = iniOku.IniOku("Ayar", "version");

            if (oto.Checked && kontrol)
                    btnBaglan_Click(sender, e);
            }
            catch { }
        }
    }
}
