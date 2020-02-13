namespace netsatis.backoffice.FrmAnaMenu.Depo
{
    partial class FrmDepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepo));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btndepohareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnkapa = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltipt = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContdepolar = new DevExpress.XtraGrid.GridControl();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.griddepo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContdepolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddepo)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(782, 36);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Depo Kartları";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btndepohareket);
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnduzenle);
            this.grpMenu.Controls.Add(this.btnekle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 365);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(782, 78);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btndepohareket
            // 
            this.btndepohareket.ImageOptions.ImageIndex = 9;
            this.btndepohareket.Location = new System.Drawing.Point(255, 23);
            this.btndepohareket.Name = "btndepohareket";
            this.btndepohareket.Size = new System.Drawing.Size(73, 35);
            this.btndepohareket.TabIndex = 1;
            this.btndepohareket.Text = "Stok\r\nHareket\r\n";
            this.btndepohareket.Click += new System.EventHandler(this.btndepohareket_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.ImageIndex = 3;
            this.btnguncelle.Location = new System.Drawing.Point(415, 23);
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
            this.btnkapat.Location = new System.Drawing.Point(695, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnara
            // 
            this.btnara.ImageOptions.ImageIndex = 5;
            this.btnara.Location = new System.Drawing.Point(334, 23);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(73, 35);
            this.btnara.TabIndex = 0;
            this.btnara.Text = "ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.ImageIndex = 5;
            this.btnsil.Location = new System.Drawing.Point(170, 23);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 35);
            this.btnsil.TabIndex = 0;
            this.btnsil.Text = "sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.ImageOptions.ImageIndex = 1;
            this.btnduzenle.Location = new System.Drawing.Point(89, 23);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(75, 35);
            this.btnduzenle.TabIndex = 0;
            this.btnduzenle.Text = "düzenle";
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnekle
            // 
            this.btnekle.ImageOptions.ImageIndex = 2;
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
            this.splitContainerControl1.Panel1.Controls.Add(this.btnkapa);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltipt);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContdepolar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(782, 329);
            this.splitContainerControl1.SplitterPosition = 143;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // btnkapa
            // 
            this.btnkapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapa.ImageOptions.ImageIndex = 7;
            this.btnkapa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnkapa.Location = new System.Drawing.Point(718, 97);
            this.btnkapa.Name = "btnkapa";
            this.btnkapa.Size = new System.Drawing.Size(40, 35);
            this.btnkapa.TabIndex = 5;
            this.btnkapa.Text = "kapat";
            this.btnkapa.Click += new System.EventHandler(this.btnkapa_Click);
            // 
            // btnfiltipt
            // 
            this.btnfiltipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltipt.ImageOptions.ImageIndex = 7;
            this.btnfiltipt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltipt.Location = new System.Drawing.Point(652, 97);
            this.btnfiltipt.Name = "btnfiltipt";
            this.btnfiltipt.Size = new System.Drawing.Size(60, 35);
            this.btnfiltipt.TabIndex = 4;
            this.btnfiltipt.Text = "filtre iptal";
            this.btnfiltipt.Click += new System.EventHandler(this.btnfiltipt_Click);
            // 
            // btnfiltre
            // 
            this.btnfiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltre.ImageOptions.ImageIndex = 7;
            this.btnfiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltre.Location = new System.Drawing.Point(606, 97);
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
            this.filterControl1.Size = new System.Drawing.Size(782, 143);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContdepolar;
            this.filterControl1.TabIndex = 2;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContdepolar
            // 
            this.gridContdepolar.DataSource = this.depoBindingSource;
            this.gridContdepolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContdepolar.Location = new System.Drawing.Point(0, 0);
            this.gridContdepolar.MainView = this.griddepo;
            this.gridContdepolar.Name = "gridContdepolar";
            this.gridContdepolar.Size = new System.Drawing.Size(782, 181);
            this.gridContdepolar.TabIndex = 2;
            this.gridContdepolar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griddepo});
            // 
            // depoBindingSource
            // 
            this.depoBindingSource.DataSource = typeof(netsatis.tables.Depo);
            // 
            // griddepo
            // 
            this.griddepo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colTelefon,
            this.colAciklama});
            this.griddepo.GridControl = this.gridContdepolar;
            this.griddepo.Name = "griddepo";
            // 
            // colId
            // 
            this.colId.Caption = "İd";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 0;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 1;
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.Visible = true;
            this.colYetkiliKodu.VisibleIndex = 2;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 3;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 4;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 5;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 6;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 7;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 8;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            // 
            // FrmDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 443);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmDepo";
            this.Text = "FrmDepo";
            this.Load += new System.EventHandler(this.FrmDepo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContdepolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btndepohareket;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton btnkapa;
        private DevExpress.XtraEditors.SimpleButton btnfiltipt;
        private DevExpress.XtraEditors.SimpleButton btnfiltre;
        private DevExpress.XtraGrid.GridControl gridContdepolar;
        private DevExpress.XtraGrid.Views.Grid.GridView griddepo;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}