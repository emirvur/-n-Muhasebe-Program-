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

namespace netsatis.backoffice.FrmAnaMenu.OdemeTuru
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        OdemeTuruDAL odemeturuDal = new OdemeTuruDAL();
        private string _odemeturuKodu;
        public FrmOdemeTuruHareket(string odemeturuKodu,string odemeturuAdi)
        {
            InitializeComponent();
            _odemeturuKodu = odemeturuKodu;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            gridodeme.OptionsView.ShowAutoFilterRow = false ? true : true;
        }

        void Listele()
        {
            gridContodemeHareket.DataSource = odemeturuDal.GetAll(context, c => c.OdemeTuruKodu == _odemeturuKodu);
            gridOdemeTuruToplam.DataSource =odemeturuDal.KasaToplamListele(context,_odemeturuKodu);
            gridGeneltoplam.DataSource =odemeturuDal.GenelToplamListele(context,_odemeturuKodu);
            
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}