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

namespace netsatis.backoffice.FrmAnaMenu.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        public bool secildi = false;
        netsatisContext context = new netsatisContext();
        public List<tables.Cari> secilen = new List<tables.Cari>();
        public FrmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim == true)
            {
                lbluyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
            gridControl1.DataSource = cariDal.GetCariler(context);

        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));
                   
                }
                secildi = true;
                this.Close();
               
            }
            else
            {
                MessageBox.Show("secilen cari bulunamadı");
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}