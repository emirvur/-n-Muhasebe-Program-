namespace netsatis.backoffice.FrmAnaMenu.Kasa
{
    partial class FrmKasaHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaHareket));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContkasaHareket = new DevExpress.XtraGrid.GridControl();
            this.kasaHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridkasalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridOdemeTuruToplam = new DevExpress.XtraGrid.GridControl();
            this.gridodemettopl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colodemetur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkasagir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collkasacik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGeneltoplam = new DevExpress.XtraGrid.GridControl();
            this.gridgeneltopl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayitsayi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContkasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridkasalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(799, 36);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Kasa Hareketleri";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 326);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(799, 78);
            this.grpMenu.TabIndex = 4;
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
            this.btnkapat.Location = new System.Drawing.Point(712, 31);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContkasaHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(799, 290);
            this.splitContainerControl1.SplitterPosition = 136;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // gridContkasaHareket
            // 
            this.gridContkasaHareket.DataSource = this.kasaHareketBindingSource;
            this.gridContkasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContkasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContkasaHareket.MainView = this.gridkasalar;
            this.gridContkasaHareket.Name = "gridContkasaHareket";
            this.gridContkasaHareket.Size = new System.Drawing.Size(799, 136);
            this.gridContkasaHareket.TabIndex = 3;
            this.gridContkasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridkasalar});
            // 
            // kasaHareketBindingSource
            // 
            this.kasaHareketBindingSource.DataSource = typeof(netsatis.tables.KasaHareket);
            // 
            // gridkasalar
            // 
            this.gridkasalar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colOdemeTuruadi,
            this.colCariAdi,
            this.colCariKodu,
            this.colsaat,
            this.colTarih,
            this.colaciklama,
            this.colTutar});
            this.gridkasalar.GridControl = this.gridContkasaHareket;
            this.gridkasalar.Name = "gridkasalar";
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
            // colOdemeTuruadi
            // 
            this.colOdemeTuruadi.Caption = "Odeme Turu";
            this.colOdemeTuruadi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruadi.Name = "colOdemeTuruadi";
            this.colOdemeTuruadi.Visible = true;
            this.colOdemeTuruadi.VisibleIndex = 2;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 3;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 4;
            // 
            // colsaat
            // 
            this.colsaat.Caption = "Saat";
            this.colsaat.FieldName = "Saat";
            this.colsaat.Name = "colsaat";
            this.colsaat.Visible = true;
            this.colsaat.VisibleIndex = 6;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            // 
            // colaciklama
            // 
            this.colaciklama.Caption = "Açıklama";
            this.colaciklama.FieldName = "Aciklama";
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.Visible = true;
            this.colaciklama.VisibleIndex = 8;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 7;
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
            this.splitContainerControl2.Size = new System.Drawing.Size(799, 149);
            this.splitContainerControl2.SplitterPosition = 400;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // gridOdemeTuruToplam
            // 
            this.gridOdemeTuruToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOdemeTuruToplam.Location = new System.Drawing.Point(0, 0);
            this.gridOdemeTuruToplam.MainView = this.gridodemettopl;
            this.gridOdemeTuruToplam.Name = "gridOdemeTuruToplam";
            this.gridOdemeTuruToplam.Size = new System.Drawing.Size(400, 149);
            this.gridOdemeTuruToplam.TabIndex = 3;
            this.gridOdemeTuruToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridodemettopl});
            this.gridOdemeTuruToplam.Click += new System.EventHandler(this.gridOdemeTuruToplam_Click);
            // 
            // gridodemettopl
            // 
            this.gridodemettopl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colodemetur,
            this.colkasagir,
            this.collkasacik,
            this.colbakiye});
            this.gridodemettopl.GridControl = this.gridOdemeTuruToplam;
            this.gridodemettopl.Name = "gridodemettopl";
            this.gridodemettopl.OptionsView.ShowGroupPanel = false;
            // 
            // colodemetur
            // 
            this.colodemetur.Caption = "Ödeme Türü";
            this.colodemetur.FieldName = "OdemeTuruAdi";
            this.colodemetur.Name = "colodemetur";
            this.colodemetur.OptionsColumn.AllowEdit = false;
            this.colodemetur.Visible = true;
            this.colodemetur.VisibleIndex = 0;
            // 
            // colkasagir
            // 
            this.colkasagir.Caption = "Kasa Giriş";
            this.colkasagir.FieldName = "KasaGiris";
            this.colkasagir.Name = "colkasagir";
            this.colkasagir.OptionsColumn.AllowEdit = false;
            this.colkasagir.Visible = true;
            this.colkasagir.VisibleIndex = 1;
            // 
            // collkasacik
            // 
            this.collkasacik.Caption = "Kasa Çıkış";
            this.collkasacik.FieldName = "KasaCikis";
            this.collkasacik.Name = "collkasacik";
            this.collkasacik.Visible = true;
            this.collkasacik.VisibleIndex = 3;
            // 
            // colbakiye
            // 
            this.colbakiye.Caption = "Bakiye";
            this.colbakiye.FieldName = "Bakiye";
            this.colbakiye.Name = "colbakiye";
            this.colbakiye.OptionsColumn.AllowEdit = false;
            this.colbakiye.Visible = true;
            this.colbakiye.VisibleIndex = 2;
            // 
            // gridGeneltoplam
            // 
            this.gridGeneltoplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGeneltoplam.Location = new System.Drawing.Point(0, 0);
            this.gridGeneltoplam.MainView = this.gridgeneltopl;
            this.gridGeneltoplam.Name = "gridGeneltoplam";
            this.gridGeneltoplam.Size = new System.Drawing.Size(394, 149);
            this.gridGeneltoplam.TabIndex = 3;
            this.gridGeneltoplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridgeneltopl});
            // 
            // gridgeneltopl
            // 
            this.gridgeneltopl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBilgi,
            this.colkayitsayi,
            this.colToplam});
            this.gridgeneltopl.GridControl = this.gridGeneltoplam;
            this.gridgeneltopl.Name = "gridgeneltopl";
            this.gridgeneltopl.OptionsView.ShowGroupPanel = false;
            // 
            // colBilgi
            // 
            this.colBilgi.Caption = "Bilgi";
            this.colBilgi.FieldName = "Bilgi";
            this.colBilgi.Name = "colBilgi";
            this.colBilgi.Visible = true;
            this.colBilgi.VisibleIndex = 0;
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
            // FrmKasaHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 404);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasaHareket";
            this.Text = "FrmKasaHareket";
            this.Load += new System.EventHandler(this.FrmKasaHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContkasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridkasalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
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
        private DevExpress.XtraGrid.GridControl gridOdemeTuruToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridodemettopl;
        private DevExpress.XtraGrid.Columns.GridColumn colodemetur;
        private DevExpress.XtraGrid.Columns.GridColumn colkasagir;
        private DevExpress.XtraGrid.Columns.GridColumn colbakiye;
        private DevExpress.XtraGrid.GridControl gridGeneltoplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridgeneltopl;
        private DevExpress.XtraGrid.Columns.GridColumn colBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraGrid.GridControl gridContkasaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridkasalar;
        private System.Windows.Forms.BindingSource kasaHareketBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruadi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colsaat;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn collkasacik;
        private DevExpress.XtraGrid.Columns.GridColumn colkayitsayi;
    }
}