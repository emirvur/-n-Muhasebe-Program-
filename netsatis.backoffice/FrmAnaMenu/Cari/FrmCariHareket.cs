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

namespace netsatis.backoffice.FrmAnaMenu.Cari
{
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        private string _cariKodu = null;
        netsatisContext context = new netsatisContext();
        public FrmCariHareket(string cariKodu,string cariAdi)
        {
            InitializeComponent();
            _cariKodu = cariKodu;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
          gridControl2.DataSource = cariDal.CariFisGenelToplam(context, _cariKodu);
            gridControl3.DataSource  = cariDal.CariGenelToplam(context, _cariKodu);
            gridContcariHareket.DataSource  = cariDal.CariFisAyrinti(context, _cariKodu);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = false?true:true;
          
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}