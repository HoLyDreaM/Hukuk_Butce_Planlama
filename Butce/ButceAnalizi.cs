using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Verda_Hukuk_Raporlama.Butce
{
    public partial class ButceAnalizi : Form
    {
        public ButceAnalizi()
        {
            InitializeComponent();
        }
        public AnaForm anafrm { get; set; }

        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\LoginSettings.ini");

        private string fn_smCek()
        {
            string _q, _q1;
            _q = null;
            _q1 = null;
            for (int i = 0; i < anafrm.lbSm.CheckedItems.Count; i++)
            {
                _q1 = anafrm.lbSm.CheckedItems[i].ToString();
                _q += "'" + _q1 + "',";
            }

            if (!string.IsNullOrEmpty(_q))
            {
                _q = _q.Substring(0, _q.Length - 1);
            }
            else
            {
                _q = null;
            }
            return _q;
        }

        private void ps_ButceAnalizi(string smKod)
        {
            Degiskenler.LinkSirketAdi = "YNS" + iniOku.IniOku("Ayar", "LinkSirket");
            Degiskenler.RaporVeritabani = iniOku.IniOku("Ayar", "ButceVeritabani");

            if (!string.IsNullOrEmpty(smKod))
            {
                Degiskenler.DonemAraligi = Convert.ToInt32(cmbDonemAraligi.Text.ToString());

                SqlConnection con = new SqlConnection(Properties.Settings.Default.CsRaporlama);
                con.Open();

                double TarihBaslangic = 0;
                int TarihBtTarih = 0;

                double TarihBitis = 0;
                int TarihBitTarih = 0;

                DateTime dtBaslangic = new DateTime();
                dtBaslangic = Convert.ToDateTime(tarih1.Text);
                string strBaslangic;
                TarihBaslangic = 0;
                TarihBaslangic = dtBaslangic.ToOADate();
                strBaslangic = TarihBaslangic.ToString().Substring(0, 5);
                TarihBtTarih = Convert.ToInt32(strBaslangic);

                DateTime dtBitis = new DateTime();
                dtBitis = Convert.ToDateTime(tarih2.Text);
                string strBitis;
                TarihBitis = 0;
                TarihBitis = dtBitis.ToOADate();
                strBitis = TarihBitis.ToString().Substring(0, 5);
                TarihBitTarih = Convert.ToInt32(strBitis);

                string sorgu = "CREATE TABLE #Gelir( " +
                                 "Tip NVARCHAR(20), " +
                                 "BelgeTarihi NVARCHAR(10), " +
                                 "CariKod NVARCHAR(50), " +
                                 "CariAdi NVARCHAR(150), " +
                                 "Meblag NUMERIC(21,2), " +
                                 "Aciklama NVARCHAR(500), " +
                                 "EvrakSeriNo NVARCHAR(50), " +
                                 "SorumlulukMerkeziAdi NVARCHAR(50), " +
                                 "SorumlulukMerkeziKodu NVARCHAR(50), " +
                                 "Toplam NUMERIC(21,2) " +
                                 ") " +
                                 "CREATE TABLE #Gider( " +
                                 "Tip NVARCHAR(20), " +
                                 "BelgeTarihi NVARCHAR(10), " +
                                 "CariKod NVARCHAR(50), " +
                                 "CariAdi NVARCHAR(150), " +
                                 "Meblag NUMERIC(21,2), " +
                                 "Aciklama NVARCHAR(500), " +
                                 "EvrakSeriNo NVARCHAR(50), " +
                                 "SorumlulukMerkeziAdi NVARCHAR(50), " +
                                 "SorumlulukMerkeziKodu NVARCHAR(50), " +
                                 "Toplam NUMERIC(21,2) " +
                                 ") " +
                                 "CREATE TABLE #SorumlulukAdlari( " +
                                 "SorumlulukMerkeziAdi NVARCHAR(150), " +
                                 "SorumlulukKodlari NVARCHAR(100) " +
                                 ") " +
                                 "CREATE TABLE #GelirToplam( " +
                                 "Toplam NUMERIC(18,2), " +
                                 "SrmKodu NVARCHAR(50) " +
                                 ") " +
                                 "CREATE TABLE #GiderToplam( " +
                                 "Toplam NUMERIC(18,2), " +
                                 "SrmKodu NVARCHAR(50) " +
                                 ") " +
                                 "INSERT INTO #SorumlulukAdlari " +
                                 "SELECT * FROM( " +
                                 "SELECT CAR006_ReferansKodu AS SorumlulukKodlari,CAR006_ReferansAciklamasi AS SorumlulukMerkeziAdi " +
                                 "FROM " + Degiskenler.LinkSirketAdi + "." + Degiskenler.LinkSirketAdi + ".CAR006 " +
                                 "WHERE CAR006_ReferansTuru = 061 AND CAR006_ReferansKodu IN(" + smKod + ") " +
                                 ") AS TBL2  " +
                                 "INSERT INTO #Gelir " +
                                 "SELECT 'Gelir' AS Tip,CONVERT(VARCHAR(10),CONVERT(DATETIME,CAR003_Tarih-2),104) AS BelgeTarihi, " +
                                 "CAR003_HesapKodu AS CariKodu," +Degiskenler.LinkSirketAdi + ".dbo.fn_CariAdiBul(CAR003_HesapKodu) AS CariAdi, " +
                                 "CAR003_Tutar AS Meblag, " +
                                 "CAR003_Aciklama AS Aciklama,CAR003_EvrakSeriNo AS EvrakSeriNo, " +
                                 "(SELECT CAR006_ReferansAciklamasi AS SorumlulukMerkeziAdi " +
                                 "FROM " + Degiskenler.LinkSirketAdi + "." + Degiskenler.LinkSirketAdi + ".CAR006 WHERE CAR006_ReferansTuru = 061 AND " +
                                 "CAR006_ReferansKodu = CAR003_Kod2) AS SorumlulukMerkeziAdi, " +
                                 "CAR003_Kod2 AS SorumlulukMerkeziKodu,SUM(CAR003_Tutar) AS Tutar " +
                                 "FROM " + Degiskenler.LinkSirketAdi + "." + Degiskenler.LinkSirketAdi + ".CAR003 " +
                                 "WHERE CAR003_BA = 0 AND CAR003_IslemTipi IN(81,81,4,8,2,1,3,7,11,21,31,41,50) AND " +
                                 "(CAR003_Tarih BETWEEN " + TarihBtTarih + " AND " + TarihBitTarih + ") " +
                                 "AND CAR003_Kod2 IN(" + smKod + ") " +
                                 "GROUP BY CONVERT(VARCHAR(10),CONVERT(DATETIME,CAR003_Tarih-2),104),CAR003_HesapKodu, " +
                                 "CAR003_Aciklama,CAR003_EvrakSeriNo,CAR003_Kod2,CAR003_Tutar " +
                                 "INSERT INTO #Gider " +
                                 "SELECT 'Gider' AS Tip,CONVERT(VARCHAR(10),CONVERT(DATETIME,CAR003_Tarih-2),104) AS BelgeTarihi, " +
                                 "CAR003_HesapKodu AS CariKodu," + Degiskenler.LinkSirketAdi + ".dbo.fn_CariAdiBul(CAR003_HesapKodu) AS CariAdi, " +
                                 "CAR003_Tutar AS Meblag, " +
                                 "CAR003_Aciklama AS Aciklama,CAR003_EvrakSeriNo AS EvrakSeriNo, " +
                                 "(SELECT CAR006_ReferansAciklamasi AS SorumlulukMerkeziAdi " +
                                 "FROM " + Degiskenler.LinkSirketAdi + "." + Degiskenler.LinkSirketAdi + ".CAR006 WHERE CAR006_ReferansTuru = 061 AND " +
                                 "CAR006_ReferansKodu = CAR003_Kod2) AS SorumlulukMerkeziAdi, " +
                                 "CAR003_Kod2 AS SorumlulukMerkeziKodu,SUM(CAR003_Tutar) AS Tutar " +
                                 "FROM " + Degiskenler.LinkSirketAdi + "." + Degiskenler.LinkSirketAdi + ".CAR003 " +
                                 "WHERE CAR003_BA = 1 AND CAR003_IslemTipi IN(1,81,8,4,2,3,7,11,21,31,41) AND  " +
                                 "(CAR003_Tarih BETWEEN " + TarihBtTarih + " AND " + TarihBitTarih + ") " +
                                 "AND CAR003_Kod2 IN(" + smKod + ") " +
                                 "GROUP BY CONVERT(VARCHAR(10),CONVERT(DATETIME,CAR003_Tarih-2),104),CAR003_HesapKodu, " +
                                 "CAR003_Aciklama,CAR003_EvrakSeriNo,CAR003_Kod2,CAR003_Tutar " +
                                 "INSERT INTO #GelirToplam " +
                                 "SELECT SUM(Toplam) AS Toplam,#Gelir.SorumlulukMerkeziKodu FROM #Gelir " +
                                 "GROUP BY #Gelir.SorumlulukMerkeziKodu  " +
                                 "INSERT INTO #GiderToplam " +
                                 "SELECT SUM(Toplam) AS Toplam,#Gider.SorumlulukMerkeziKodu FROM #Gider " +
                                 "GROUP BY #Gider.SorumlulukMerkeziKodu  " +
                                 "SELECT TBL.Bolge,TBL.SorumlulukMerkeziAdi,TBL.Yil,TBL.BelirlenenButceGelir,TBL.ButcelenenGelir,  " +
                                 "ISNULL(TBL.GerceklesenGelir,0) AS GerceklesenGelir,TBL.BelirlenenButceGider,  " +
                                 "TBL.ButcelenenGider,ISNULL(TBL.GerceklesenGider,0) AS GerceklesenGider,  " +
                                 "ISNULL(TBL.ButcelenenGerceklesenGelir,0) AS ButcelenenGerceklesenGelir,  " +
                                 "ISNULL(TBL.ButcelenenGerceklesenGider,0) AS ButcelenenGerceklesenGider,  " +
                                 "CONVERT(DECIMAL(21,2),ISNULL(TBL.YuzdeGelirSapmasi,0)) AS YuzdeGelirSapmasi,  " +
                                 "CONVERT(DECIMAL(21,2),ISNULL(TBL.YuzdeGiderSapmasi,0)) AS YuzdeGiderSapmasi FROM(  " +
                                 "SELECT SrmMrkAdi AS Bolge,#SorumlulukAdlari.SorumlulukMerkeziAdi AS SorumlulukMerkeziAdi,Yil,ButceGelir AS BelirlenenButceGelir, " +
                                 "CONVERT(DECIMAL(18,2),(ButceGelir/12* " + Degiskenler.DonemAraligi + ")) AS ButcelenenGelir, " +
                                 "(#GelirToplam.Toplam) AS GerceklesenGelir, " +
                                 "ButceGider AS BelirlenenButceGider,  " +
                                 "CONVERT(DECIMAL(18,2),(ButceGider/12* " + Degiskenler.DonemAraligi + ")) AS ButcelenenGider, " +
                                 "-1*(#GiderToplam.Toplam) AS GerceklesenGider,-1*(CONVERT(DECIMAL(18,2),(ButceGelir/12* " + Degiskenler.DonemAraligi + "))-( " +
                                 "(#GelirToplam.Toplam))) AS ButcelenenGerceklesenGelir,(CONVERT(DECIMAL(18,2),(ButceGider/12* " + Degiskenler.DonemAraligi + "))-( " +
                                 "-1*#GiderToplam.Toplam)) AS ButcelenenGerceklesenGider,(  " +
                                 "((#GelirToplam.Toplam)  " +
                                 "-CONVERT(DECIMAL(18,2),(ButceGelir/12* " + Degiskenler.DonemAraligi + ")))/(CONVERT(DECIMAL(18,2),(ButceGelir/12* " + Degiskenler.DonemAraligi + "))) " +
                                 ")AS YuzdeGelirSapmasi,-1*(  " +
                                 "((#GiderToplam.Toplam)  " +
                                 "-CONVERT(DECIMAL(18,2),(ButceGider/12* " + Degiskenler.DonemAraligi + ")))/(CONVERT(DECIMAL(18,2),(ButceGider/12* " + Degiskenler.DonemAraligi + "))) " +
                                 ") AS YuzdeGiderSapmasi  " +
                                 "FROM " + Degiskenler.RaporVeritabani + ".dbo.Butce    " +
                                 "INNER JOIN #SorumlulukAdlari ON SrmMrkKodu COLLATE TURKISH_CI_AI=#SorumlulukAdlari.SorumlulukKodlari  COLLATE TURKISH_CI_AI  " +
                                 "LEFT JOIN #GelirToplam ON SrmMrkKodu  COLLATE TURKISH_CI_AI=#GelirToplam.SrmKodu  COLLATE TURKISH_CI_AI  " +
                                 "LEFT JOIN #GiderToplam ON SrmMrkKodu  COLLATE TURKISH_CI_AI=#GiderToplam.SrmKodu  COLLATE TURKISH_CI_AI  " +
                                 ") AS TBL " +
                                 "DROP TABLE #Gelir " +
                                 "DROP TABLE #Gider " +
                                 "DROP TABLE #SorumlulukAdlari " +
                                 "DROP TABLE #GelirToplam  " +
                                 "DROP TABLE #GiderToplam";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                dsRaporlama.ButceAnalizRaporu.Clear();
                da.Fill(dsRaporlama.ButceAnalizRaporu);
                grdButceAnalizi.DataSource = dsRaporlama.ButceAnalizRaporu;
            }
        }

        private void ButceAnalizi_Load(object sender, EventArgs e)
        {
            tarih1.Text = "01.01." + DateTime.Now.Year.ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            cmbDonemAraligi.SelectedIndex = 0;

        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsRaporlama.ButceAnalizRaporu.Clear();
        }

        private void btnSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ButceAnalizi(fn_smCek());
        }

        private void btnExceleAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void ps_ciktiXls()
        {
            if (gridView1.RowCount > 0)
            {
                raporKaydet.Title = "Rapor Kaydet!";
                raporKaydet.DefaultExt = "Rapor Kaydet";
                raporKaydet.Filter = "Excel Dosyaları (*.xls)|*.xls";

                DialogResult = raporKaydet.ShowDialog();
                if (DialogResult == DialogResult.OK || DialogResult == DialogResult.Yes)
                {
                    grdButceAnalizi.ExportToExcelOld(raporKaydet.FileName);
                }
            }
        }
    }
}
