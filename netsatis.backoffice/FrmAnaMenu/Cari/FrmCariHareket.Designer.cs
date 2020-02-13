namespace netsatis.backoffice.FrmAnaMenu.Cari
{
    partial class FrmCariHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariHareket));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContcariHareket = new DevExpress.XtraGrid.GridControl();
            this.fisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colİskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colİskontoTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKalanTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfisturuBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfisturukayitsayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfisturutoplamtutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContcariHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(770, 36);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Cari Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 355);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(770, 78);
            this.grpMenu.TabIndex = 3;
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
            this.btnkapat.Location = new System.Drawing.Point(683, 31);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContcariHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(770, 319);
            this.splitContainerControl1.SplitterPosition = 126;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // gridContcariHareket
            // 
            this.gridContcariHareket.DataSource = this.fisBindingSource;
            this.gridContcariHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContcariHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContcariHareket.MainView = this.gridView1;
            this.gridContcariHareket.Name = "gridContcariHareket";
            this.gridContcariHareket.Size = new System.Drawing.Size(770, 126);
            this.gridContcariHareket.TabIndex = 2;
            this.gridContcariHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // fisBindingSource
            // 
            this.fisBindingSource.DataSource = typeof(netsatis.tables.Fis);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisTuru,
            this.colFisKodu,
            this.colBelgeNo,
            this.colTarih,
            this.colSaat,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colİskontoOrani,
            this.colİskontoTutar,
            this.colToplamTutar,
            this.colAciklama,
            this.ColOdenen,
            this.ColKalanTutar});
            this.gridView1.GridControl = this.gridContcariHareket;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisTuru
            // 
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 0;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 1;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 2;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.ShowInCustomizationForm = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "d";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 5;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.Caption = "Plasiyer Kodu";
            this.colPlasiyerKodu.FieldName = "PlasiyerKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.OptionsColumn.AllowEdit = false;
            this.colPlasiyerKodu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.Caption = "Plasiyer Adı";
            this.colPlasiyerAdi.FieldName = "PlasiyerAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.OptionsColumn.AllowEdit = false;
            this.colPlasiyerAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colİskontoOrani
            // 
            this.colİskontoOrani.Caption = "İsk. Oranı";
            this.colİskontoOrani.FieldName = "İskontoOrani";
            this.colİskontoOrani.Name = "colİskontoOrani";
            this.colİskontoOrani.OptionsColumn.AllowEdit = false;
            this.colİskontoOrani.OptionsColumn.ShowInCustomizationForm = false;
            this.colİskontoOrani.Visible = true;
            this.colİskontoOrani.VisibleIndex = 4;
            // 
            // colİskontoTutar
            // 
            this.colİskontoTutar.Caption = "İsk. Tutar";
            this.colİskontoTutar.FieldName = "İskontoTutar";
            this.colİskontoTutar.Name = "colİskontoTutar";
            this.colİskontoTutar.OptionsColumn.AllowEdit = false;
            this.colİskontoTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colİskontoTutar.Visible = true;
            this.colİskontoTutar.VisibleIndex = 6;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 7;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            // 
            // ColOdenen
            // 
            this.ColOdenen.Caption = "Ödenen";
            this.ColOdenen.FieldName = "Odenen";
            this.ColOdenen.Name = "ColOdenen";
            this.ColOdenen.Visible = true;
            this.ColOdenen.VisibleIndex = 9;
            // 
            // ColKalanTutar
            // 
            this.ColKalanTutar.Caption = "Kalan Tutar";
            this.ColKalanTutar.FieldName = "KalanOdeme";
            this.ColKalanTutar.Name = "ColKalanTutar";
            this.ColKalanTutar.Visible = true;
            this.ColKalanTutar.VisibleIndex = 10;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(770, 188);
            this.splitContainerControl2.SplitterPosition = 382;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(382, 188);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Fiş Türlerine Göre Toplamlar";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 20);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(378, 166);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfisturuBilgi,
            this.colfisturukayitsayisi,
            this.colfisturutoplamtutar});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colfisturuBilgi
            // 
            this.colfisturuBilgi.Caption = "Bilgi";
            this.colfisturuBilgi.FieldName = "Bilgi";
            this.colfisturuBilgi.Name = "colfisturuBilgi";
            this.colfisturuBilgi.OptionsColumn.AllowEdit = false;
            this.colfisturuBilgi.Visible = true;
            this.colfisturuBilgi.VisibleIndex = 0;
            // 
            // colfisturukayitsayisi
            // 
            this.colfisturukayitsayisi.Caption = "Kayıt Sayısı";
            this.colfisturukayitsayisi.FieldName = "KayitSayisi";
            this.colfisturukayitsayisi.Name = "colfisturukayitsayisi";
            this.colfisturukayitsayisi.OptionsColumn.AllowEdit = false;
            this.colfisturukayitsayisi.Visible = true;
            this.colfisturukayitsayisi.VisibleIndex = 1;
            // 
            // colfisturutoplamtutar
            // 
            this.colfisturutoplamtutar.Caption = "Toplam Tutar";
            this.colfisturutoplamtutar.FieldName = "Tutar";
            this.colfisturutoplamtutar.Name = "colfisturutoplamtutar";
            this.colfisturutoplamtutar.OptionsColumn.AllowEdit = false;
            this.colfisturutoplamtutar.Visible = true;
            this.colfisturutoplamtutar.VisibleIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(383, 188);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Cari Ekstresi";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 20);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(379, 166);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBilgi,
            this.colGenelToplam});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colBilgi
            // 
            this.colBilgi.Caption = "Bilgi";
            this.colBilgi.FieldName = "Bilgi";
            this.colBilgi.Name = "colBilgi";
            this.colBilgi.Visible = true;
            this.colBilgi.VisibleIndex = 0;
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.Caption = "Toplam";
            this.colGenelToplam.FieldName = "Tutar";
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.Visible = true;
            this.colGenelToplam.VisibleIndex = 1;
            // 
            // FrmCariHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 433);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmCariHareket";
            this.Text = "FrmCariHareket";
            this.Load += new System.EventHandler(this.FrmCariHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContcariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridContcariHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colfisturuBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colfisturukayitsayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colfisturutoplamtutar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
        private System.Windows.Forms.BindingSource fisBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colİskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colİskontoTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn ColOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn ColKalanTutar;
    }
}