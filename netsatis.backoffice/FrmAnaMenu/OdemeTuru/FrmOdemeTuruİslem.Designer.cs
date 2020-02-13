namespace netsatis.backoffice.FrmAnaMenu.OdemeTuru
{
    partial class FrmOdemeTuruİslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuruİslem));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupgenel = new DevExpress.XtraEditors.GroupControl();
            this.txtodemeturukodu = new DevExpress.XtraEditors.TextEdit();
            this.txtodemeturuadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.memoaciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).BeginInit();
            this.groupgenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtodemeturukodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtodemeturuadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoaciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(333, 36);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Ödeme Türü İşlemleri";
            // 
            // groupgenel
            // 
            this.groupgenel.Controls.Add(this.txtodemeturukodu);
            this.groupgenel.Controls.Add(this.txtodemeturuadi);
            this.groupgenel.Controls.Add(this.labelControl26);
            this.groupgenel.Controls.Add(this.labelControl1);
            this.groupgenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupgenel.Location = new System.Drawing.Point(0, 36);
            this.groupgenel.Name = "groupgenel";
            this.groupgenel.Size = new System.Drawing.Size(333, 74);
            this.groupgenel.TabIndex = 12;
            this.groupgenel.Text = "Genel Bilgiler";
            // 
            // txtodemeturukodu
            // 
            this.txtodemeturukodu.Location = new System.Drawing.Point(106, 21);
            this.txtodemeturukodu.Name = "txtodemeturukodu";
            this.txtodemeturukodu.Size = new System.Drawing.Size(115, 20);
            this.txtodemeturukodu.TabIndex = 2;
            this.txtodemeturukodu.EditValueChanged += new System.EventHandler(this.txtdepokodu_EditValueChanged);
            // 
            // txtodemeturuadi
            // 
            this.txtodemeturuadi.Location = new System.Drawing.Point(106, 47);
            this.txtodemeturuadi.Name = "txtodemeturuadi";
            this.txtodemeturuadi.Size = new System.Drawing.Size(115, 20);
            this.txtodemeturuadi.TabIndex = 2;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl26.Appearance.Options.UseBorderColor = true;
            this.labelControl26.Appearance.Options.UseTextOptions = true;
            this.labelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl26.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl26.Location = new System.Drawing.Point(8, 23);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(92, 15);
            this.labelControl26.TabIndex = 0;
            this.labelControl26.Text = "Odeme Turu Kodu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(7, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Odeme Turu Adı:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.memoaciklama);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl25);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 110);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(333, 86);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "Diğer Bilgiler";
            // 
            // memoaciklama
            // 
            this.memoaciklama.Location = new System.Drawing.Point(75, 22);
            this.memoaciklama.Name = "memoaciklama";
            this.memoaciklama.Size = new System.Drawing.Size(124, 59);
            this.memoaciklama.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(8, 237);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Stok Grubu:";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(13, 24);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(41, 13);
            this.labelControl25.TabIndex = 0;
            this.labelControl25.Text = "Açıklama";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnkaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 199);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(333, 65);
            this.grpMenu.TabIndex = 16;
            this.grpMenu.Text = "Menü";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 1;
            this.btnkapat.Location = new System.Drawing.Point(246, 18);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkaydet.ImageOptions.ImageIndex = 0;
            this.btnkaydet.Location = new System.Drawing.Point(165, 18);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 35);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // FrmOdemeTuruİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 264);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupgenel);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmOdemeTuruİslem";
            this.Text = "FrmOdemeTuruİslem";
            this.Load += new System.EventHandler(this.FrmOdemeTuruİslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).EndInit();
            this.groupgenel.ResumeLayout(false);
            this.groupgenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtodemeturukodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtodemeturuadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoaciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupgenel;
        private DevExpress.XtraEditors.TextEdit txtodemeturukodu;
        private DevExpress.XtraEditors.TextEdit txtodemeturuadi;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit memoaciklama;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
    }
}