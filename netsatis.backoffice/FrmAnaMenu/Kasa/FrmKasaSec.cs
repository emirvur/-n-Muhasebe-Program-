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

namespace netsatis.backoffice.FrmAnaMenu.Kasa
{
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        public bool secildi = false;
        KasaDAL kasaDal = new KasaDAL();
        netsatisContext context = new netsatisContext();
        public tables.Kasa entity = new tables.Kasa();
        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridContSec.DataSource = kasaDal.KasaListele(context);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {


                string kasakodu = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();

                entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
                secildi = true;
                this.Close();
            }
        }
    }
}