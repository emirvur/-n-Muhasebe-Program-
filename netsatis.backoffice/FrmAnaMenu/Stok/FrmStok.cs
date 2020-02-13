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
using netsatis.backoffice.FrmAnaMenu.Stok;

namespace netsatis.backoffice
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {    netsatisContext context=new netsatisContext();
        StokDAL stokdal = new StokDAL();
    
        public FrmStok()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            FrmStok frmstok = new FrmStok();
            GetAll();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        public void GetAll()
        {
            gridControl1.DataSource=stokdal.StokListele(context);

          
        }

        private void Buttonfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void Buttonfiltreiptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();

        }

        private void btnfiltrekapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmStokIslem form = new FrmStokIslem(new Stok());
            form.ShowDialog();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokIslem form = new FrmStokIslem(stokdal.GetByFilter(context, c => c.StokKodu == secilen));
            form.ShowDialog();


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("secili olan veriyi silmeye emin misiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokdal.Delete(context, c => c.StokKodu == secilen);
                stokdal.Save(context);
                GetAll();
            }
        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colıd));
            netsatis.tables.Stok stokentity = new netsatis.tables.Stok();
            stokentity = stokdal.GetByFilter(context, c => c.Id == secilen);
            stokentity.Id = -1;
            stokentity.StokKodu = null;
            FrmStokIslem form = new FrmStokIslem(stokentity,true);
            form.ShowDialog();

        }

        private void btnaraClick(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokHareket form = new FrmStokHareket(secilen);
            form.ShowDialog();
        }

        private void grpMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}