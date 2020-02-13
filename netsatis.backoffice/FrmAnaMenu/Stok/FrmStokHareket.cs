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

namespace netsatis.backoffice.FrmAnaMenu.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        netsatisContext context = new netsatisContext();
        private string _stokKodu;
        public FrmStokHareket(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow =false?true: true;
           
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridContStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            gridControl2.DataSource = stokHareketDal.GetDepoStok(context, _stokKodu);
            gridControl3.DataSource = stokHareketDal.GetGenelStok(context, _stokKodu);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}