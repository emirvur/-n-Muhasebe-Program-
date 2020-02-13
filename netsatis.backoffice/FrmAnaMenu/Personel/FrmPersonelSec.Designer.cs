namespace netsatis.backoffice.FrmAnaMenu.Personel
{
    partial class FrmPersonelSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelSec));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.lbluyari = new DevExpress.XtraEditors.LabelControl();
            this.btnsec = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalisiyor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTcKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIseGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIseCikisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colodenecektutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(821, 36);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Personel Seçim Ekranı";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lbluyari);
            this.grpMenu.Controls.Add(this.btnsec);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 326);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(821, 78);
            this.grpMenu.TabIndex = 6;
            this.grpMenu.Text = "Menü";
            // 
            // lbluyari
            // 
            this.lbluyari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbluyari.ImageOptions.Image")));
            this.lbluyari.Location = new System.Drawing.Point(12, 30);
            this.lbluyari.Name = "lbluyari";
            this.lbluyari.Size = new System.Drawing.Size(160, 48);
            this.lbluyari.TabIndex = 1;
            this.lbluyari.Text = "çoklu seçim için ctrl tuşuna basınız";
            this.lbluyari.Visible = false;
            // 
            // btnsec
            // 
            this.btnsec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsec.ImageOptions.ImageIndex = 0;
            this.btnsec.Location = new System.Drawing.Point(653, 31);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(75, 35);
            this.btnsec.TabIndex = 0;
            this.btnsec.Text = "sec";
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 1;
            this.btnkapat.Location = new System.Drawing.Point(734, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(821, 290);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colIseCikisTarihi,
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
            this.colPrimi,
            this.colodenecektutar});
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
            // 
            // colUnvani
            // 
            this.colUnvani.Caption = "Unvanı";
            this.colUnvani.FieldName = "Unvani";
            this.colUnvani.Name = "colUnvani";
            this.colUnvani.OptionsColumn.AllowEdit = false;
            this.colUnvani.Visible = true;
            this.colUnvani.VisibleIndex = 0;
            // 
            // colPersonelKodu
            // 
            this.colPersonelKodu.Caption = "Personel Kodu";
            this.colPersonelKodu.FieldName = "PersonelKodu";
            this.colPersonelKodu.Name = "colPersonelKodu";
            this.colPersonelKodu.OptionsColumn.AllowEdit = false;
            this.colPersonelKodu.Visible = true;
            this.colPersonelKodu.VisibleIndex = 1;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel Adı";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 2;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc Kimlik no";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 3;
            // 
            // colIseGirisTarihi
            // 
            this.colIseGirisTarihi.Caption = "İşe giriş tarihi";
            this.colIseGirisTarihi.FieldName = "IseGirisTarihi";
            this.colIseGirisTarihi.Name = "colIseGirisTarihi";
            this.colIseGirisTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colIseCikisTarihi
            // 
            this.colIseCikisTarihi.Caption = "işe çıkış tarihi";
            this.colIseCikisTarihi.FieldName = "IseCikisTarihi";
            this.colIseCikisTarihi.Name = "colIseCikisTarihi";
            this.colIseCikisTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "vergi dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "vregi no";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "cep telefonu";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.OptionsColumn.AllowEdit = false;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
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
            this.colPrimOrani.VisibleIndex = 4;
            // 
            // colAylikMaasi
            // 
            this.colAylikMaasi.Caption = "aylık maası";
            this.colAylikMaasi.FieldName = "AylikMaasi";
            this.colAylikMaasi.Name = "colAylikMaasi";
            this.colAylikMaasi.OptionsColumn.AllowEdit = false;
            this.colAylikMaasi.Visible = true;
            this.colAylikMaasi.VisibleIndex = 5;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 6;
            // 
            // colToplamSatis
            // 
            this.colToplamSatis.Caption = "Toplam Satış";
            this.colToplamSatis.FieldName = "ToplamSatis";
            this.colToplamSatis.Name = "colToplamSatis";
            this.colToplamSatis.Visible = true;
            this.colToplamSatis.VisibleIndex = 7;
            // 
            // colPrimi
            // 
            this.colPrimi.Caption = "Prim tutarı";
            this.colPrimi.FieldName = "PrimTutar";
            this.colPrimi.Name = "colPrimi";
            this.colPrimi.UnboundExpression = "[ToplamSatis] / 100 * [PrimOrani]";
            this.colPrimi.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colPrimi.Visible = true;
            this.colPrimi.VisibleIndex = 8;
            // 
            // colodenecektutar
            // 
            this.colodenecektutar.Caption = "ödenecek tutar";
            this.colodenecektutar.FieldName = "colodenecektutar";
            this.colodenecektutar.Name = "colodenecektutar";
            this.colodenecektutar.UnboundExpression = "[AylikMaasi] + [PrimTutar]";
            this.colodenecektutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colodenecektutar.Visible = true;
            this.colodenecektutar.VisibleIndex = 9;
            // 
            // FrmPersonelSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 404);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmPersonelSec";
            this.Text = "FrmPersonelSec";
            this.Load += new System.EventHandler(this.FrmPersonelSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.LabelControl lbluyari;
        private DevExpress.XtraEditors.SimpleButton btnsec;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCalisiyor;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIseGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIseCikisTarihi;
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
        private DevExpress.XtraGrid.Columns.GridColumn colodenecektutar;
    }
}