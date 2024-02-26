namespace Verda_Hukuk_Raporlama.Butce
{
    partial class ButceModulu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButceModulu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnYeniButce = new DevExpress.XtraBars.BarButtonItem();
            this.btnButceSil = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdButce = new DevExpress.XtraGrid.GridControl();
            this.butceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRaporlama = new Verda_Hukuk_Raporlama.dsRaporlama();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colButceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSorumluluk_Merkezi_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSorumluluk_Merkezi_Kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButce_Gelir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButce_Gider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSrmMrkzAdi = new System.Windows.Forms.ComboBox();
            this.cmbSrmMrkzKodu = new System.Windows.Forms.ComboBox();
            this.btnButceDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnButceTanimiKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.txtButceGider = new System.Windows.Forms.TextBox();
            this.txtButceGelir = new System.Windows.Forms.TextBox();
            this.lblDonem = new DevExpress.XtraEditors.LabelControl();
            this.lblButceGider = new DevExpress.XtraEditors.LabelControl();
            this.lblButceGelir = new DevExpress.XtraEditors.LabelControl();
            this.lblSrmMrkKodu = new DevExpress.XtraEditors.LabelControl();
            this.lblSrmMrkAdi = new DevExpress.XtraEditors.LabelControl();
            this.butceTableAdapter = new Verda_Hukuk_Raporlama.dsRaporlamaTableAdapters.ButceTableAdapter();
            this.tblSrmMrkzAdiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSrmMrkzAdiTableAdapter = new Verda_Hukuk_Raporlama.dsRaporlamaTableAdapters.tblSrmMrkzAdiTableAdapter();
            this.tblSrmMrkzKoduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSrmMrkzKoduTableAdapter = new Verda_Hukuk_Raporlama.dsRaporlamaTableAdapters.tblSrmMrkzKoduTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdButce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSrmMrkzAdiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSrmMrkzKoduBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.menu24x24;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnYenile,
            this.btnYeniButce,
            this.btnButceSil});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYenile, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYeniButce, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnButceSil, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnYenile
            // 
            this.btnYenile.Caption = "Yenile";
            this.btnYenile.Id = 0;
            this.btnYenile.ImageIndex = 6;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYenile_ItemClick);
            // 
            // btnYeniButce
            // 
            this.btnYeniButce.Caption = "Yeni Bütçe";
            this.btnYeniButce.Id = 4;
            this.btnYeniButce.ImageIndex = 10;
            this.btnYeniButce.Name = "btnYeniButce";
            this.btnYeniButce.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniButce_ItemClick);
            // 
            // btnButceSil
            // 
            this.btnButceSil.Caption = "Bütçe Sil";
            this.btnButceSil.Id = 5;
            this.btnButceSil.ImageIndex = 2;
            this.btnButceSil.Name = "btnButceSil";
            this.btnButceSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnButceSil_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(884, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 476);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(884, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
            // 
            // menu24x24
            // 
            this.menu24x24.ImageSize = new System.Drawing.Size(24, 24);
            this.menu24x24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("menu24x24.ImageStream")));
            this.menu24x24.Images.SetKeyName(0, "ButceAnalizi.png");
            this.menu24x24.Images.SetKeyName(1, "ButceAyari.png");
            this.menu24x24.Images.SetKeyName(2, "butcesil.png");
            this.menu24x24.Images.SetKeyName(3, "Download.png");
            this.menu24x24.Images.SetKeyName(4, "Kaydet.png");
            this.menu24x24.Images.SetKeyName(5, "login.png");
            this.menu24x24.Images.SetKeyName(6, "Refresh.png");
            this.menu24x24.Images.SetKeyName(7, "saat.png");
            this.menu24x24.Images.SetKeyName(8, "sirket.png");
            this.menu24x24.Images.SetKeyName(9, "verdahukuk.png");
            this.menu24x24.Images.SetKeyName(10, "yeni.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdButce);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 444);
            this.panel1.TabIndex = 4;
            // 
            // grdButce
            // 
            this.grdButce.DataSource = this.butceBindingSource;
            this.grdButce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdButce.Location = new System.Drawing.Point(0, 0);
            this.grdButce.MainView = this.gridView1;
            this.grdButce.MenuManager = this.barManager1;
            this.grdButce.Name = "grdButce";
            this.grdButce.Size = new System.Drawing.Size(416, 444);
            this.grdButce.TabIndex = 0;
            this.grdButce.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // butceBindingSource
            // 
            this.butceBindingSource.DataMember = "Butce";
            this.butceBindingSource.DataSource = this.dsRaporlama;
            // 
            // dsRaporlama
            // 
            this.dsRaporlama.DataSetName = "dsRaporlama";
            this.dsRaporlama.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colButceID,
            this.colSorumluluk_Merkezi_Adi,
            this.colSorumluluk_Merkezi_Kodu,
            this.colButce_Gelir,
            this.colButce_Gider,
            this.colYil});
            this.gridView1.GridControl = this.grdButce;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colButceID
            // 
            this.colButceID.FieldName = "ButceID";
            this.colButceID.Name = "colButceID";
            this.colButceID.OptionsColumn.ReadOnly = true;
            // 
            // colSorumluluk_Merkezi_Adi
            // 
            this.colSorumluluk_Merkezi_Adi.Caption = "Sorumluluk Merkezi Adı";
            this.colSorumluluk_Merkezi_Adi.FieldName = "Sorumluluk_Merkezi_Adi";
            this.colSorumluluk_Merkezi_Adi.Name = "colSorumluluk_Merkezi_Adi";
            this.colSorumluluk_Merkezi_Adi.Visible = true;
            this.colSorumluluk_Merkezi_Adi.VisibleIndex = 0;
            // 
            // colSorumluluk_Merkezi_Kodu
            // 
            this.colSorumluluk_Merkezi_Kodu.Caption = "Sorumluluk Merkezi Kodu";
            this.colSorumluluk_Merkezi_Kodu.FieldName = "Sorumluluk_Merkezi_Kodu";
            this.colSorumluluk_Merkezi_Kodu.Name = "colSorumluluk_Merkezi_Kodu";
            this.colSorumluluk_Merkezi_Kodu.Visible = true;
            this.colSorumluluk_Merkezi_Kodu.VisibleIndex = 1;
            // 
            // colButce_Gelir
            // 
            this.colButce_Gelir.Caption = "Bütçe Gelir";
            this.colButce_Gelir.FieldName = "Butce_Gelir";
            this.colButce_Gelir.Name = "colButce_Gelir";
            this.colButce_Gelir.Visible = true;
            this.colButce_Gelir.VisibleIndex = 2;
            // 
            // colButce_Gider
            // 
            this.colButce_Gider.Caption = "Bütçe Gider";
            this.colButce_Gider.FieldName = "Butce_Gider";
            this.colButce_Gider.Name = "colButce_Gider";
            this.colButce_Gider.Visible = true;
            this.colButce_Gider.VisibleIndex = 3;
            // 
            // colYil
            // 
            this.colYil.Caption = "Yıl";
            this.colYil.FieldName = "Yil";
            this.colYil.Name = "colYil";
            this.colYil.Visible = true;
            this.colYil.VisibleIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtraTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(416, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 444);
            this.panel2.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(468, 444);
            this.xtraTabControl1.TabIndex = 33;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtID);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.cmbSrmMrkzAdi);
            this.xtraTabPage1.Controls.Add(this.cmbSrmMrkzKodu);
            this.xtraTabPage1.Controls.Add(this.btnButceDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnButceTanimiKaydet);
            this.xtraTabPage1.Controls.Add(this.cmbYil);
            this.xtraTabPage1.Controls.Add(this.txtButceGider);
            this.xtraTabPage1.Controls.Add(this.txtButceGelir);
            this.xtraTabPage1.Controls.Add(this.lblDonem);
            this.xtraTabPage1.Controls.Add(this.lblButceGider);
            this.xtraTabPage1.Controls.Add(this.lblButceGelir);
            this.xtraTabPage1.Controls.Add(this.lblSrmMrkKodu);
            this.xtraTabPage1.Controls.Add(this.lblSrmMrkAdi);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(462, 416);
            this.xtraTabPage1.Text = "Bütçe Tanımı";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.butceBindingSource, "ButceID", true));
            this.txtID.Location = new System.Drawing.Point(170, 23);
            this.txtID.MenuManager = this.barManager1;
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(260, 20);
            this.txtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(13, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 20);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "ID";
            // 
            // cmbSrmMrkzAdi
            // 
            this.cmbSrmMrkzAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSrmMrkzAdi.FormattingEnabled = true;
            this.cmbSrmMrkzAdi.Location = new System.Drawing.Point(170, 48);
            this.cmbSrmMrkzAdi.Name = "cmbSrmMrkzAdi";
            this.cmbSrmMrkzAdi.Size = new System.Drawing.Size(260, 21);
            this.cmbSrmMrkzAdi.TabIndex = 2;
            this.cmbSrmMrkzAdi.SelectedIndexChanged += new System.EventHandler(this.cmbSrmMrkzAdi_SelectedIndexChanged);
            // 
            // cmbSrmMrkzKodu
            // 
            this.cmbSrmMrkzKodu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSrmMrkzKodu.FormattingEnabled = true;
            this.cmbSrmMrkzKodu.Location = new System.Drawing.Point(170, 74);
            this.cmbSrmMrkzKodu.Name = "cmbSrmMrkzKodu";
            this.cmbSrmMrkzKodu.Size = new System.Drawing.Size(260, 21);
            this.cmbSrmMrkzKodu.TabIndex = 3;
            // 
            // btnButceDuzenle
            // 
            this.btnButceDuzenle.Location = new System.Drawing.Point(298, 191);
            this.btnButceDuzenle.Name = "btnButceDuzenle";
            this.btnButceDuzenle.Size = new System.Drawing.Size(132, 23);
            this.btnButceDuzenle.TabIndex = 7;
            this.btnButceDuzenle.Text = "&Bütçe Düzenle";
            this.btnButceDuzenle.Click += new System.EventHandler(this.btnButceDuzenle_Click);
            // 
            // btnButceTanimiKaydet
            // 
            this.btnButceTanimiKaydet.Location = new System.Drawing.Point(170, 191);
            this.btnButceTanimiKaydet.Name = "btnButceTanimiKaydet";
            this.btnButceTanimiKaydet.Size = new System.Drawing.Size(122, 23);
            this.btnButceTanimiKaydet.TabIndex = 7;
            this.btnButceTanimiKaydet.Text = "&Bütçe Kaydet";
            this.btnButceTanimiKaydet.Click += new System.EventHandler(this.btnButceTanimiKaydet_Click);
            // 
            // cmbYil
            // 
            this.cmbYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYil.Font = new System.Drawing.Font("Calibri", 9F);
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(170, 151);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(260, 22);
            this.cmbYil.TabIndex = 6;
            // 
            // txtButceGider
            // 
            this.txtButceGider.Location = new System.Drawing.Point(170, 126);
            this.txtButceGider.Name = "txtButceGider";
            this.txtButceGider.Size = new System.Drawing.Size(260, 20);
            this.txtButceGider.TabIndex = 5;
            // 
            // txtButceGelir
            // 
            this.txtButceGelir.Location = new System.Drawing.Point(170, 100);
            this.txtButceGelir.Name = "txtButceGelir";
            this.txtButceGelir.Size = new System.Drawing.Size(260, 20);
            this.txtButceGelir.TabIndex = 4;
            // 
            // lblDonem
            // 
            this.lblDonem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDonem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDonem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblDonem.Location = new System.Drawing.Point(13, 153);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(157, 20);
            this.lblDonem.TabIndex = 75;
            this.lblDonem.Text = "Bütçe Dönemi";
            // 
            // lblButceGider
            // 
            this.lblButceGider.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblButceGider.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblButceGider.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblButceGider.Location = new System.Drawing.Point(13, 126);
            this.lblButceGider.Name = "lblButceGider";
            this.lblButceGider.Size = new System.Drawing.Size(157, 21);
            this.lblButceGider.TabIndex = 73;
            this.lblButceGider.Text = "Bütçe Gideri";
            // 
            // lblButceGelir
            // 
            this.lblButceGelir.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblButceGelir.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblButceGelir.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblButceGelir.Location = new System.Drawing.Point(13, 101);
            this.lblButceGelir.Name = "lblButceGelir";
            this.lblButceGelir.Size = new System.Drawing.Size(157, 20);
            this.lblButceGelir.TabIndex = 73;
            this.lblButceGelir.Text = "Bütçe Gelir";
            // 
            // lblSrmMrkKodu
            // 
            this.lblSrmMrkKodu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSrmMrkKodu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSrmMrkKodu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblSrmMrkKodu.Location = new System.Drawing.Point(13, 75);
            this.lblSrmMrkKodu.Name = "lblSrmMrkKodu";
            this.lblSrmMrkKodu.Size = new System.Drawing.Size(157, 20);
            this.lblSrmMrkKodu.TabIndex = 73;
            this.lblSrmMrkKodu.Text = "Sorumluluk Merkezi Kodu";
            // 
            // lblSrmMrkAdi
            // 
            this.lblSrmMrkAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSrmMrkAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSrmMrkAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblSrmMrkAdi.Location = new System.Drawing.Point(13, 49);
            this.lblSrmMrkAdi.Name = "lblSrmMrkAdi";
            this.lblSrmMrkAdi.Size = new System.Drawing.Size(157, 20);
            this.lblSrmMrkAdi.TabIndex = 73;
            this.lblSrmMrkAdi.Text = "Sorumluluk Merkezi Adı";
            // 
            // butceTableAdapter
            // 
            this.butceTableAdapter.ClearBeforeFill = true;
            // 
            // tblSrmMrkzAdiBindingSource
            // 
            this.tblSrmMrkzAdiBindingSource.DataMember = "tblSrmMrkzAdi";
            this.tblSrmMrkzAdiBindingSource.DataSource = this.dsRaporlama;
            // 
            // tblSrmMrkzAdiTableAdapter
            // 
            this.tblSrmMrkzAdiTableAdapter.ClearBeforeFill = true;
            // 
            // tblSrmMrkzKoduBindingSource
            // 
            this.tblSrmMrkzKoduBindingSource.DataMember = "tblSrmMrkzKodu";
            this.tblSrmMrkzKoduBindingSource.DataSource = this.dsRaporlama;
            // 
            // tblSrmMrkzKoduTableAdapter
            // 
            this.tblSrmMrkzKoduTableAdapter.ClearBeforeFill = true;
            // 
            // ButceModulu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ButceModulu";
            this.Text = "Bütçe Modülü";
            this.Load += new System.EventHandler(this.ButceModulu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdButce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSrmMrkzAdiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSrmMrkzKoduBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btnYeniButce;
        private DevExpress.XtraBars.BarButtonItem btnButceSil;
        private DevExpress.Utils.ImageCollection menu24x24;
        private DevExpress.XtraGrid.GridControl grdButce;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsRaporlama dsRaporlama;
        private System.Windows.Forms.BindingSource butceBindingSource;
        private dsRaporlamaTableAdapters.ButceTableAdapter butceTableAdapter;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbSrmMrkzAdi;
        private System.Windows.Forms.ComboBox cmbSrmMrkzKodu;
        private DevExpress.XtraEditors.SimpleButton btnButceDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnButceTanimiKaydet;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.TextBox txtButceGider;
        private System.Windows.Forms.TextBox txtButceGelir;
        private DevExpress.XtraEditors.LabelControl lblDonem;
        private DevExpress.XtraEditors.LabelControl lblButceGider;
        private DevExpress.XtraEditors.LabelControl lblButceGelir;
        private DevExpress.XtraEditors.LabelControl lblSrmMrkKodu;
        private DevExpress.XtraEditors.LabelControl lblSrmMrkAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colButceID;
        private DevExpress.XtraGrid.Columns.GridColumn colSorumluluk_Merkezi_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn colSorumluluk_Merkezi_Kodu;
        private DevExpress.XtraGrid.Columns.GridColumn colButce_Gelir;
        private DevExpress.XtraGrid.Columns.GridColumn colButce_Gider;
        private DevExpress.XtraGrid.Columns.GridColumn colYil;
        private System.Windows.Forms.BindingSource tblSrmMrkzAdiBindingSource;
        private dsRaporlamaTableAdapters.tblSrmMrkzAdiTableAdapter tblSrmMrkzAdiTableAdapter;
        private System.Windows.Forms.BindingSource tblSrmMrkzKoduBindingSource;
        private dsRaporlamaTableAdapters.tblSrmMrkzKoduTableAdapter tblSrmMrkzKoduTableAdapter;
    }
}