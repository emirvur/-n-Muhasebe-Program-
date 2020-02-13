using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using netsatis.Context;
using netsatis.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace Netsatis.Reports.Stok
{
    public partial class rptStokdurumu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokdurumu()
        {
            InitializeComponent();
            netsatisContext context = new netsatisContext();
            StokDAL stokDal = new StokDAL();

            ObjectDataSource stokdatasource = new ObjectDataSource { DataSource = stokDal.StokListele(context) };
            this.DataSource = stokdatasource;
            colstokkodu.DataBindings.Add("Text",this.DataSource,"StokKodu");
            colbarkod.DataBindings.Add("Text", this.DataSource, "Barkod");

            colstokadı.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colbirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colstokgrubu.DataBindings.Add("Text", this.DataSource, "StokGrubu");
            colstokaltgrubu.DataBindings.Add("Text", this.DataSource, "StokAltGrubu");
            colstokkdv.DataBindings.Add("Text", this.DataSource, "SatisKdv");
            colstokgiri.DataBindings.Add("Text", this.DataSource, "StokGiris");

            colstokcik.DataBindings.Add("Text", this.DataSource, "StokCikis");

            colmevcutsto.DataBindings.Add("Text", this.DataSource, "MevcutStok");

        }

    }
}
