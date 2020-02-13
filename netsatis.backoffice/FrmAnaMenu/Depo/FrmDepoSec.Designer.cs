namespace netsatis.backoffice.FrmAnaMenu.Depo
{
    partial class FrmDepoSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoSec));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnsec = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridContdeposec = new DevExpress.XtraGrid.GridControl();
            this.griddeposec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.gridColstokgir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColstokcik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColmevcutstok = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContdeposec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddeposec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(704, 36);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Depo İşlem";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnsec);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 384);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(704, 78);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnsec
            // 
            this.btnsec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsec.ImageOptions.ImageIndex = 0;
            this.btnsec.Location = new System.Drawing.Point(536, 31);
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
            this.btnkapat.Location = new System.Drawing.Point(617, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // gridContdeposec
            // 
            this.gridContdeposec.DataSource = this.depoBindingSource;
            this.gridContdeposec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContdeposec.Location = new System.Drawing.Point(0, 36);
            this.gridContdeposec.MainView = this.griddeposec;
            this.gridContdeposec.Name = "gridContdeposec";
            this.gridContdeposec.Size = new System.Drawing.Size(704, 348);
            this.gridContdeposec.TabIndex = 8;
            this.gridContdeposec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griddeposec});
            // 
            // griddeposec
            // 
            this.griddeposec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colAciklama,
            this.gridColstokgir,
            this.gridColstokcik,
            this.gridColmevcutstok});
            this.griddeposec.GridControl = this.gridContdeposec;
            this.griddeposec.Name = "griddeposec";
            // 
            // depoBindingSource
            // 
            this.depoBindingSource.DataSource = typeof(netsatis.tables.Depo);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
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
            this.colDepoAdi.Caption = "Dpo Adı";
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
            // gridColstokgir
            // 
            this.gridColstokgir.Caption = "Stok Giriş";
            this.gridColstokgir.FieldName = "StokGiris";
            this.gridColstokgir.Name = "gridColstokgir";
            this.gridColstokgir.Visible = true;
            this.gridColstokgir.VisibleIndex = 10;
            // 
            // gridColstokcik
            // 
            this.gridColstokcik.Caption = "Stok Çıkış";
            this.gridColstokcik.FieldName = "StokCikis";
            this.gridColstokcik.Name = "gridColstokcik";
            this.gridColstokcik.Visible = true;
            this.gridColstokcik.VisibleIndex = 11;
            // 
            // gridColmevcutstok
            // 
            this.gridColmevcutstok.Caption = "Mevcut Stok";
            this.gridColmevcutstok.FieldName = "MevcutStok";
            this.gridColmevcutstok.Name = "gridColmevcutstok";
            this.gridColmevcutstok.Visible = true;
            this.gridColmevcutstok.VisibleIndex = 12;
            // 
            // FrmDepoSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 462);
            this.Controls.Add(this.gridContdeposec);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmDepoSec";
            this.Text = "FrmDepoSec";
            this.Load += new System.EventHandler(this.FrmDepoSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContdeposec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddeposec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnsec;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraGrid.GridControl gridContdeposec;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView griddeposec;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColstokgir;
        private DevExpress.XtraGrid.Columns.GridColumn gridColstokcik;
        private DevExpress.XtraGrid.Columns.GridColumn gridColmevcutstok;
    }
}