using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using netsatis.Context;
using netsatis.DataAccess;
using DevExpress.DataAccess.ObjectBinding;
using netsatis.tables;

namespace Netsatis.Reports.Stok
{
    public partial class RptStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {

        public RptStokHareketleri()
        {
            InitializeComponent();
            netsatisContext context = new netsatisContext();
            StokHareketDAL stokhareketDal = new StokHareketDAL();

            ObjectDataSource datasource = new ObjectDataSource { DataSource = stokhareketDal.GetAll(context) };

            this.DataSource = datasource;

            colfiskodu.DataBindings.Add("Text",this.DataSource,"FisKodu");
            colhareket.DataBindings.Add("Text", this.DataSource, "Hareket");

            colstokkodu.DataBindings.Add("Text", this.DataSource, "StokKodu");

            colbarkod.DataBindings.Add("Text", this.DataSource, "Barkod");

            colstokadi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colbirimi.DataBindings.Add("Text", this.DataSource, "Birimi");

            colkdv.DataBindings.Add("Text", this.DataSource, "Kdv");

            colmiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colbirimfiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati");
            colindirimoran.DataBindings.Add("Text", this.DataSource, "IndirimOrani");

         


        }

    }
}
