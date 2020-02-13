using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using netsatis.Context;
using netsatis.DataAccess;
using netsatis.tables;

namespace netsatis.backoffice.FrmAnaMenu.Fis
{
    public partial class FrmFis : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasahareketDal = new KasaHareketDAL();
        StokHareketDAL stokhareketDal = new StokHareketDAL();
        public FrmFis()
        {
            InitializeComponent();
        }

        private void FrmFis_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            context = new netsatisContext();
            gridContfis.DataSource = fisDal.GetAll(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnka_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnfilip_Click(object sender, EventArgs e)
        {
       
           filterControl1.FilterString = null;
            filterControl1.ApplyFilter();

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("secili olan veriyi silmeye emin misiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridfis.GetFocusedRowCellValue(colFisKodu).ToString();
                fisDal.Delete(context, c => c.FisKodu == secilen);
                kasahareketDal.Delete(context,c=>c.FisKodu==secilen);
                stokhareketDal.Delete(context, c => c.FisKodu == secilen);

                fisDal.Save(context);
                Listele();
            }
        }

        private void baralisfatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Alış Faturası");
            form.ShowDialog();
        }

        private void barperakendesatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Perakende Satış Faturası");
            form.ShowDialog();
        }

        private void bartoptansat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Toptan Satış Faturası");
            form.ShowDialog();
        }

        private void baralisiade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Alış İade Faturası");
            form.ShowDialog();
        }

        private void barsatisiade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Satış İade Faturası");
            form.ShowDialog();
        }

        private void bartahsilatfis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Tahsilat Fişi");
            form.ShowDialog();
        }

        private void barodemefisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Ödeme Fişi");
            form.ShowDialog();
        }

        private void barcaridevirfis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Cari Devir Fişi");
            form.ShowDialog();
        }

        private void barsayimfazla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Sayım Fazlası Fişi");
            form.ShowDialog();
        }

        private void barsayimeksi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Sayım Eksiği Fişi");
            form.ShowDialog();
        }

        private void barstokdevir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null, "Stok Devir Fişi");
            form.ShowDialog();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridfis.GetFocusedRowCellValue(colFisKodu).ToString();
            FrmFisİslem form = new FrmFisİslem(fisDal.GetByFilter(context,c=>c.FisKodu==secilen).FisKodu.ToString());

        }
    }
}