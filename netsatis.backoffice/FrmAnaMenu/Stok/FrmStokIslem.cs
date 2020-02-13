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
    public partial class FrmStokIslem : DevExpress.XtraEditors.XtraForm
    {
        public netsatis.tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private netsatisContext context = new netsatisContext();
        public FrmStokIslem(netsatis.tables.Stok entity,bool kopyala=false)
        {
            InitializeComponent();
          
            if (kopyala)
            {
                _entity = new tables.Stok();
                _entity.Id = -1;
                _entity.StokKodu = "";
                _entity.Durumu = entity.Durumu;
                _entity.Barkod = entity.Barkod;
                _entity.BarkodTuru = entity.BarkodTuru;
                _entity.StokAdi = entity.StokAdi;
                _entity.Birimi = entity.Birimi;
                _entity.UreticiKodu = entity.UreticiKodu;
                _entity.GarantiSuresi = entity.GarantiSuresi;
                _entity.MinStokMiktari = entity.MinStokMiktari;
                _entity.MaxStokMiktari = entity.MaxStokMiktari;
                _entity.Aciklama = entity.Aciklama;
                _entity.StokGrubu = entity.StokGrubu;
                _entity.StokAltGrubu = entity.StokAltGrubu;
                _entity.Marka = entity.Marka;
                _entity.Modeli = entity.Modeli;
                _entity.OzelKod1 = entity.OzelKod1;
                _entity.OzelKod2 = entity.OzelKod2;
                _entity.OzelKod3 = entity.OzelKod3;
                _entity.OzelKod4 = entity.OzelKod4;
                _entity.AlisKdv = entity.AlisKdv;
                _entity.SatisKdv = entity.SatisKdv;
                _entity.AlisFiyati1 = entity.AlisFiyati1;
                _entity.AlisFiyati2 = entity.AlisFiyati2;
                _entity.AlisFiyati3 = entity.AlisFiyati3;
                _entity.SatisFiyati1 = entity.SatisFiyati1;
                _entity.SatisFiyati2 = entity.SatisFiyati2;
                _entity.SatisFiyati3 = entity.SatisFiyati3;
            }
            else
            {
                _entity = entity;
            }
            toggledurum.DataBindings.Add("EditValue",_entity,"Durumu");
            txtstokkodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtbarkod.DataBindings.Add("Text", _entity, "Barkod");
            cmbbarkodtur.DataBindings.Add("Text", _entity, "BarkodTuru");
            txtstokadı.DataBindings.Add("Text", _entity, "StokAdi");
            txtgarantısuresı.DataBindings.Add("Text", _entity, "GarantiSuresi");
            txtureticikod.DataBindings.Add("Text", _entity, "UreticiKodu");
            memotxtacıklama.DataBindings.Add("Text", _entity, "Aciklama");
            btnbirim.DataBindings.Add("Text", _entity, "Birimi");
            calcmaxstokmiktar.DataBindings.Add("EditValue", _entity, "MaxStokMiktari", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcminstokmiktar.DataBindings.Add("EditValue", _entity, "MinStokMiktari", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            btnstokgrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnstokaltg.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnmarka.DataBindings.Add("Text", _entity, "Marka");
            btnmodel.DataBindings.Add("Text", _entity, "Modeli");
            btnozelkod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnozelkod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnozelkod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnozelkod4.DataBindings.Add("Text", _entity, "OzelKod4");
            calcalıskdv.DataBindings.Add("EditValue", _entity, "AlisKdv", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcsatıskdv.DataBindings.Add("EditValue", _entity, "SatisKdv", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcalışfıyat1.DataBindings.Add("EditValue", _entity, "AlisFiyati1", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcalısfiyat2.DataBindings.Add("EditValue", _entity, "AlisFiyati2", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcalışfıyat3.DataBindings.Add("EditValue", _entity, "AlisFiyati3", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcsatısfiyat1.DataBindings.Add("EditValue", _entity, "SatisFiyati1", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcsatısfiyat2.DataBindings.Add("EditValue", _entity, "SatisFiyati2", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcsatısfiyat3.DataBindings.Add("EditValue", _entity, "SatisFiyati3",true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmarka_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (stokDal.AddOrUpdate(context, _entity))
            {
                stokDal.Save(context);
                this.Close();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokIslem_Load(object sender, EventArgs e)
        {

        }
    }
}