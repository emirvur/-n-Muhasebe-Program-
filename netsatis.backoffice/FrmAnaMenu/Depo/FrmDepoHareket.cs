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
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private string _depoKodu;
        public FrmDepoHareket(string depoKodu,string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu;
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            gridContdepoHareket.DataSource = stokHareketDal.GetAll(context, c => c.DepoKodu == _depoKodu);
            gridcontdepomiktar.DataSource = stokHareketDal.DepoStokListele(context,_depoKodu);
            gridcontdepoistatisitk.DataSource = stokHareketDal.DepoİstatistikListele(context, _depoKodu);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            gridhareket.OptionsView.ShowAutoFilterRow = false ? true : true;
           
        }
    }
}