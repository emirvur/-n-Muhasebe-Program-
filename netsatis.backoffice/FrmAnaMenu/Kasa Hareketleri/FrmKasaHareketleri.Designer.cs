namespace netsatis.backoffice.FrmAnaMenu.Kasa_Hareket
{
    partial class FrmKasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaHareketleri));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.btndetay = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnkap = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltip = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContkasahar = new DevExpress.XtraGrid.GridControl();
            this.kasaHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridkasahar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContkasahar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridkasahar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(921, 36);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Kasa Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Controls.Add(this.btndetay);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 362);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(921, 78);
            this.grpMenu.TabIndex = 6;
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
            this.btnkapat.Location = new System.Drawing.Point(834, 31);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.btnkap);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltip);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContkasahar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(921, 326);
            this.splitContainerControl1.SplitterPosition = 143;
            this.splitContainerControl1.TabIndex = 7;
            // 
            // btnkap
            // 
            this.btnkap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkap.ImageOptions.ImageIndex = 7;
            this.btnkap.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnkap.Location = new System.Drawing.Point(869, 98);
            this.btnkap.Name = "btnkap";
            this.btnkap.Size = new System.Drawing.Size(40, 35);
            this.btnkap.TabIndex = 8;
            this.btnkap.Text = "kapat";
            this.btnkap.Click += new System.EventHandler(this.btnkap_Click);
            // 
            // btnfiltip
            // 
            this.btnfiltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltip.ImageOptions.ImageIndex = 7;
            this.btnfiltip.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltip.Location = new System.Drawing.Point(807, 98);
            this.btnfiltip.Name = "btnfiltip";
            this.btnfiltip.Size = new System.Drawing.Size(56, 35);
            this.btnfiltip.TabIndex = 7;
            this.btnfiltip.Text = "filtre iptal";
            this.btnfiltip.Click += new System.EventHandler(this.btnfiltip_Click);
            // 
            // btnfiltre
            // 
            this.btnfiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltre.ImageOptions.ImageIndex = 7;
            this.btnfiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltre.Location = new System.Drawing.Point(761, 98);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(40, 35);
            this.btnfiltre.TabIndex = 6;
            this.btnfiltre.Text = "filtre";
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(921, 143);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContkasahar;
            this.filterControl1.TabIndex = 5;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContkasahar
            // 
            this.gridContkasahar.DataSource = this.kasaHareketBindingSource;
            this.gridContkasahar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContkasahar.Location = new System.Drawing.Point(0, 0);
            this.gridContkasahar.MainView = this.gridkasahar;
            this.gridContkasahar.Name = "gridContkasahar";
            this.gridContkasahar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridContkasahar.Size = new System.Drawing.Size(921, 178);
            this.gridContkasahar.TabIndex = 5;
            this.gridContkasahar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridkasahar});
            // 
            // kasaHareketBindingSource
            // 
            this.kasaHareketBindingSource.DataSource = typeof(netsatis.tables.KasaHareket);
            // 
            // gridkasahar
            // 
            this.gridkasahar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colCariKodu,
            this.colCariAdi,
            this.colTarih,
            this.colAciklama,
            this.colTutar});
            this.gridkasahar.GridControl = this.gridContkasahar;
            this.gridkasahar.Name = "gridkasahar";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            // 
            // colHareket
            // 
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.Visible = true;
            this.colKasaKodu.VisibleIndex = 2;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.Visible = true;
            this.colKasaAdi.VisibleIndex = 3;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 4;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 5;
            // 
            // colCariKodu
            // 
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 7;
            // 
            // colCariAdi
            // 
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 6;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 8;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            // 
            // colTutar
            // 
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 9;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FrmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 440);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasaHareketleri";
            this.Text = "FrmKasaHareket";
            this.Load += new System.EventHandler(this.FrmKasaHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContkasahar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridkasahar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnkap;
        private DevExpress.XtraEditors.SimpleButton btnfiltip;
        private DevExpress.XtraEditors.SimpleButton btnfiltre;
        private DevExpress.XtraGrid.GridControl gridContkasahar;
        private System.Windows.Forms.BindingSource kasaHareketBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridkasahar;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}