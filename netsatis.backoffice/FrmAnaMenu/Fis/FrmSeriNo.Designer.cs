namespace netsatis.backoffice.FrmAnaMenu.Fis
{
    partial class FrmSeriNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeriNo));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnyeni = new DevExpress.XtraEditors.SimpleButton();
            this.groupgenel = new DevExpress.XtraEditors.GroupControl();
            this.txtserino = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.listserino = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).BeginInit();
            this.groupgenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtserino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listserino)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(380, 36);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Seri No Bilgileri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnkaydet);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnyeni);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 281);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(380, 65);
            this.grpMenu.TabIndex = 11;
            this.grpMenu.Text = "İşlemler";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 1;
            this.btnkapat.Location = new System.Drawing.Point(277, 23);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnyeni
            // 
            this.btnyeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnyeni.ImageOptions.ImageIndex = 0;
            this.btnyeni.Location = new System.Drawing.Point(12, 23);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(54, 35);
            this.btnyeni.TabIndex = 0;
            this.btnyeni.Text = "yeni";
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // groupgenel
            // 
            this.groupgenel.Controls.Add(this.txtserino);
            this.groupgenel.Controls.Add(this.labelControl26);
            this.groupgenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupgenel.Location = new System.Drawing.Point(0, 36);
            this.groupgenel.Name = "groupgenel";
            this.groupgenel.Size = new System.Drawing.Size(380, 54);
            this.groupgenel.TabIndex = 12;
            this.groupgenel.Text = "Genel Bilgiler";
            // 
            // txtserino
            // 
            this.txtserino.Location = new System.Drawing.Point(66, 21);
            this.txtserino.Name = "txtserino";
            this.txtserino.Size = new System.Drawing.Size(115, 20);
            this.txtserino.TabIndex = 2;
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
            this.labelControl26.Size = new System.Drawing.Size(39, 15);
            this.labelControl26.TabIndex = 0;
            this.labelControl26.Text = "Seri no:";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkaydet.ImageOptions.ImageIndex = 0;
            this.btnkaydet.Location = new System.Drawing.Point(126, 23);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(55, 35);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsil.ImageOptions.ImageIndex = 0;
            this.btnsil.Location = new System.Drawing.Point(72, 25);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(52, 35);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // listserino
            // 
            this.listserino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listserino.Location = new System.Drawing.Point(0, 90);
            this.listserino.Name = "listserino";
            this.listserino.Size = new System.Drawing.Size(380, 191);
            this.listserino.TabIndex = 13;
            // 
            // FrmSeriNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 346);
            this.Controls.Add(this.listserino);
            this.Controls.Add(this.groupgenel);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmSeriNo";
            this.Text = "FrmSeriNo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeriNo_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeriNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).EndInit();
            this.groupgenel.ResumeLayout(false);
            this.groupgenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtserino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listserino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnyeni;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.GroupControl groupgenel;
        private DevExpress.XtraEditors.TextEdit txtserino;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.ListBoxControl listserino;
    }
}