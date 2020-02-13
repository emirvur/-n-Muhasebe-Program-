namespace Netsatis.Reports.Fatura_ve_Fiş
{
    partial class rptFatura
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblcariadi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbladres = new DevExpress.XtraReports.UI.XRLabel();
            this.lblikametgah = new DevExpress.XtraReports.UI.XRLabel();
            this.lblfaturatarihi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblgeneltoplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblkdvtoplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblaratoplam = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colstokadi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colmiktar = new DevExpress.XtraReports.UI.XRTableCell();
            this.colbirimfiyat = new DevExpress.XtraReports.UI.XRTableCell();
            this.coltoplamtutar = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 16F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 36.45833F;
            this.Detail.Name = "Detail";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblfaturatarihi,
            this.lblikametgah,
            this.lbladres,
            this.lblcariadi});
            this.PageHeader.HeightF = 211.0833F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblaratoplam,
            this.lblkdvtoplam,
            this.lblgeneltoplam});
            this.PageFooter.Name = "PageFooter";
            // 
            // lblcariadi
            // 
            this.lblcariadi.LocationFloat = new DevExpress.Utils.PointFloat(550F, 30.16666F);
            this.lblcariadi.Multiline = true;
            this.lblcariadi.Name = "lblcariadi";
            this.lblcariadi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblcariadi.SizeF = new System.Drawing.SizeF(144.9999F, 23F);
            this.lblcariadi.Text = "Cari Adı";
            // 
            // lbladres
            // 
            this.lbladres.LocationFloat = new DevExpress.Utils.PointFloat(513.5417F, 53.16666F);
            this.lbladres.Multiline = true;
            this.lbladres.Name = "lbladres";
            this.lbladres.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbladres.SizeF = new System.Drawing.SizeF(181.4583F, 70.91666F);
            this.lbladres.Text = "Adres";
            // 
            // lblikametgah
            // 
            this.lblikametgah.LocationFloat = new DevExpress.Utils.PointFloat(513.5417F, 124.0833F);
            this.lblikametgah.Multiline = true;
            this.lblikametgah.Name = "lblikametgah";
            this.lblikametgah.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblikametgah.SizeF = new System.Drawing.SizeF(181.4583F, 23F);
            this.lblikametgah.Text = "semt-il-ilçe";
            // 
            // lblfaturatarihi
            // 
            this.lblfaturatarihi.LocationFloat = new DevExpress.Utils.PointFloat(513.5417F, 147.0833F);
            this.lblfaturatarihi.Multiline = true;
            this.lblfaturatarihi.Name = "lblfaturatarihi";
            this.lblfaturatarihi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblfaturatarihi.SizeF = new System.Drawing.SizeF(181.4583F, 23F);
            this.lblfaturatarihi.Text = "Fatura tarihi";
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.LocationFloat = new DevExpress.Utils.PointFloat(513.5418F, 62.5F);
            this.lblgeneltoplam.Multiline = true;
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblgeneltoplam.SizeF = new System.Drawing.SizeF(181.4583F, 23F);
            this.lblgeneltoplam.Text = "Fatura tarihi";
            // 
            // lblkdvtoplam
            // 
            this.lblkdvtoplam.LocationFloat = new DevExpress.Utils.PointFloat(513.5418F, 39.50002F);
            this.lblkdvtoplam.Multiline = true;
            this.lblkdvtoplam.Name = "lblkdvtoplam";
            this.lblkdvtoplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblkdvtoplam.SizeF = new System.Drawing.SizeF(181.4583F, 23F);
            this.lblkdvtoplam.Text = "Fatura tarihi";
            // 
            // lblaratoplam
            // 
            this.lblaratoplam.LocationFloat = new DevExpress.Utils.PointFloat(513.5418F, 10.00001F);
            this.lblaratoplam.Multiline = true;
            this.lblaratoplam.Name = "lblaratoplam";
            this.lblaratoplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblaratoplam.SizeF = new System.Drawing.SizeF(181.4583F, 23F);
            this.lblaratoplam.Text = "Fatura tarihi";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.458327F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(498.6111F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colstokadi,
            this.colmiktar,
            this.colbirimfiyat,
            this.coltoplamtutar});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colstokadi
            // 
            this.colstokadi.Multiline = true;
            this.colstokadi.Name = "colstokadi";
            this.colstokadi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.colstokadi.Text = "Stok Adı";
            this.colstokadi.Weight = 1D;
            // 
            // colmiktar
            // 
            this.colmiktar.Multiline = true;
            this.colmiktar.Name = "colmiktar";
            this.colmiktar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.colmiktar.Text = "Miktar";
            this.colmiktar.Weight = 1D;
            // 
            // colbirimfiyat
            // 
            this.colbirimfiyat.Multiline = true;
            this.colbirimfiyat.Name = "colbirimfiyat";
            this.colbirimfiyat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.colbirimfiyat.Text = "Birim fiyat";
            this.colbirimfiyat.Weight = 1D;
            // 
            // coltoplamtutar
            // 
            this.coltoplamtutar.Multiline = true;
            this.coltoplamtutar.Name = "coltoplamtutar";
            this.coltoplamtutar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.coltoplamtutar.Text = "toplam tutar";
            this.coltoplamtutar.Weight = 1D;
            // 
            // rptFatura
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 55, 16, 100);
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel lblfaturatarihi;
        private DevExpress.XtraReports.UI.XRLabel lblikametgah;
        private DevExpress.XtraReports.UI.XRLabel lbladres;
        private DevExpress.XtraReports.UI.XRLabel lblcariadi;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colstokadi;
        private DevExpress.XtraReports.UI.XRTableCell colmiktar;
        private DevExpress.XtraReports.UI.XRTableCell colbirimfiyat;
        private DevExpress.XtraReports.UI.XRTableCell coltoplamtutar;
        private DevExpress.XtraReports.UI.XRLabel lblaratoplam;
        private DevExpress.XtraReports.UI.XRLabel lblkdvtoplam;
        private DevExpress.XtraReports.UI.XRLabel lblgeneltoplam;
    }
}
