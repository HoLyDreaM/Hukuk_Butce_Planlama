namespace Hukuk_Butce_Planlama
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLoginAyari = new DevExpress.XtraBars.BarButtonItem();
            this.btnButceAyari = new DevExpress.XtraBars.BarButtonItem();
            this.btnButceAnalizi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnFonksiyonlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.lbSm = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSrmMrkzHepsiniKaldir = new System.Windows.Forms.Button();
            this.btnSrmMrkzHepsiniSec = new System.Windows.Forms.Button();
            this.BarMenuStilAyari = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timerTarih = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSirketName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSirket = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKayanYazi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarihAyari = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.alertControl2 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbSm)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLoginAyari,
            this.btnButceAyari,
            this.btnButceAnalizi,
            this.btnGuncelle,
            this.btnFonksiyonlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(875, 140);
            // 
            // btnLoginAyari
            // 
            this.btnLoginAyari.Caption = "Giriş Ayarı";
            this.btnLoginAyari.Id = 1;
            this.btnLoginAyari.LargeGlyph = global::Hukuk_Butce_Planlama.Properties.Resources.login;
            this.btnLoginAyari.LargeWidth = 80;
            this.btnLoginAyari.Name = "btnLoginAyari";
            this.btnLoginAyari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoginAyari_ItemClick);
            // 
            // btnButceAyari
            // 
            this.btnButceAyari.Caption = "Bütçe Ayarları";
            this.btnButceAyari.Id = 3;
            this.btnButceAyari.LargeGlyph = global::Hukuk_Butce_Planlama.Properties.Resources.ButceAyari;
            this.btnButceAyari.LargeWidth = 80;
            this.btnButceAyari.Name = "btnButceAyari";
            this.btnButceAyari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnButceAyari_ItemClick);
            // 
            // btnButceAnalizi
            // 
            this.btnButceAnalizi.Caption = "Bütçe Analizi";
            this.btnButceAnalizi.Id = 4;
            this.btnButceAnalizi.LargeGlyph = global::Hukuk_Butce_Planlama.Properties.Resources.ButceAnalizi;
            this.btnButceAnalizi.LargeWidth = 80;
            this.btnButceAnalizi.Name = "btnButceAnalizi";
            this.btnButceAnalizi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnButceAnalizi_ItemClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Caption = "Güncelle";
            this.btnGuncelle.Id = 5;
            this.btnGuncelle.LargeGlyph = global::Hukuk_Butce_Planlama.Properties.Resources.Download;
            this.btnGuncelle.LargeWidth = 80;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuncelle_ItemClick);
            // 
            // btnFonksiyonlar
            // 
            this.btnFonksiyonlar.Caption = "Fonksiyonlar";
            this.btnFonksiyonlar.Id = 6;
            this.btnFonksiyonlar.LargeGlyph = global::Hukuk_Butce_Planlama.Properties.Resources.Fonksiyonlar;
            this.btnFonksiyonlar.LargeWidth = 80;
            this.btnFonksiyonlar.Name = "btnFonksiyonlar";
            this.btnFonksiyonlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFonksiyonlar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLoginAyari);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnFonksiyonlar);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnButceAyari);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnButceAnalizi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGuncelle);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(875, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 518);
            this.barDockControlBottom.Size = new System.Drawing.Size(875, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(875, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2,
            this.dockPanel1});
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel3});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel2.FloatVertical = true;
            this.dockPanel2.ID = new System.Guid("cd3cbe24-a03f-428a-9146-09d087cf2e23");
            this.dockPanel2.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedIndex = 1;
            this.dockPanel2.Size = new System.Drawing.Size(200, 200);
            this.dockPanel2.Text = "dockPanel2";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(192, 171);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.FloatLocation = new System.Drawing.Point(53, 210);
            this.dockPanel1.ID = new System.Guid("4bda484b-9fbb-4b6b-98de-13447c3a0607");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 200);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 171);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel3.FloatVertical = true;
            this.dockPanel3.ID = new System.Guid("c81aff30-8abb-4426-b95e-3117131a7575");
            this.dockPanel3.Location = new System.Drawing.Point(0, 140);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.Options.ShowCloseButton = false;
            this.dockPanel3.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel3.Size = new System.Drawing.Size(200, 378);
            this.dockPanel3.Text = "Sorumluluk Merkezleri";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.lbSm);
            this.dockPanel3_Container.Controls.Add(this.panel1);
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(192, 349);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // lbSm
            // 
            this.lbSm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSm.Location = new System.Drawing.Point(0, 25);
            this.lbSm.Name = "lbSm";
            this.lbSm.Size = new System.Drawing.Size(192, 324);
            this.lbSm.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSrmMrkzHepsiniKaldir);
            this.panel1.Controls.Add(this.btnSrmMrkzHepsiniSec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 25);
            this.panel1.TabIndex = 0;
            // 
            // btnSrmMrkzHepsiniKaldir
            // 
            this.btnSrmMrkzHepsiniKaldir.Image = global::Hukuk_Butce_Planlama.Properties.Resources._1357141513_to_do_list;
            this.btnSrmMrkzHepsiniKaldir.Location = new System.Drawing.Point(28, 0);
            this.btnSrmMrkzHepsiniKaldir.Name = "btnSrmMrkzHepsiniKaldir";
            this.btnSrmMrkzHepsiniKaldir.Size = new System.Drawing.Size(25, 23);
            this.btnSrmMrkzHepsiniKaldir.TabIndex = 9;
            this.btnSrmMrkzHepsiniKaldir.UseVisualStyleBackColor = true;
            this.btnSrmMrkzHepsiniKaldir.Click += new System.EventHandler(this.btnSrmMrkzHepsiniKaldir_Click);
            // 
            // btnSrmMrkzHepsiniSec
            // 
            this.btnSrmMrkzHepsiniSec.Image = global::Hukuk_Butce_Planlama.Properties.Resources._1357141503_to_do_list_cheked_all;
            this.btnSrmMrkzHepsiniSec.Location = new System.Drawing.Point(2, 0);
            this.btnSrmMrkzHepsiniSec.Name = "btnSrmMrkzHepsiniSec";
            this.btnSrmMrkzHepsiniSec.Size = new System.Drawing.Size(26, 23);
            this.btnSrmMrkzHepsiniSec.TabIndex = 8;
            this.btnSrmMrkzHepsiniSec.UseVisualStyleBackColor = true;
            this.btnSrmMrkzHepsiniSec.Click += new System.EventHandler(this.btnSrmMrkzHepsiniSec_Click);
            // 
            // BarMenuStilAyari
            // 
            this.BarMenuStilAyari.LookAndFeel.SkinName = "Office 2010 Silver";
            // 
            // timerTarih
            // 
            this.timerTarih.Enabled = true;
            this.timerTarih.Tick += new System.EventHandler(this.timerTarih_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSirketName,
            this.lblSirket,
            this.lblKayanYazi,
            this.lblTarihAyari,
            this.lblTarih});
            this.statusStrip1.Location = new System.Drawing.Point(200, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(675, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSirketName
            // 
            this.lblSirketName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSirketName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSirketName.Image = global::Hukuk_Butce_Planlama.Properties.Resources.sirket;
            this.lblSirketName.Name = "lblSirketName";
            this.lblSirketName.Size = new System.Drawing.Size(63, 17);
            this.lblSirketName.Text = "Şirket :";
            // 
            // lblSirket
            // 
            this.lblSirket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSirket.Name = "lblSirket";
            this.lblSirket.Size = new System.Drawing.Size(0, 17);
            // 
            // lblKayanYazi
            // 
            this.lblKayanYazi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKayanYazi.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKayanYazi.Name = "lblKayanYazi";
            this.lblKayanYazi.Size = new System.Drawing.Size(581, 17);
            this.lblKayanYazi.Spring = true;
            // 
            // lblTarihAyari
            // 
            this.lblTarihAyari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTarihAyari.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTarihAyari.Image = global::Hukuk_Butce_Planlama.Properties.Resources.saat;
            this.lblTarihAyari.Name = "lblTarihAyari";
            this.lblTarihAyari.Size = new System.Drawing.Size(16, 17);
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 17);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dockPanel3);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verda Hukuk Raporlama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbSm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblSirketName;
        public System.Windows.Forms.ToolStripStatusLabel lblSirket;
        private System.Windows.Forms.ToolStripStatusLabel lblKayanYazi;
        private System.Windows.Forms.ToolStripStatusLabel lblTarihAyari;
        private System.Windows.Forms.ToolStripStatusLabel lblTarih;
        private DevExpress.LookAndFeel.DefaultLookAndFeel BarMenuStilAyari;
        private System.Windows.Forms.Timer timerTarih;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.BarButtonItem btnLoginAyari;
        private DevExpress.XtraBars.BarButtonItem btnButceAyari;
        private DevExpress.XtraBars.BarButtonItem btnButceAnalizi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnGuncelle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnFonksiyonlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        public DevExpress.XtraEditors.CheckedListBoxControl lbSm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSrmMrkzHepsiniKaldir;
        private System.Windows.Forms.Button btnSrmMrkzHepsiniSec;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl2;
    }
}