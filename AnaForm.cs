using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Verda_Hukuk_Raporlama
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public AnaForm anaFrm
        {
            get;
            set;
        }

        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\LoginSettings.ini");
        iniOku.iniOku uzakIni;
        public string Cs = Properties.Settings.Default.Cs;
        public string CsKontrol = Properties.Settings.Default.CsRaporlama;
        public string sirketAdi;
        string veriCek;
        string sitedenVeriCek;

        SqlConnection con;
        SqlConnection conRapor;
        SqlCommand cmdCon, cmdRapor;
        SqlDataReader drCon, drRapor;

        //Form Ayarları

        public LoginForm FrmGiris;
        public Butce.ButceModulu frmButceModulu;
        public Fonksiyonlar.FonksiyonTanimlari fnk;
        public Butce.ButceAnalizi frmButceAnalizi;
        public Ayarlar.Guncelleme frmGuncelleme;

        private Thread tRemoteVersiyonCek;
        private Thread tRemoteClietVersiyon;


        private void AnaForm_Load(object sender, EventArgs e)
        {
            #region Şirket Adı-Tarih Ve Adres Bilgi Tarafı

            lblSirket.Text = sirketAdi;
            lblKayanYazi.Text = "Editör Bilgi İşlem Elektronik San. ve Tic. Ltd. Şti.     Tel&&Faks : [224] 251 84 55      Web : www.editorgroup.net      E-mail : editor@editorgroup.net      Programmer : Mehmet ÖZDEMİR" +
                          "                                                                                                                                                        ";
            #endregion

            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            CheckForIllegalCrossThreadCalls = false;

            con = new SqlConnection(Cs);
            conRapor = new SqlConnection(CsKontrol);

            SorumlulukMerkezleriniAliyoruz();
            ps_SorumlulukMermeziDoldur();

            if (iniOku.IniOku("Ayar", "GuncellemeTuru") == "0")
            {
                ps_threadremoteVersiyonCek();
            }
            else
            {
                ps_clientVersiyonCek();
                // ps_threadtUzakVersiyon();
            }
        }

        private void timerTarih_Tick(object sender, EventArgs e)
        {
            this.lblKayanYazi.Text = lblKayanYazi.Text.Substring(1) + lblKayanYazi.Text[0].ToString();
            lblTarih.Text = DateTime.Now.ToString();
        }

        private void btnLoginAyari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmGiris == null || FrmGiris.IsDisposed)
            {
                FrmGiris = new LoginForm();
                FrmGiris.kontrol = false;
                FrmGiris.Show();
            }
            else
            {
                FrmGiris.Activate();
            }
        }

        private void btnButceAyari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmButceModulu == null || frmButceModulu.IsDisposed)
            {
                frmButceModulu = new Butce.ButceModulu();
                frmButceModulu.Owner = this;
                frmButceModulu.MdiParent = this;
                frmButceModulu.anaFrm = this;
                frmButceModulu.Show();
            }
            else
            {
                frmButceModulu.Activate();
            }
        }

        private void btnFonksiyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fnk == null || fnk.IsDisposed)
            {
                fnk = new Fonksiyonlar.FonksiyonTanimlari();
                fnk.Owner = this;
                fnk.Show();
            }
            else
            {
                fnk.Activate();
            }
        }

        private void ps_SorumlulukMermeziDoldur()
        {
            string[] ilParcala = Degiskenler.SorumlulukMerkezleri.Split(',');
            string[] smAdiveSmKodu = null;
            string smAdi = null;
            string smKodu = null;
            foreach (var item in ilParcala)
            {
                smAdiveSmKodu = item.Split(':');
                smAdi = smAdiveSmKodu[1].TrimStart().TrimEnd();
                smKodu = smAdiveSmKodu[0].TrimStart().TrimEnd();
                lbSm.Items.Add(smKodu, "<" + smKodu + ">" + smAdi);
            }
            lbSm.CheckAll();
        }

        private void SorumlulukMerkezleriniAliyoruz()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            string Sorgu = @"SELECT CAR006_ReferansKodu + ':' +CAR006_ReferansAciklamasi AS SorumlulukMerkezleri
                          FROM CAR006
                          WHERE CAR006_ReferansTuru = 061 ";

            cmdCon = new SqlCommand(Sorgu, con);
            drCon = cmdCon.ExecuteReader(CommandBehavior.CloseConnection);

            while (drCon.Read())
            {
                Degiskenler.SorumlulukMerkezleri += drCon["SorumlulukMerkezleri"].ToString() + ",";
            }

            Degiskenler.SorumlulukMerkezleri = Degiskenler.SorumlulukMerkezleri.TrimEnd(',');

            drCon.Dispose();
            drCon.Close();
        }

        private void btnSrmMrkzHepsiniSec_Click(object sender, EventArgs e)
        {
            lbSm.CheckAll();
        }

        private void btnSrmMrkzHepsiniKaldir_Click(object sender, EventArgs e)
        {
            lbSm.UnCheckAll();
        }

        private void btnButceAnalizi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmButceAnalizi == null || frmButceAnalizi.IsDisposed)
            {
                frmButceAnalizi = new Butce.ButceAnalizi();
                frmButceAnalizi.Owner = this;
                frmButceAnalizi.MdiParent = this;
                frmButceAnalizi.anafrm = this;
                frmButceAnalizi.Show();
            }
            else
            {
                frmButceAnalizi.Activate();
            }
        }

        #region Versiyon İşlemleri Classı

        private string _versiyon;
        public string Versiyon
        {
            get { return _versiyon; }
            set { _versiyon = value; }
        }

        private string _gelenVersion;
        public string GelenVersion
        {
            get { return _gelenVersion; }
            set { _gelenVersion = value; }
        }

        private string _aciklama;
        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }

        private string _dosyalar;
        public string Dosyalar
        {
            get { return _dosyalar; }
            set { _dosyalar = value; }
        }

        #endregion

        #region Program Güncelleme

        private void frmGuncelleAC()
        {
            if (frmGuncelleme == null || frmGuncelleme.IsDisposed)
            {
                frmGuncelleme = new Ayarlar.Guncelleme();
                frmGuncelleme.Owner = this;
                frmGuncelleme.MdiParent = this;
                //frmGuncelleme.anafrm = this;
                frmGuncelleme.Show();
            }
            else
            {
                frmGuncelleme.Activate();
            }
        }

        #endregion

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGuncelleAC();
        }

        #region Güncelleme Kontrolü

        delegate void dlg_alert(string mesaj);

        private void ps_alert(string mesaj)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new dlg_alert(ps_alert), mesaj);
            }
            else
            {
                DevExpress.XtraBars.Alerter.AlertInfo ai = new DevExpress.XtraBars.Alerter.AlertInfo("Yeni Güncelleme!", mesaj);
                alertControl1.Show(this, ai);

            }
        }

        DataSet dsGuncelleme;

        private void ps_remoteVersiyonCek()
        {
            try
            {
                dsGuncelleme = new DataSet("guncelleme");
                dsGuncelleme.ReadXml("http://editorgroup.net/Programlar/Verda/Butce/version.xml");

                GelenVersion = dsGuncelleme.Tables[0].Rows[0]["Versiyon"].ToString();
                Aciklama = dsGuncelleme.Tables[0].Rows[0]["Aciklama"].ToString();
                Dosyalar = dsGuncelleme.Tables[0].Rows[0]["Dosya"].ToString();

                if (Versiyon != GelenVersion)
                {
                    ps_alert(Aciklama);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme kontrolü hatası:" + ex.Message.ToString());
            }
        }

        private void ps_threadremoteVersiyonCek()
        {
            tRemoteVersiyonCek = new Thread(new ThreadStart(ps_remoteVersiyonCek));
            tRemoteVersiyonCek.Start();
        }

        private void ps_clientVersiyonCek()
        {
            try
            {
                uzakIni = new global::iniOku.iniOku(iniOku.IniOku("Ayar", "InıYolu") + @"\LoginSettings.ini");

                GelenVersion = uzakIni.IniOku("Ayar", "version");
                Aciklama = GelenVersion.ToString() + " Versiyonu Bulundu!";
                Dosyalar = "Verda_Hukuk_Raporlama.exe";


                if (Versiyon != GelenVersion && !string.IsNullOrEmpty(GelenVersion))
                {
                    ps_alert(Aciklama);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme kontrolü hatası:" + ex.Message.ToString());
            }
        }

        private void ps_threadtUzakVersiyon()
        {
            tRemoteClietVersiyon = new Thread(new ThreadStart(ps_threadtUzakVersiyon));
            tRemoteClietVersiyon.Start();
        }

        #endregion
    }
}
