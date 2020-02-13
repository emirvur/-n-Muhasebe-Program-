namespace netsatis.backoffice.FrmAnaMenu.OdemeTuru
{
    partial class FrmOdemeTuruHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuruHareket));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContodemeHareket = new DevExpress.XtraGrid.GridControl();
            this.gridodeme = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOdemeTuruToplam = new DevExpress.XtraGrid.GridControl();
            this.gridodemettopl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridGeneltoplam = new DevExpress.XtraGrid.GridControl();
            this.gridgeneltopl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colislem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayitsayi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridkasakod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColkasaad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridkasagiri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColkasacikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColbakiyr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColkasaadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColkasakod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContodemeHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridodeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridodemettopl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneltoplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridgeneltopl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.ImageOptions.Image")));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(752, 36);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Ödeme Türü Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 336);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(752, 78);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.Text = "Menü";
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.ImageIndex = 0;
            this.btnguncelle.Location = new System.Drawing.Point(105, 31);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(73, 35);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 6;
            this.btnkapat.Location = new System.Drawing.Point(665, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnara
            // 
            this.btnara.ImageOptions.ImageIndex = 5;
            this.btnara.Location = new System.Drawing.Point(12, 31);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(73, 35);
            this.btnara.TabIndex = 0;
            this.btnara.Text = "ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 36);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContodemeHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(752, 300);
            this.splitContainerControl1.SplitterPosition = 126;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridOdemeTuruToplam);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridGeneltoplam);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(752, 169);
            this.splitContainerControl2.SplitterPosition = 367;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // gridContodemeHareket
            // 
            this.gridContodemeHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContodemeHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContodemeHareket.MainView = this.gridodeme;
            this.gridContodemeHareket.Name = "gridContodemeHareket";
            this.gridContodemeHareket.Size = new System.Drawing.Size(752, 126);
            this.gridContodemeHareket.TabIndex = 4;
            this.gridContodemeHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridodeme});
            // 
            // gridodeme
            // 
            this.gridodeme.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.gridColkasakod,
            this.gridColkasaadi,
            this.colCariAdi,
            this.colCariKodu,
            this.colsaat,
            this.colTarih,
            this.colaciklama,
            this.colTutar});
            this.gridodeme.GridControl = this.gridContodemeHareket;
            this.gridodeme.Name = "gridodeme";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 2;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 5;
            // 
            // colsaat
            // 
            this.colsaat.Caption = "Saat";
            this.colsaat.FieldName = "Saat";
            this.colsaat.Name = "colsaat";
            this.colsaat.Visible = true;
            this.colsaat.VisibleIndex = 7;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 6;
            // 
            // colaciklama
            // 
            this.colaciklama.Caption = "Açıklama";
            this.colaciklama.FieldName = "Aciklama";
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.Visible = true;
            this.colaciklama.VisibleIndex = 9;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 8;
            // 
            // gridOdemeTuruToplam
            // 
            this.gridOdemeTuruToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOdemeTuruToplam.Location = new System.Drawing.Point(0, 0);
            this.gridOdemeTuruToplam.MainView = this.gridodemettopl;
            this.gridOdemeTuruToplam.Name = "gridOdemeTuruToplam";
            this.gridOdemeTuruToplam.Size = new System.Drawing.Size(367, 169);
            this.gridOdemeTuruToplam.TabIndex = 4;
            this.gridOdemeTuruToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridodemettopl});
            // 
            // gridodemettopl
            // 
            this.gridodemettopl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridkasakod,
            this.gridColkasaad,
            this.gridkasagiri,
            this.gridColkasacikis,
            this.gridColbakiyr});
            this.gridodemettopl.GridControl = this.gridOdemeTuruToplam;
            this.gridodemettopl.Name = "gridodemettopl";
            this.gridodemettopl.OptionsView.ShowGroupPanel = false;
            // 
            // gridGeneltoplam
            // 
            this.gridGeneltoplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGeneltoplam.Location = new System.Drawing.Point(0, 0);
            this.gridGeneltoplam.MainView = this.gridgeneltopl;
            this.gridGeneltoplam.Name = "gridGeneltoplam";
            this.gridGeneltoplam.Size = new System.Drawing.Size(380, 169);
            this.gridGeneltoplam.TabIndex = 4;
            this.gridGeneltoplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridgeneltopl});
            // 
            // gridgeneltopl
            // 
            this.gridgeneltopl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colislem,
            this.colkayitsayi,
            this.colToplam});
            this.gridgeneltopl.GridControl = this.gridGeneltoplam;
            this.gridgeneltopl.Name = "gridgeneltopl";
            this.gridgeneltopl.OptionsView.ShowGroupPanel = false;
            // 
            // colislem
            // 
            this.colislem.Caption = "İşlem";
            this.colislem.FieldName = "Islem";
            this.colislem.Name = "colislem";
            this.colislem.Visible = true;
            this.colislem.VisibleIndex = 0;
            // 
            // colkayitsayi
            // 
            this.colkayitsayi.Caption = "Kayıt Sayısı";
            this.colkayitsayi.FieldName = "KayitSayisi";
            this.colkayitsayi.Name = "colkayitsayi";
            this.colkayitsayi.Visible = true;
            this.colkayitsayi.VisibleIndex = 1;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Toplam";
            this.colToplam.FieldName = "Toplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 2;
            // 
            // gridkasakod
            // 
            this.gridkasakod.Caption = "Kasa Kodu";
            this.gridkasakod.FieldName = "KasaKodu";
            this.gridkasakod.Name = "gridkasakod";
            this.gridkasakod.Visible = true;
            this.gridkasakod.VisibleIndex = 0;
            // 
            // gridColkasaad
            // 
            this.gridColkasaad.Caption = "Kasa Adı";
            this.gridColkasaad.FieldName = "KasaAdi";
            this.gridColkasaad.Name = "gridColkasaad";
            this.gridColkasaad.Visible = true;
            this.gridColkasaad.VisibleIndex = 1;
            // 
            // gridkasagiri
            // 
            this.gridkasagiri.Caption = "Kasa Giriş";
            this.gridkasagiri.FieldName = "KasaGiris";
            this.gridkasagiri.Name = "gridkasagiri";
            this.gridkasagiri.Visible = true;
            this.gridkasagiri.VisibleIndex = 2;
            // 
            // gridColkasacikis
            // 
            this.gridColkasacikis.Caption = "Kasa Çıkış";
            this.gridColkasacikis.FieldName = "KasaCikis";
            this.gridColkasacikis.Name = "gridColkasacikis";
            this.gridColkasacikis.Visible = true;
            this.gridColkasacikis.VisibleIndex = 3;
            // 
            // gridColbakiyr
            // 
            this.gridColbakiyr.Caption = "Bakiye";
            this.gridColbakiyr.FieldName = "Bakiye";
            this.gridColbakiyr.Name = "gridColbakiyr";
            this.gridColbakiyr.Visible = true;
            this.gridColbakiyr.VisibleIndex = 4;
            // 
            // gridColkasaadi
            // 
            this.gridColkasaadi.Caption = "Kasa Adı";
            this.gridColkasaadi.FieldName = "KasaAdi";
            this.gridColkasaadi.Name = "gridColkasaadi";
            this.gridColkasaadi.Visible = true;
            this.gridColkasaadi.VisibleIndex = 4;
            // 
            // gridColkasakod
            // 
            this.gridColkasakod.Caption = "Kasa Kodu";
            this.gridColkasakod.FieldName = "KasaKodu";
            this.gridColkasakod.Name = "gridColkasakod";
            this.gridColkasakod.Visible = true;
            this.gridColkasakod.VisibleIndex = 3;
            // 
            // FrmOdemeTuruHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 414);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmOdemeTuruHareket";
            this.Text = "FrmOdemeTuruHareket";
            this.Load += new System.EventHandler(this.FrmOdemeTuruHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContodemeHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridodeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridodemettopl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneltoplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridgeneltopl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridContodemeHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridodeme;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colsaat;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.GridControl gridOdemeTuruToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridodemettopl;
        private DevExpress.XtraGrid.GridControl gridGeneltoplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridgeneltopl;
        private DevExpress.XtraGrid.Columns.GridColumn colislem;
        private DevExpress.XtraGrid.Columns.GridColumn colkayitsayi;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraGrid.Columns.GridColumn gridColkasakod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColkasaadi;
        private DevExpress.XtraGrid.Columns.GridColumn gridkasakod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColkasaad;
        private DevExpress.XtraGrid.Columns.GridColumn gridkasagiri;
        private DevExpress.XtraGrid.Columns.GridColumn gridColkasacikis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColbakiyr;
    }
}