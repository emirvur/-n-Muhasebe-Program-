namespace netsatis.backoffice.FrmAnaMenu.OdemeTuru
{
    partial class FrmTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTanim));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnvazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tanimbilgisi = new DevExpress.XtraEditors.GroupControl();
            this.txtAdres = new DevExpress.XtraEditors.ButtonEdit();
            this.txtSemt = new DevExpress.XtraEditors.ButtonEdit();
            this.txttanim = new DevExpress.XtraEditors.LabelControl();
            this.txtaciklama = new DevExpress.XtraEditors.LabelControl();
            this.btnsec = new DevExpress.XtraEditors.SimpleButton();
            this.gridColtanım = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColıd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tanimbilgisi)).BeginInit();
            this.Tanimbilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemt.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(598, 36);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Tanım";
            // 
            // btnekle
            // 
            this.btnekle.ImageOptions.ImageIndex = 1;
            this.btnekle.Location = new System.Drawing.Point(8, 23);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 35);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.ImageOptions.ImageIndex = 0;
            this.btnduzenle.Location = new System.Drawing.Point(89, 23);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(75, 35);
            this.btnduzenle.TabIndex = 0;
            this.btnduzenle.Text = "düzenle";
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.ImageIndex = 3;
            this.btnsil.Location = new System.Drawing.Point(170, 23);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 35);
            this.btnsil.TabIndex = 0;
            this.btnsil.Text = "sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Enabled = false;
            this.btnkaydet.ImageOptions.ImageIndex = 4;
            this.btnkaydet.Location = new System.Drawing.Point(251, 23);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 35);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.Enabled = false;
            this.btnvazgec.ImageOptions.ImageIndex = 8;
            this.btnvazgec.Location = new System.Drawing.Point(334, 23);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(73, 35);
            this.btnvazgec.TabIndex = 0;
            this.btnvazgec.Text = "vazgeç";
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 6;
            this.btnkapat.Location = new System.Drawing.Point(511, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnsec);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnvazgec);
            this.grpMenu.Controls.Add(this.btnkaydet);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnduzenle);
            this.grpMenu.Controls.Add(this.btnekle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 186);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(598, 78);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.Text = "Menü";
            this.grpMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.grpMenu_Paint);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 36);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(598, 150);
            this.navigationFrame1.TabIndex = 5;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(598, 150);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.Tanimbilgisi);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(598, 150);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(598, 150);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColıd,
            this.gridColtanım,
            this.gridColaciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Tanimbilgisi
            // 
            this.Tanimbilgisi.Controls.Add(this.txtAdres);
            this.Tanimbilgisi.Controls.Add(this.txtSemt);
            this.Tanimbilgisi.Controls.Add(this.txttanim);
            this.Tanimbilgisi.Controls.Add(this.txtaciklama);
            this.Tanimbilgisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tanimbilgisi.Location = new System.Drawing.Point(0, 0);
            this.Tanimbilgisi.Name = "Tanimbilgisi";
            this.Tanimbilgisi.Size = new System.Drawing.Size(598, 150);
            this.Tanimbilgisi.TabIndex = 0;
            this.Tanimbilgisi.Text = "groupControl1";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(63, 57);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtAdres.Size = new System.Drawing.Size(165, 20);
            this.txtAdres.TabIndex = 11;
            // 
            // txtSemt
            // 
            this.txtSemt.Location = new System.Drawing.Point(63, 31);
            this.txtSemt.Name = "txtSemt";
            this.txtSemt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtSemt.Size = new System.Drawing.Size(165, 20);
            this.txtSemt.TabIndex = 10;
            // 
            // txttanim
            // 
            this.txttanim.Location = new System.Drawing.Point(12, 33);
            this.txttanim.Name = "txttanim";
            this.txttanim.Size = new System.Drawing.Size(28, 13);
            this.txttanim.TabIndex = 9;
            this.txttanim.Text = "Tanım";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(12, 52);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(41, 13);
            this.txtaciklama.TabIndex = 8;
            this.txtaciklama.Text = "Açıklama";
            // 
            // btnsec
            // 
            this.btnsec.ImageOptions.ImageIndex = 8;
            this.btnsec.Location = new System.Drawing.Point(413, 23);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(73, 35);
            this.btnsec.TabIndex = 1;
            this.btnsec.Text = "seç";
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // gridColtanım
            // 
            this.gridColtanım.Caption = "Tanım";
            this.gridColtanım.FieldName = "Tanim";
            this.gridColtanım.Name = "gridColtanım";
            this.gridColtanım.OptionsColumn.AllowEdit = false;
            this.gridColtanım.Visible = true;
            this.gridColtanım.VisibleIndex = 0;
            // 
            // gridColaciklama
            // 
            this.gridColaciklama.Caption = "Açıklama";
            this.gridColaciklama.FieldName = "Aciklama";
            this.gridColaciklama.Name = "gridColaciklama";
            this.gridColaciklama.OptionsColumn.AllowEdit = false;
            this.gridColaciklama.Visible = true;
            this.gridColaciklama.VisibleIndex = 1;
            // 
            // gridColıd
            // 
            this.gridColıd.Caption = "Id";
            this.gridColıd.FieldName = "Id";
            this.gridColıd.Name = "gridColıd";
            this.gridColıd.OptionsColumn.AllowEdit = false;
            // 
            // FrmTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 264);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmTanim";
            this.Text = "FrmTanim";
            this.Load += new System.EventHandler(this.FrmTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tanimbilgisi)).EndInit();
            this.Tanimbilgisi.ResumeLayout(false);
            this.Tanimbilgisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton btnvazgec;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl Tanimbilgisi;
        private DevExpress.XtraEditors.ButtonEdit txtAdres;
        private DevExpress.XtraEditors.ButtonEdit txtSemt;
        private DevExpress.XtraEditors.LabelControl txttanim;
        private DevExpress.XtraEditors.LabelControl txtaciklama;
        private DevExpress.XtraEditors.SimpleButton btnsec;
        private DevExpress.XtraGrid.Columns.GridColumn gridColtanım;
        private DevExpress.XtraGrid.Columns.GridColumn gridColaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gridColıd;
    }
}