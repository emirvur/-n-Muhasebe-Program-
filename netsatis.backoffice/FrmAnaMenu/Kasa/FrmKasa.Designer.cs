namespace netsatis.backoffice.FrmAnaMenu.Kasa
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkasahareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.btnkopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnfiltkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltiptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContKasalr = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasalr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(794, 36);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Kasalar";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnkasahareket);
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Controls.Add(this.btnkopyala);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnduzenle);
            this.grpMenu.Controls.Add(this.btnekle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 446);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(794, 78);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btnkasahareket
            // 
            this.btnkasahareket.ImageOptions.ImageIndex = 9;
            this.btnkasahareket.Location = new System.Drawing.Point(494, 23);
            this.btnkasahareket.Name = "btnkasahareket";
            this.btnkasahareket.Size = new System.Drawing.Size(73, 35);
            this.btnkasahareket.TabIndex = 1;
            this.btnkasahareket.Text = "Stok \r\nHareket\r\n";
            this.btnkasahareket.Click += new System.EventHandler(this.btnkasahareket_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.ImageIndex = 5;
            this.btnguncelle.ImageOptions.ImageList = this.imageList1;
            this.btnguncelle.Location = new System.Drawing.Point(415, 23);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(73, 35);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "KasaDuzenle.png");
            this.imageList1.Images.SetKeyName(1, "KasaEkle.png");
            this.imageList1.Images.SetKeyName(2, "KasaHareket.png");
            this.imageList1.Images.SetKeyName(3, "KasaSil.png");
            this.imageList1.Images.SetKeyName(4, "pencil.png");
            this.imageList1.Images.SetKeyName(5, "refresh.png");
            this.imageList1.Images.SetKeyName(6, "replace2.png");
            this.imageList1.Images.SetKeyName(7, "safe.png");
            this.imageList1.Images.SetKeyName(8, "view.png");
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 6;
            this.btnkapat.Location = new System.Drawing.Point(707, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            // 
            // btnara
            // 
            this.btnara.ImageOptions.ImageIndex = 8;
            this.btnara.ImageOptions.ImageList = this.imageList1;
            this.btnara.Location = new System.Drawing.Point(334, 23);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(73, 35);
            this.btnara.TabIndex = 0;
            this.btnara.Text = "ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnkopyala
            // 
            this.btnkopyala.ImageOptions.ImageIndex = 4;
            this.btnkopyala.Location = new System.Drawing.Point(251, 23);
            this.btnkopyala.Name = "btnkopyala";
            this.btnkopyala.Size = new System.Drawing.Size(75, 35);
            this.btnkopyala.TabIndex = 0;
            this.btnkopyala.Text = "kopyala";
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.ImageIndex = 3;
            this.btnsil.ImageOptions.ImageList = this.imageList1;
            this.btnsil.Location = new System.Drawing.Point(170, 23);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 35);
            this.btnsil.TabIndex = 0;
            this.btnsil.Text = "sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.ImageOptions.ImageIndex = 0;
            this.btnduzenle.ImageOptions.ImageList = this.imageList1;
            this.btnduzenle.Location = new System.Drawing.Point(89, 23);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(75, 35);
            this.btnduzenle.TabIndex = 0;
            this.btnduzenle.Text = "düzenle";
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnekle
            // 
            this.btnekle.ImageOptions.ImageIndex = 1;
            this.btnekle.ImageOptions.ImageList = this.imageList1;
            this.btnekle.Location = new System.Drawing.Point(8, 23);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 35);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 36);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltkapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltiptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContKasalr);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(794, 410);
            this.splitContainerControl1.SplitterPosition = 146;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // btnfiltkapat
            // 
            this.btnfiltkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltkapat.ImageOptions.ImageIndex = 7;
            this.btnfiltkapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltkapat.Location = new System.Drawing.Point(742, 110);
            this.btnfiltkapat.Name = "btnfiltkapat";
            this.btnfiltkapat.Size = new System.Drawing.Size(40, 35);
            this.btnfiltkapat.TabIndex = 3;
            this.btnfiltkapat.Text = "kapat";
            this.btnfiltkapat.Click += new System.EventHandler(this.btnfiltkapat_Click);
            // 
            // btnfiltiptal
            // 
            this.btnfiltiptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltiptal.ImageOptions.ImageIndex = 7;
            this.btnfiltiptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltiptal.Location = new System.Drawing.Point(677, 111);
            this.btnfiltiptal.Name = "btnfiltiptal";
            this.btnfiltiptal.Size = new System.Drawing.Size(59, 35);
            this.btnfiltiptal.TabIndex = 3;
            this.btnfiltiptal.Text = "filtreiptal";
            this.btnfiltiptal.Click += new System.EventHandler(this.btnfiltiptal_Click);
            // 
            // btnfiltre
            // 
            this.btnfiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltre.ImageOptions.ImageIndex = 7;
            this.btnfiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltre.Location = new System.Drawing.Point(631, 110);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(40, 35);
            this.btnfiltre.TabIndex = 3;
            this.btnfiltre.Text = "filtre";
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(794, 146);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContKasalr;
            this.filterControl1.TabIndex = 2;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContKasalr
            // 
            this.gridContKasalr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKasalr.Location = new System.Drawing.Point(0, 0);
            this.gridContKasalr.MainView = this.gridView1;
            this.gridContKasalr.Name = "gridContKasalr";
            this.gridContKasalr.Size = new System.Drawing.Size(794, 259);
            this.gridContKasalr.TabIndex = 2;
            this.gridContKasalr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridContKasalr.Click += new System.EventHandler(this.gridContKasalr_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKisi,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridView1.GridControl = this.gridContKasalr;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.Caption = "Kasa Kodu";
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.Visible = true;
            this.colKasaKodu.VisibleIndex = 1;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.Visible = true;
            this.colKasaAdi.VisibleIndex = 2;
            // 
            // colYetkiliKisi
            // 
            this.colYetkiliKisi.Caption = "Yetkili Kişi";
            this.colYetkiliKisi.FieldName = "YetkiliKisi";
            this.colYetkiliKisi.Name = "colYetkiliKisi";
            this.colYetkiliKisi.OptionsColumn.AllowEdit = false;
            this.colYetkiliKisi.Visible = true;
            this.colYetkiliKisi.VisibleIndex = 3;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 4;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 6;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.DisplayFormat.FormatString = "C2";
            this.colKasaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 7;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 8;
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 524);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasa";
            this.Text = "FrmKasa";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasalr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnkasahareket;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SimpleButton btnkopyala;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridContKasalr;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btnfiltkapat;
        private DevExpress.XtraEditors.SimpleButton btnfiltiptal;
        private DevExpress.XtraEditors.SimpleButton btnfiltre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKisi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
    }
}