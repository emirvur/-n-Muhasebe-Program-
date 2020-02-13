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

namespace netsatis.backoffice.FrmAnaMenu.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        DepoDAL depoDal = new DepoDAL();
        public tables.Depo entity=new tables.Depo();
        private string _stokKodu;
        public bool secildi = false;
        public FrmDepoSec(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridContdeposec.DataSource = depoDal.DepoBazindaStokListele(context, _stokKodu);
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (griddeposec.SelectedRowsCount != 0)
            {
                string depokodu = griddeposec.GetFocusedRowCellValue(colDepoKodu).ToString();
              
                entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depokodu);
                secildi = true;
                this.Close();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}