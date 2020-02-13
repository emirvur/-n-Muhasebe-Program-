namespace netsatis.backoffice.FrmAnaMenu.Personel
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnpersonelhareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.btnkopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnka = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltipt = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltre = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalisiyor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIseGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstenCikisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAylikMaasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnpersonelhareket);
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Controls.Add(this.btnkopyala);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnduzenle);
            this.grpMenu.Controls.Add(this.btnekle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 338);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(809, 78);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btnpersonelhareket
            // 
            this.btnpersonelhareket.ImageOptions.ImageIndex = 9;
            this.btnpersonelhareket.Location = new System.Drawing.Point(494, 23);
            this.btnpersonelhareket.Name = "btnpersonelhareket";
            this.btnpersonelhareket.Size = new System.Drawing.Size(73, 35);
            this.btnpersonelhareket.TabIndex = 1;
            this.btnpersonelhareket.Text = "PersonelHareket\r\n";
            this.btnpersonelhareket.Click += new System.EventHandler(this.btnpersonelhareket_Click);
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
            this.btnkapat.Location = new System.Drawing.Point(722, 31);
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
            // btnkopyala
            // 
            this.btnkopyala.ImageOptions.ImageIndex = 4;
            this.btnkopyala.Location = new System.Drawing.Point(251, 23);
            this.btnkopyala.Name = "btnkopyala";
            this.btnkopyala.Size = new System.Drawing.Size(75, 35);
            this.btnkopyala.TabIndex = 0;
            this.btnkopyala.Text = "kopyala";
            this.btnkopyala.Click += new System.EventHandler(this.btnkopyala_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(809, 36);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Personel Kartları";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 36);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnka);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltipt);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(809, 302);
            this.splitContainerControl1.SplitterPosition = 122;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // btnka
            // 
            this.btnka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnka.ImageOptions.ImageIndex = 7;
            this.btnka.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnka.Location = new System.Drawing.Point(748, 75);
            this.btnka.Name = "btnka";
            this.btnka.Size = new System.Drawing.Size(40, 35);
            this.btnka.TabIndex = 5;
            this.btnka.Text = "kapat";
            this.btnka.Click += new System.EventHandler(this.btnka_Click);
            // 
            // btnfiltipt
            // 
            this.btnfiltipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltipt.ImageOptions.ImageIndex = 7;
            this.btnfiltipt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltipt.Location = new System.Drawing.Point(678, 75);
            this.btnfiltipt.Name = "btnfiltipt";
            this.btnfiltipt.Size = new System.Drawing.Size(55, 35);
            this.btnfiltipt.TabIndex = 4;
            this.btnfiltipt.Text = "filtre iptal";
            this.btnfiltipt.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnfiltre
            // 
            this.btnfiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltre.ImageOptions.ImageIndex = 7;
            this.btnfiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltre.Location = new System.Drawing.Point(632, 75);
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
            this.filterControl1.Size = new System.Drawing.Size(809, 122);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.TabIndex = 2;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.personelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 175);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataSource = typeof(netsatis.tables.Personel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCalisiyor,
            this.colUnvani,
            this.colPersonelKodu,
            this.colPersonelAdi,
            this.colTcKimlikNo,
            this.colIseGirisTarihi,
            this.colIstenCikisTarihi,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colCepTelefonu,
            this.colTelefon,
            this.colFax,
            this.colEMail,
            this.colWeb,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colPrimOrani,
            this.colAylikMaasi,
            this.colAciklama,
            this.colToplamSatis,
            this.colPrimi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colCalisiyor
            // 
            this.colCalisiyor.Caption = "Çalışıyor";
            this.colCalisiyor.FieldName = "Calisiyor";
            this.colCalisiyor.Name = "colCalisiyor";
            this.colCalisiyor.OptionsColumn.AllowEdit = false;
            this.colCalisiyor.Visible = true;
            this.colCalisiyor.VisibleIndex = 0;
            // 
            // colUnvani
            // 
            this.colUnvani.Caption = "Unvanı";
            this.colUnvani.FieldName = "Unvani";
            this.colUnvani.Name = "colUnvani";
            this.colUnvani.OptionsColumn.AllowEdit = false;
            this.colUnvani.Visible = true;
            this.colUnvani.VisibleIndex = 1;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            this.colPersonelKodu.Visible = true;
            this.colPersonelKodu.VisibleIndex = 2;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adı";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 3;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc Kimlik no";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 4;
            // 
            // colIseGirisTarihi
            // 
            this.colIseGirisTarihi.Caption = "İşe giriş tarihi";
            this.colIseGirisTarihi.FieldName = "IseGirisTarihi";
            this.colIseGirisTarihi.Name = "colIseGirisTarihi";
            this.colIseGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colIseGirisTarihi.Visible = true;
            this.colIseGirisTarihi.VisibleIndex = 5;
            // 
            // colIstenCikisTarihi
            // 
            this.colIstenCikisTarihi.Caption = "işten çıkış tarihi";
            this.colIstenCikisTarihi.FieldName = "IstenCikisTarihi";
            this.colIstenCikisTarihi.Name = "colIstenCikisTarihi";
            this.colIstenCikisTarihi.OptionsColumn.AllowEdit = false;
            this.colIstenCikisTarihi.Visible = true;
            this.colIstenCikisTarihi.VisibleIndex = 6;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "vergi dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 7;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "vregi no";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 8;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "cep telefonu";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 9;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 10;
            // 
            // colFax
            // 
            this.colFax.Caption = "fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            // 
            // colEMail
            // 
            this.colEMail.Caption = "email";
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.OptionsColumn.AllowEdit = false;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "web";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            // 
            // colIl
            // 
            this.colIl.Caption = "il";
            this.colIl.FieldName = "Il";
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "ilçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            // 
            // colPrimOrani
            // 
            this.colPrimOrani.Caption = "prim oranı";
            this.colPrimOrani.FieldName = "PrimOrani";
            this.colPrimOrani.Name = "colPrimOrani";
            this.colPrimOrani.OptionsColumn.AllowEdit = false;
            this.colPrimOrani.Visible = true;
            this.colPrimOrani.VisibleIndex = 11;
            // 
            // colAylikMaasi
            // 
            this.colAylikMaasi.Caption = "aylık maası";
            this.colAylikMaasi.FieldName = "AylikMaasi";
            this.colAylikMaasi.Name = "colAylikMaasi";
            this.colAylikMaasi.OptionsColumn.AllowEdit = false;
            this.colAylikMaasi.Visible = true;
            this.colAylikMaasi.VisibleIndex = 12;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 13;
            // 
            // colToplamSatis
            // 
            this.colToplamSatis.Caption = "Toplam Satış";
            this.colToplamSatis.FieldName = "ToplamSatis";
            this.colToplamSatis.Name = "colToplamSatis";
            this.colToplamSatis.Visible = true;
            this.colToplamSatis.VisibleIndex = 14;
            // 
            // colPrimi
            // 
            this.colPrimi.Caption = "Prim tutarı";
            this.colPrimi.FieldName = "PrimTutar";
            this.colPrimi.Name = "colPrimi";
            this.colPrimi.Visible = true;
            this.colPrimi.VisibleIndex = 15;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 416);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnpersonelhareket;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SimpleButton btnkopyala;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton btnka;
        private DevExpress.XtraEditors.SimpleButton btnfiltipt;
        private DevExpress.XtraEditors.SimpleButton btnfiltre;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCalisiyor;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIseGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIstenCikisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn colWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAylikMaasi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamSatis;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimi;
    }
}