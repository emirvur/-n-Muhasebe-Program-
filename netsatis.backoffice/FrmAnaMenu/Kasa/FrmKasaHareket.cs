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

namespace netsatis.backoffice.FrmAnaMenu.Kasa
{
    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        netsatisContext context = new netsatisContext();
        private string _kasaKodu;
        public FrmKasaHareket(string kasaKodu,string kasaAdi)
        {
            InitializeComponent();
            _kasaKodu = kasaKodu;
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {

        }
        public void Guncelle()
        {
            gridContkasaHareket.DataSource = kasaDal.GetAll(context, c => c.KasaKodu == _kasaKodu);
            gridOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaKodu);
            gridGeneltoplam.DataSource = kasaDal.GenelToplamListele(context, _kasaKodu);
        }


        private void gridOdemeTuruToplam_Click(object sender, EventArgs e)
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
            gridkasalar.OptionsView.ShowAutoFilterRow =false?true: true;
            
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}