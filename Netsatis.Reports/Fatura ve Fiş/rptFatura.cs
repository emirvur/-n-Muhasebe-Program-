using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using netsatis.Context;
using netsatis.DataAccess;
using netsatis.tables;
using DevExpress.DataAccess.ObjectBinding;

namespace Netsatis.Reports.Fatura_ve_Fiş
{
    public partial class rptFatura : DevExpress.XtraReports.UI.XtraReport
    {
        public rptFatura(string fisKodu)
        {
            InitializeComponent();
            netsatisContext context = new netsatisContext();
            FisDAL fisDal = new FisDAL();
            Fis fisBilgi = fisDal.GetByFilter(context,c=>c.FisKodu==fisKodu);
            StokHareketDAL stokhareketDal = new StokHareketDAL();

            ObjectDataSource stokhareketdatasource = new ObjectDataSource { DataSource = stokhareketDal.GetAll(context,c=>c.FisKodu==fisKodu) };
            lblcariadi.Text = fisBilgi.CariAdi;
            lbladres.Text = fisBilgi.Adres;
            lblfaturatarihi.Text = fisBilgi.Tarih.ToString();
            lblikametgah.Text = fisBilgi.Semt + "\\" + fisBilgi.Ilce + "\\" + fisBilgi.Il;

            this.DataSource = stokhareketdatasource;

            colstokadi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colmiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colbirimfiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati");

            CalculatedField calcindirimtutari = new CalculatedField();
            this.CalculatedFields.Add(calcindirimtutari);
            calcindirimtutari.Name = "İndirimTutari";
            calcindirimtutari.Expression = "([BirimFiyati]*[Miktar])/100*[IndirimOrani]";

            CalculatedField calckdvtoplam = new CalculatedField();
            this.CalculatedFields.Add(calckdvtoplam);
            calckdvtoplam.Name = "KdvTutari";
            calckdvtoplam.Expression = "([BirimFiyati]*[Miktar]-[IndirimOrani])/100*[Kdv]";

            CalculatedField calctutar = new CalculatedField();
            this.CalculatedFields.Add(calctutar);
            calctutar.Name = "Tutar";
            calctutar.Expression = "([BirimFiyati]*[Miktar])-[IndirimTutari]-[KdvTutari]";

            CalculatedField calckdvlitutar = new CalculatedField();
            this.CalculatedFields.Add(calckdvlitutar);
            calckdvlitutar.Name = "KdvliTutar";
            calckdvlitutar.Expression = "([BirimFiyati]*[Miktar])-[IndirimTutari]";

            coltoplamtutar.DataBindings.Add("Text",null,"Tutar");

            XRSummary sumaratoplam = new XRSummary();
            sumaratoplam.Func = SummaryFunc.Sum;
            sumaratoplam.Running = SummaryRunning.Page;
            sumaratoplam.FormatString ="{0:C2}";

            XRSummary sumkdvtoplam = new XRSummary();
            sumkdvtoplam.Func = SummaryFunc.Sum;
            sumkdvtoplam.Running = SummaryRunning.Page;
            sumkdvtoplam.FormatString = "{0:C2}";

            XRSummary sumgeneltoplam = new XRSummary();
            sumgeneltoplam.Func = SummaryFunc.Sum;
            sumgeneltoplam.Running = SummaryRunning.Page;
            sumgeneltoplam.FormatString = "{0:C2}";

            lblaratoplam.Summary = sumaratoplam;
            lblkdvtoplam.Summary = sumkdvtoplam;
            lblgeneltoplam.Summary = sumgeneltoplam;

            lblaratoplam.DataBindings.Add("Text",null,"Tutar");
            lblkdvtoplam.DataBindings.Add("Text", null, "KdvTutari");
            lblgeneltoplam.DataBindings.Add("Text", null, "KdvliTutar");


        }

    }
}
