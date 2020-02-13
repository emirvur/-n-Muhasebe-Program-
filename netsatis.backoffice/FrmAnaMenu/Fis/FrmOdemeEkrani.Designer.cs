namespace netsatis.backoffice.FrmAnaMenu.Fis
{
    partial class FrmOdemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeEkrani));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupgenel = new DevExpress.XtraEditors.GroupControl();
            this.memotxtacıklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtkasaad = new DevExpress.XtraEditors.TextEdit();
            this.txtodemeturu = new DevExpress.XtraEditors.TextEdit();
            this.txtkasakodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnkasasec = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.calcEdittutar = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).BeginInit();
            this.groupgenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memotxtacıklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasaad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtodemeturu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasakodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdittutar.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(410, 36);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Tutar Bilgileri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnkaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 293);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(410, 66);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 1;
            this.btnkapat.Location = new System.Drawing.Point(323, 19);
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
            this.btnkaydet.Location = new System.Drawing.Point(242, 19);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 35);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupgenel
            // 
            this.groupgenel.Controls.Add(this.calcEdittutar);
            this.groupgenel.Controls.Add(this.simpleButton2);
            this.groupgenel.Controls.Add(this.btnkasasec);
            this.groupgenel.Controls.Add(this.memotxtacıklama);
            this.groupgenel.Controls.Add(this.txtkasaad);
            this.groupgenel.Controls.Add(this.txtodemeturu);
            this.groupgenel.Controls.Add(this.txtkasakodu);
            this.groupgenel.Controls.Add(this.labelControl5);
            this.groupgenel.Controls.Add(this.labelControl4);
            this.groupgenel.Controls.Add(this.labelControl3);
            this.groupgenel.Controls.Add(this.labelControl2);
            this.groupgenel.Controls.Add(this.labelControl1);
            this.groupgenel.Controls.Add(this.labelControl10);
            this.groupgenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupgenel.Location = new System.Drawing.Point(0, 36);
            this.groupgenel.Name = "groupgenel";
            this.groupgenel.Size = new System.Drawing.Size(410, 186);
            this.groupgenel.TabIndex = 4;
            this.groupgenel.Text = "Genel Bilgiler";
            // 
            // memotxtacıklama
            // 
            this.memotxtacıklama.Location = new System.Drawing.Point(65, 135);
            this.memotxtacıklama.Name = "memotxtacıklama";
            this.memotxtacıklama.Size = new System.Drawing.Size(124, 51);
            this.memotxtacıklama.TabIndex = 5;
            // 
            // txtkasaad
            // 
            this.txtkasaad.Location = new System.Drawing.Point(65, 83);
            this.txtkasaad.Name = "txtkasaad";
            this.txtkasaad.Size = new System.Drawing.Size(316, 20);
            this.txtkasaad.TabIndex = 2;
            // 
            // txtodemeturu
            // 
            this.txtodemeturu.Location = new System.Drawing.Point(65, 23);
            this.txtodemeturu.Name = "txtodemeturu";
            this.txtodemeturu.Size = new System.Drawing.Size(115, 20);
            this.txtodemeturu.TabIndex = 2;
            // 
            // txtkasakodu
            // 
            this.txtkasakodu.Location = new System.Drawing.Point(65, 53);
            this.txtkasakodu.Name = "txtkasakodu";
            this.txtkasakodu.Size = new System.Drawing.Size(115, 20);
            this.txtkasakodu.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(5, 106);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 15);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tutar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(5, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 15);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Kasa Adı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(5, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 15);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Durumu";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(5, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 15);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ödeme Türü";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(5, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(12, 127);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 15);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Açıklama:";
            // 
            // btnkasasec
            // 
            this.btnkasasec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnkasasec.Location = new System.Drawing.Point(242, 26);
            this.btnkasasec.Name = "btnkasasec";
            this.btnkasasec.Size = new System.Drawing.Size(112, 51);
            this.btnkasasec.TabIndex = 6;
            this.btnkasasec.Click += new System.EventHandler(this.btnkasasec_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(299, 46);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(8, 16);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // calcEdittutar
            // 
            this.calcEdittutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.calcEdittutar.Location = new System.Drawing.Point(65, 104);
            this.calcEdittutar.Name = "calcEdittutar";
            this.calcEdittutar.Properties.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.calcEdittutar.Properties.Appearance.Options.UseBackColor = true;
            this.calcEdittutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdittutar.Size = new System.Drawing.Size(150, 20);
            this.calcEdittutar.TabIndex = 8;
            // 
            // FrmOdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 359);
            this.Controls.Add(this.groupgenel);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmOdemeEkrani";
            this.Text = "FrmOdemeEkrani";
            this.Load += new System.EventHandler(this.FrmOdemeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupgenel)).EndInit();
            this.groupgenel.ResumeLayout(false);
            this.groupgenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memotxtacıklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasaad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtodemeturu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasakodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdittutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.GroupControl groupgenel;
        private DevExpress.XtraEditors.MemoEdit memotxtacıklama;
        private DevExpress.XtraEditors.TextEdit txtkasaad;
        private DevExpress.XtraEditors.TextEdit txtodemeturu;
        private DevExpress.XtraEditors.TextEdit txtkasakodu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnkasasec;
        private DevExpress.XtraEditors.CalcEdit calcEdittutar;
    }
}