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
using netsatis.backoffice.FrmAnaMenu.OdemeTuru;

namespace netsatis.backoffice.FrmAnaMenu
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        OdemeTuruDAL odemeturuDal = new OdemeTuruDAL();
        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            gridContdodemet.DataSource = odemeturuDal.OdemeTuruListele(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();

        }

        private void btnfiltipt_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnkapa_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("secili olan veriyi silmeye emin misiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridodemet.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                odemeturuDal.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeturuDal.Save(context);
                Listele();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruİslem form = new FrmOdemeTuruİslem(new tables.OdemeTuru());
            form.ShowDialog();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridodemet.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            FrmOdemeTuruİslem form = new FrmOdemeTuruİslem(odemeturuDal.GetByFilter(context, c => c.OdemeTuruKodu == secilen));
            form.ShowDialog();
        }

        private void btndepohareket_Click(object sender, EventArgs e)
        {
            string secilen = gridodemet.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            string secilenad = gridodemet.GetFocusedRowCellValue(colOdemeTuruAdi).ToString();
            FrmOdemeTuruHareket form = new FrmOdemeTuruHareket(secilen, secilenad);
            form.ShowDialog();
        }
    }
}