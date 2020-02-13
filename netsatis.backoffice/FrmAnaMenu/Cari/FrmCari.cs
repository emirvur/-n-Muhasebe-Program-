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
using netsatis.Context;
using netsatis.DataAccess;
using netsatis.tables;
using netsatis.backoffice.FrmAnaMenu.Cari;


namespace netsatis.backoffice.FrmAnaMenu.Cari
{
    public partial class FrmCari : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        CariDAL cariDal = new CariDAL();
        
        public FrmCari()
        {
            InitializeComponent();
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            FrmCari frmcari = new FrmCari();
            GetAll();
        }

        private void simpleBbutton1_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnfiltip_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("secili olan veriyi silmeye emin misiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                cariDal.Delete(context, c => c.CariKodu == secilen);
                cariDal.Save(context);
                GetAll();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmCariİslem form = new FrmCariİslem(new tables.Cari());
            form.ShowDialog();
           
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariİslem form = new FrmCariİslem(cariDal.GetByFilter(context, c => c.CariKodu == secilen));
            form.ShowDialog();
        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            netsatis.tables.Cari carientity = new netsatis.tables.Cari();
            carientity = cariDal.GetByFilter(context, c => c.Id == secilen);
            carientity.Id = -1;
            carientity.CariKodu = null;
            FrmCariİslem form = new FrmCariİslem(carientity,true);
            form.ShowDialog();
        }

        private void btnstokhareket_Click(object sender, EventArgs e)
        {
           
            string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            string secilenad = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
            FrmCariHareket form = new FrmCariHareket(secilen,secilenad);
            form.ShowDialog();
        }

        private void filterControl1_Click(object sender, EventArgs e)
        {

        }
    }
}