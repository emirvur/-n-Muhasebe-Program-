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
using netsatis.tables;
using netsatis.DataAccess;
using netsatis.Context;
using netsatis.backoffice.FrmAnaMenu.Fis;

namespace netsatis.backoffice.FrmAnaMenu.Kasa_Hareket
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        KasaHareketDAL kasahareketDal = new KasaHareketDAL();
        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void listele()
        {
            gridContkasahar.DataSource = kasahareketDal.GetAll(context);
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btndetay_Click(object sender, EventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(gridkasahar.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnfiltip_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnkap_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }
    }
}