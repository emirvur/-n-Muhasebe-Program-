namespace netsatis.backoffice.FrmAnaMenu.Hızlı_Satış
{
    partial class FrmHizliSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHizliSatis));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hizliSatisGrupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupgenel = new DevExpress.XtraEditors.GroupControl();
            this.memotxtacıklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtgrupadı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnyeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnvazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hizliSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizliSatisGrupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).BeginInit();
            this.groupgenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memotxtacıklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrupadı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizliSatisBindingSource)).BeginInit();
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
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Hızlı Satış İşlemleri";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 36);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupgenel);
            this.splitContainerControl1.Panel1.Controls.Add(this.grpMenu);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(821, 425);
            this.splitContainerControl1.SplitterPosition = 380;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hizliSatisGrupBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(380, 216);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hizliSatisGrupBindingSource
            // 
            this.hizliSatisGrupBindingSource.DataSource = typeof(netsatis.tables.HizliSatisGrup);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGrupAdi,
            this.colAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 0;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            // 
            // groupgenel
            // 
            this.groupgenel.Controls.Add(this.memotxtacıklama);
            this.groupgenel.Controls.Add(this.txtgrupadı);
            this.groupgenel.Controls.Add(this.labelControl1);
            this.groupgenel.Controls.Add(this.labelControl10);
            this.groupgenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupgenel.Location = new System.Drawing.Point(0, 0);
            this.groupgenel.Name = "groupgenel";
            this.groupgenel.Size = new System.Drawing.Size(380, 143);
            this.groupgenel.TabIndex = 4;
            this.groupgenel.Text = "Genel Bilgiler";
            // 
            // memotxtacıklama
            // 
            this.memotxtacıklama.Location = new System.Drawing.Point(65, 70);
            this.memotxtacıklama.Name = "memotxtacıklama";
            this.memotxtacıklama.Size = new System.Drawing.Size(124, 59);
            this.memotxtacıklama.TabIndex = 5;
            // 
            // txtgrupadı
            // 
            this.txtgrupadı.Location = new System.Drawing.Point(65, 38);
            this.txtgrupadı.Name = "txtgrupadı";
            this.txtgrupadı.Size = new System.Drawing.Size(115, 20);
            this.txtgrupadı.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(5, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Grup Adı";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(12, 71);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 15);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Açıklama:";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnyeni);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnvazgec);
            this.grpMenu.Controls.Add(this.btnkaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 359);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(380, 66);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btnyeni
            // 
            this.btnyeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnyeni.ImageOptions.ImageIndex = 0;
            this.btnyeni.Location = new System.Drawing.Point(37, 19);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(75, 35);
            this.btnyeni.TabIndex = 2;
            this.btnyeni.Text = "yeni";
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // btnsil
            // 
            this.btnsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsil.ImageOptions.ImageIndex = 0;
            this.btnsil.Location = new System.Drawing.Point(131, 19);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 35);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvazgec.ImageOptions.ImageIndex = 1;
            this.btnvazgec.Location = new System.Drawing.Point(293, 19);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(75, 35);
            this.btnvazgec.TabIndex = 0;
            this.btnvazgec.Text = "vazgeç";
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkaydet.ImageOptions.ImageIndex = 0;
            this.btnkaydet.Location = new System.Drawing.Point(212, 19);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 35);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnekle);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 359);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(436, 66);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Menü";
            // 
            // btnekle
            // 
            this.btnekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnekle.ImageOptions.ImageIndex = 0;
            this.btnekle.Location = new System.Drawing.Point(93, 19);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 35);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 0;
            this.simpleButton2.Location = new System.Drawing.Point(187, 19);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 35);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 1;
            this.btnkapat.Location = new System.Drawing.Point(349, 19);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.hizliSatisBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(436, 359);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colBarkod,
            this.colUrunAdi,
            this.colGrupId});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // hizliSatisBindingSource
            // 
            this.hizliSatisBindingSource.DataSource = typeof(netsatis.tables.HizliSatis);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 0;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colGrupId
            // 
            this.colGrupId.FieldName = "GrupId";
            this.colGrupId.Name = "colGrupId";
            // 
            // FrmHizliSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 461);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmHizliSatis";
            this.Text = "FrmHizliSatis";
            this.Load += new System.EventHandler(this.FrmHizliSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizliSatisGrupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).EndInit();
            this.groupgenel.ResumeLayout(false);
            this.groupgenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memotxtacıklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrupadı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizliSatisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnvazgec;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.GroupControl groupgenel;
        private DevExpress.XtraEditors.MemoEdit memotxtacıklama;
        private DevExpress.XtraEditors.TextEdit txtgrupadı;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnyeni;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private System.Windows.Forms.BindingSource hizliSatisGrupBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private System.Windows.Forms.BindingSource hizliSatisBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupId;
    }
}