namespace netsatis.backoffice.FrmAnaMenu.Kasa
{
    partial class FrmKasaSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaSec));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnsec = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridContSec = new DevExpress.XtraGrid.GridControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridContSec)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(729, 36);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Kasa İşlem";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnsec);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 357);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(729, 78);
            this.grpMenu.TabIndex = 6;
            this.grpMenu.Text = "Menü";
            // 
            // btnsec
            // 
            this.btnsec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsec.ImageOptions.ImageIndex = 0;
            this.btnsec.Location = new System.Drawing.Point(561, 31);
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
            this.btnkapat.Location = new System.Drawing.Point(642, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // gridContSec
            // 
            this.gridContSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContSec.Location = new System.Drawing.Point(0, 36);
            this.gridContSec.MainView = this.gridView1;
            this.gridContSec.Name = "gridContSec";
            this.gridContSec.Size = new System.Drawing.Size(729, 321);
            this.gridContSec.TabIndex = 7;
            this.gridContSec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.GridControl = this.gridContSec;
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
            // FrmKasaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 435);
            this.Controls.Add(this.gridContSec);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasaSec";
            this.Text = "FrmKasaSec";
            this.Load += new System.EventHandler(this.FrmKasaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnsec;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraGrid.GridControl gridContSec;
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