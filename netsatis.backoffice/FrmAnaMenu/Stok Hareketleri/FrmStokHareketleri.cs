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
using netsatis.tables;
using netsatis.DataAccess;
using netsatis.backoffice.FrmAnaMenu.Fis;

namespace netsatis.backoffice.FrmAnaMenu.Stok_Hareketleri
{
    public partial class FrmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        StokHareketDAL stokhareketDal = new StokHareketDAL();
        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        private void listele()
        {
          gridContstokhar.DataSource=  stokhareketDal.GetAll(context);
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            listele();      }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkapa_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnfiltilpt_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void gridContstokhar_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridstokhar.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNo form = new FrmSeriNo(veri);
            form.kilitli = true;
            form.ShowDialog();
            
        }

        private void btndetay_Click(object sender, EventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(gridstokhar.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }
    }
}