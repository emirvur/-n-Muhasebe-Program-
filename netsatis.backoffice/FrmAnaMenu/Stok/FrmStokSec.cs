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

namespace netsatis.backoffice.FrmAnaMenu.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        netsatisContext context = new netsatisContext();
        public List<tables.Stok> secilen = new List<tables.Stok>();
        public bool secildi = false;
        public FrmStokSec(bool cokluSecim=false)
          
        {
            InitializeComponent();
            if (cokluSecim == true){
                lbluyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
        }

        private void FrmStokSec_Load(object sender,EventArgs e)
        {
            gridcontStoklar.DataSource = stokDal.StokListele(context);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (gridView2.GetSelectedRows().Length != 0)
            {


                foreach (var row in gridView1.GetSelectedRows())
                {
                    string stokkodu = gridView1.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("secilen urun bulunamadı");      }
        }

        private void FrmStokSec_Load_1(object sender, EventArgs e)
        {

        }
    }
}