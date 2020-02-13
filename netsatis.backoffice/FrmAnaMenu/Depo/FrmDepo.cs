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

namespace netsatis.backoffice.FrmAnaMenu.Depo
{
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        DepoDAL depoDal = new DepoDAL();
        public FrmDepo()
        {
            InitializeComponent();
        }

        public  void FrmDepo_Load(object sender, EventArgs e)
        {
            Listele();

        }
        private void Listele()
        {
            gridContdepolar.DataSource = depoDal.GetAll(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnfiltipt_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnkapa_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("secili olan veriyi silmeye emin misiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = griddepo.GetFocusedRowCellValue(colDepoKodu).ToString();
                depoDal.Delete(context, c => c.DepoKodu == secilen);
                depoDal.Save(context);
                Listele();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmDepoİslem form = new FrmDepoİslem(new tables.Depo());
            form.ShowDialog();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {

            string secilen = griddepo.GetFocusedRowCellValue(colDepoKodu).ToString();
            FrmDepoİslem form = new FrmDepoİslem(depoDal.GetByFilter(context, c => c.DepoKodu == secilen));
            form.ShowDialog();
        }

        private void btndepohareket_Click(object sender, EventArgs e)
        {
            string secilen = griddepo.GetFocusedRowCellValue(colDepoKodu).ToString();
            string secilenad = griddepo.GetFocusedRowCellValue(colDepoAdi).ToString();
            FrmDepoHareket form = new FrmDepoHareket(secilen, secilenad);
            form.ShowDialog();
        }
    }
}