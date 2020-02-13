namespace netsatis.backoffice.FrmAnaMenu.Stok_Hareketleri
{
    partial class FrmStokHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokHareketleri));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.btndetay = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnkapa = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltilpt = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContstokhar = new DevExpress.XtraGrid.GridControl();
            this.stokHareketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridstokhar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCstokkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColstokadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColbarkodtu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColbarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColsaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colİndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkdvtutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stokHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContstokhar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridstokhar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(792, 36);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Stok Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Controls.Add(this.btndetay);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 382);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(792, 78);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.Text = "Menü";
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.ImageIndex = 3;
            this.btnguncelle.Location = new System.Drawing.Point(168, 23);
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
            this.btnkapat.Location = new System.Drawing.Point(705, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnara
            // 
            this.btnara.ImageOptions.ImageIndex = 5;
            this.btnara.Location = new System.Drawing.Point(89, 23);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(73, 35);
            this.btnara.TabIndex = 0;
            this.btnara.Text = "ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btndetay
            // 
            this.btndetay.ImageOptions.ImageIndex = 2;
            this.btndetay.Location = new System.Drawing.Point(8, 23);
            this.btndetay.Name = "btndetay";
            this.btndetay.Size = new System.Drawing.Size(75, 35);
            this.btndetay.TabIndex = 0;
            this.btndetay.Text = "detay gor";
            this.btndetay.Click += new System.EventHandler(this.btndetay_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 36);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnkapa);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltilpt);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContstokhar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(792, 346);
            this.splitContainerControl1.SplitterPosition = 186;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // btnkapa
            // 
            this.btnkapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapa.ImageOptions.ImageIndex = 7;
            this.btnkapa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnkapa.Location = new System.Drawing.Point(740, 140);
            this.btnkapa.Name = "btnkapa";
            this.btnkapa.Size = new System.Drawing.Size(40, 35);
            this.btnkapa.TabIndex = 7;
            this.btnkapa.Text = "kapat";
            this.btnkapa.Click += new System.EventHandler(this.btnkapa_Click);
            // 
            // btnfiltilpt
            // 
            this.btnfiltilpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltilpt.ImageOptions.ImageIndex = 7;
            this.btnfiltilpt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltilpt.Location = new System.Drawing.Point(676, 140);
            this.btnfiltilpt.Name = "btnfiltilpt";
            this.btnfiltilpt.Size = new System.Drawing.Size(49, 35);
            this.btnfiltilpt.TabIndex = 6;
            this.btnfiltilpt.Text = "filt iptal";
            this.btnfiltilpt.Click += new System.EventHandler(this.btnfiltilpt_Click);
            // 
            // btnfiltre
            // 
            this.btnfiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltre.ImageOptions.ImageIndex = 7;
            this.btnfiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltre.Location = new System.Drawing.Point(630, 140);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(40, 35);
            this.btnfiltre.TabIndex = 5;
            this.btnfiltre.Text = "filtre";
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(792, 186);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContstokhar;
            this.filterControl1.TabIndex = 4;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContstokhar
            // 
            this.gridContstokhar.DataSource = this.stokHareketBindingSource1;
            this.gridContstokhar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContstokhar.Location = new System.Drawing.Point(0, 0);
            this.gridContstokhar.MainView = this.gridstokhar;
            this.gridContstokhar.Name = "gridContstokhar";
            this.gridContstokhar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridContstokhar.Size = new System.Drawing.Size(792, 155);
            this.gridContstokhar.TabIndex = 4;
            this.gridContstokhar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridstokhar});
            // 
            // stokHareketBindingSource1
            // 
            this.stokHareketBindingSource1.DataSource = typeof(netsatis.tables.StokHareket);
            // 
            // gridstokhar
            // 
            this.gridstokhar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFisKodu,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colHareket,
            this.colBirimi,
            this.gridCstokkod,
            this.gridColstokadi,
            this.gridColbarkodtu,
            this.gridColbarkod,
            this.colTarih,
            this.gridColsaat,
            this.colAciklama,
            this.colSeriNo,
            this.colKdv,
            this.colMiktar,
            this.colBirimFiyati,
            this.colİndirimOrani,
            this.colIndirimTutari,
            this.colkdvtutari,
            this.colToplamTutar});
            this.gridstokhar.GridControl = this.gridContstokhar;
            this.gridstokhar.Name = "gridstokhar";
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fis kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "depo kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 14;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "depo adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 16;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 2;
            // 
            // gridCstokkod
            // 
            this.gridCstokkod.Caption = "Stok Kodu";
            this.gridCstokkod.FieldName = "StokKodu";
            this.gridCstokkod.Name = "gridCstokkod";
            this.gridCstokkod.Visible = true;
            this.gridCstokkod.VisibleIndex = 5;
            // 
            // gridColstokadi
            // 
            this.gridColstokadi.Caption = "Stok Adı";
            this.gridColstokadi.FieldName = "StokAdi";
            this.gridColstokadi.Name = "gridColstokadi";
            this.gridColstokadi.Visible = true;
            this.gridColstokadi.VisibleIndex = 6;
            // 
            // gridColbarkodtu
            // 
            this.gridColbarkodtu.Caption = "Barkod Türü";
            this.gridColbarkodtu.FieldName = "BarkodTuru";
            this.gridColbarkodtu.Name = "gridColbarkodtu";
            this.gridColbarkodtu.Visible = true;
            this.gridColbarkodtu.VisibleIndex = 7;
            // 
            // gridColbarkod
            // 
            this.gridColbarkod.Caption = "Barkod";
            this.gridColbarkod.FieldName = "Barkod";
            this.gridColbarkod.Name = "gridColbarkod";
            this.gridColbarkod.Visible = true;
            this.gridColbarkod.VisibleIndex = 8;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 17;
            // 
            // gridColsaat
            // 
            this.gridColsaat.Caption = "Saat";
            this.gridColsaat.FieldName = "Saat";
            this.gridColsaat.Name = "gridColsaat";
            this.gridColsaat.Visible = true;
            this.gridColsaat.VisibleIndex = 10;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "aciklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 19;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "seri no";
            this.colSeriNo.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 13;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // colKdv
            // 
            this.colKdv.Caption = "kdv";
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 4;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "miktar";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 3;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "birim fiyati";
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 9;
            // 
            // colİndirimOrani
            // 
            this.colİndirimOrani.Caption = "indirim oranı";
            this.colİndirimOrani.FieldName = "İndirimOrani";
            this.colİndirimOrani.Name = "colİndirimOrani";
            this.colİndirimOrani.OptionsColumn.AllowEdit = false;
            this.colİndirimOrani.Visible = true;
            this.colİndirimOrani.VisibleIndex = 11;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "indirim tutarı";
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colIndirimTutari.UnboundExpression = "[BirimFiyati] * [Miktar] / 100 * [İndirimOrani]";
            this.colIndirimTutari.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 12;
            // 
            // colkdvtutari
            // 
            this.colkdvtutari.Caption = "kdv tutarı";
            this.colkdvtutari.FieldName = "KdvTutari";
            this.colkdvtutari.Name = "colkdvtutari";
            this.colkdvtutari.UnboundExpression = "[ToplamTutar] / [Kdv]";
            this.colkdvtutari.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colkdvtutari.Visible = true;
            this.colkdvtutari.VisibleIndex = 18;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "toplam tutar";
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.UnboundExpression = "[BirimFiyati] * [Miktar] - [IndirimTutari]";
            this.colToplamTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 15;
            // 
            // stokHareketBindingSource
            // 
            this.stokHareketBindingSource.DataSource = typeof(netsatis.tables.StokHareket);
            // 
            // FrmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 460);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmStokHareketleri";
            this.Text = "FrmStokHareketleri";
            this.Load += new System.EventHandler(this.FrmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContstokhar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridstokhar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SimpleButton btndetay;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapa;
        private DevExpress.XtraEditors.SimpleButton btnfiltilpt;
        private DevExpress.XtraEditors.SimpleButton btnfiltre;
        private System.Windows.Forms.BindingSource stokHareketBindingSource;
        private DevExpress.XtraGrid.GridControl gridContstokhar;
        private System.Windows.Forms.BindingSource stokHareketBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridstokhar;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn gridColsaat;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colİndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colkdvtutari;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCstokkod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColstokadi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColbarkodtu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColbarkod;
    }
}