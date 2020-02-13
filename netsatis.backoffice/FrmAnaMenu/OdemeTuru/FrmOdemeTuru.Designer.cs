namespace netsatis.backoffice.FrmAnaMenu
{
    partial class FrmOdemeTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuru));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnstokhareket = new DevExpress.XtraEditors.SimpleButton();
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
            this.gridContdodemet = new DevExpress.XtraGrid.GridControl();
            this.odemeTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridodemet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColkasagir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColkasacik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColbakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContdodemet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridodemet)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(716, 36);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Ödeme Türleri Kartları";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnstokhareket);
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnara);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnduzenle);
            this.grpMenu.Controls.Add(this.btnekle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 335);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(716, 78);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.Text = "Menü";
            // 
            // btnstokhareket
            // 
            this.btnstokhareket.ImageOptions.ImageIndex = 9;
            this.btnstokhareket.Location = new System.Drawing.Point(255, 23);
            this.btnstokhareket.Name = "btnstokhareket";
            this.btnstokhareket.Size = new System.Drawing.Size(73, 35);
            this.btnstokhareket.TabIndex = 1;
            this.btnstokhareket.Text = "Stok\r\nHareket\r\n";
            this.btnstokhareket.Click += new System.EventHandler(this.btndepohareket_Click);
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
            this.btnkapat.Location = new System.Drawing.Point(629, 31);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContdodemet);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(716, 299);
            this.splitContainerControl1.SplitterPosition = 146;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // btnkapa
            // 
            this.btnkapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapa.ImageOptions.ImageIndex = 7;
            this.btnkapa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnkapa.Location = new System.Drawing.Point(664, 99);
            this.btnkapa.Name = "btnkapa";
            this.btnkapa.Size = new System.Drawing.Size(40, 35);
            this.btnkapa.TabIndex = 6;
            this.btnkapa.Text = "kapat";
            this.btnkapa.Click += new System.EventHandler(this.btnkapa_Click);
            // 
            // btnfiltipt
            // 
            this.btnfiltipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltipt.ImageOptions.ImageIndex = 7;
            this.btnfiltipt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltipt.Location = new System.Drawing.Point(604, 99);
            this.btnfiltipt.Name = "btnfiltipt";
            this.btnfiltipt.Size = new System.Drawing.Size(54, 35);
            this.btnfiltipt.TabIndex = 5;
            this.btnfiltipt.Text = "filtreiptal";
            this.btnfiltipt.Click += new System.EventHandler(this.btnfiltipt_Click);
            // 
            // btnfiltre
            // 
            this.btnfiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltre.ImageOptions.ImageIndex = 7;
            this.btnfiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltre.Location = new System.Drawing.Point(558, 99);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(40, 35);
            this.btnfiltre.TabIndex = 4;
            this.btnfiltre.Text = "filtre";
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(716, 146);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContdodemet;
            this.filterControl1.TabIndex = 3;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContdodemet
            // 
            this.gridContdodemet.DataSource = this.odemeTuruBindingSource;
            this.gridContdodemet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContdodemet.Location = new System.Drawing.Point(0, 0);
            this.gridContdodemet.MainView = this.gridodemet;
            this.gridContdodemet.Name = "gridContdodemet";
            this.gridContdodemet.Size = new System.Drawing.Size(716, 148);
            this.gridContdodemet.TabIndex = 3;
            this.gridContdodemet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridodemet});
            // 
            // odemeTuruBindingSource
            // 
            this.odemeTuruBindingSource.DataSource = typeof(netsatis.tables.OdemeTuru);
            // 
            // gridodemet
            // 
            this.gridodemet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colAciklama,
            this.gridColkasagir,
            this.gridColkasacik,
            this.gridColbakiye});
            this.gridodemet.GridControl = this.gridContdodemet;
            this.gridodemet.Name = "gridodemet";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.Caption = "Ödeme T. Kodu";
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 0;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme T. Adı";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // gridColkasagir
            // 
            this.gridColkasagir.Caption = "Kasa Giriş";
            this.gridColkasagir.FieldName = "KasaGiris";
            this.gridColkasagir.Name = "gridColkasagir";
            this.gridColkasagir.Visible = true;
            this.gridColkasagir.VisibleIndex = 3;
            // 
            // gridColkasacik
            // 
            this.gridColkasacik.Caption = "Kasa Çıkış";
            this.gridColkasacik.FieldName = "KasaCikis";
            this.gridColkasacik.Name = "gridColkasacik";
            this.gridColkasacik.Visible = true;
            this.gridColkasacik.VisibleIndex = 4;
            // 
            // gridColbakiye
            // 
            this.gridColbakiye.Caption = "Bakiye";
            this.gridColbakiye.FieldName = "Bakiye";
            this.gridColbakiye.Name = "gridColbakiye";
            this.gridColbakiye.Visible = true;
            this.gridColbakiye.VisibleIndex = 5;
            // 
            // FrmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 413);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmOdemeTuru";
            this.Text = "FrmOdemeTuru";
            this.Load += new System.EventHandler(this.FrmOdemeTuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContdodemet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridodemet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnstokhareket;
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
        private DevExpress.XtraGrid.GridControl gridContdodemet;
        private System.Windows.Forms.BindingSource odemeTuruBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridodemet;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gridColkasagir;
        private DevExpress.XtraGrid.Columns.GridColumn gridColkasacik;
        private DevExpress.XtraGrid.Columns.GridColumn gridColbakiye;
    }
}