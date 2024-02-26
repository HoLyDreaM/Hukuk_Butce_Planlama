using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Verda_Hukuk_Raporlama.Fonksiyonlar
{
    public partial class FonksiyonTanimlari : Form
    {
        public FonksiyonTanimlari()
        {
            InitializeComponent();
        }

        SqlConnection conFnk;
        SqlCommand cmdFnk;
        SqlDataReader drFnk;
        string veritabani;
        string Cs = Properties.Settings.Default.Cs;
        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\LoginSettings.ini");

        private void FonksiyonTanimlari_Load(object sender, EventArgs e)
        {
            FonksiyonDurumu();
        }

        private Int16 FnkKontrol()
        {
            conFnk = new SqlConnection(Cs);

            if (conFnk.State == ConnectionState.Closed)
                conFnk.Open();

            string sorgu = "SELECT COUNT(*) AS Durum FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_CariAdiBul]')";
            cmdFnk = new SqlCommand(sorgu, conFnk);
            return Convert.ToInt16(cmdFnk.ExecuteScalar());
        }

        private void FnkBilgileriniCek()
        {
            conFnk = new SqlConnection(Cs);

            if (conFnk.State == ConnectionState.Closed)
                conFnk.Open();

            string sorgu = "SELECT name,type,create_date FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_CariAdiBul]')";
            cmdFnk = new SqlCommand(sorgu, conFnk);
            drFnk = cmdFnk.ExecuteReader();

            while (drFnk.Read())
            {
                txtFonksiyonAdi.Text = drFnk["name"].ToString();
                txtTarih.Text = drFnk["create_date"].ToString();
            }

            conFnk.Dispose();
            conFnk.Close();
            drFnk.Dispose();
            drFnk.Close();
        }

        private void FonksiyonDurumu()
        {
            if (FnkKontrol() > 0)
            {
                txtDurum.Text = "Fonksiyon Oluşturulmuş";
                txtDurum.ForeColor = Color.Green;
                btnFnkOlustur.Enabled = false;
                btnFnkKaldir.Enabled = true;
                FnkBilgileriniCek();
            }
            else
            {
                txtDurum.Text = "Fonksiyon Oluşturulmamış";
                txtDurum.ForeColor = Color.Red;
                txtFonksiyonAdi.Text = "...";
                txtTarih.Text = "...";

                btnFnkOlustur.Enabled = true;
                btnFnkKaldir.Enabled = false;
            }
        }

        private void FnkOlustur()
        {
            conFnk = new SqlConnection(Cs);

            if (conFnk.State == ConnectionState.Closed)
                conFnk.Open();

            veritabani = iniOku.IniOku("Ayar", "LinkSirket");

            string sorgu = @"CREATE FUNCTION [dbo].[fn_CariAdiBul](@CariKodu NVARCHAR(50))
                            RETURNS NVARCHAR(250) AS
                            BEGIN
                            DECLARE @Unvan AS NVARCHAR(250) 

                            SET @Unvan=(
                            SELECT CAR002_Unvan1+' ' + CAR002_Unvan2 AS Unvan FROM YNS" + veritabani + ".CAR002 " +
                            @"WHERE CAR002_HesapKodu=@CariKodu)

                            RETURN @Unvan
                            END";
            cmdFnk = new SqlCommand(sorgu, conFnk);
            cmdFnk.ExecuteScalar();
            conFnk.Dispose();
            conFnk.Close();
            FonksiyonDurumu();
        }

        private void FnkKaldir()
        {
            conFnk = new SqlConnection(Cs);

            if (conFnk.State == ConnectionState.Closed)
                conFnk.Open();

            string sorgu = "IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_CariAdiBul]')) " +
                         "DROP FUNCTION [dbo].[fn_CariAdiBul];";
            cmdFnk = new SqlCommand(sorgu, conFnk);
            cmdFnk.ExecuteScalar();
            cmdFnk.Dispose();
            conFnk.Dispose();
            conFnk.Close();
            FonksiyonDurumu();
        }

        private void btnFnkOlustur_Click(object sender, EventArgs e)
        {
            FnkOlustur();
        }

        private void btnFnkKaldir_Click(object sender, EventArgs e)
        {
            DialogResult Secim;
            Secim = MessageBox.Show(this, "Fonksiyonu Silmek İstediğinize Emin Misiniz?", "Uyarı..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Secim == DialogResult.Yes)
            {
                FnkKaldir();
            }
        }
    }
}
