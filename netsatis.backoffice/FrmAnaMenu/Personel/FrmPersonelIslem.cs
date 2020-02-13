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

namespace netsatis.backoffice.FrmAnaMenu.Personel
{
    public partial class FrmPersonelIslem : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        PersonelDAL personelDal = new PersonelDAL();
        public bool saved=false;
        private tables.Personel _entity;
        public FrmPersonelIslem( tables.Personel entity,bool kopyala=false)
        {
            InitializeComponent();

            if (kopyala)
            {
                _entity = new tables.Personel();
                _entity.Id = -1;
                _entity.PersonelKodu = "";
                _entity.Unvani = entity.Unvani;
                _entity.Calisiyor = entity.Calisiyor;
                _entity.PersonelAdi = entity.PersonelAdi;
                _entity.TcKimlikNo = entity.TcKimlikNo;
                _entity.IstenCikisTarihi = entity.IstenCikisTarihi;
                _entity.IseGirisTarihi = entity.IseGirisTarihi;
                _entity.Telefon = entity.Telefon;
                _entity.CepTelefonu = entity.Fax;
                _entity.EMail = entity.EMail;
                _entity.Aciklama = entity.Aciklama;
                _entity.Web = entity.Web;
                _entity.Il = entity.Il;
                _entity.Ilce = entity.Ilce;
                _entity.Semt = entity.Semt;
          
      
                _entity.Adres = entity.Adres;
                _entity.Web = entity.Web;

                _entity.VergiDairesi = entity.VergiDairesi;
                _entity.VergiNo = entity.VergiNo;
              
                _entity.PrimOrani = entity.PrimOrani;
                _entity.AylikMaasi = entity.AylikMaasi;
            }
            else
            {
                _entity = entity;
            }

            togglecalisiyor.DataBindings.Add("EditValue", _entity, "Calisiyor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtpersonelkodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtpersoneladi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtunvan.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txttcno.DataBindings.Add("Text", _entity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            dateEditisgir.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null,"F");
            dateEditiscik.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null,"F");
            txtvergidairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            memotxtacıklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtvergino.DataBindings.Add("Text", _entity, "VergiNo");
            txtceptelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            txtsabittelefon.DataBindings.Add("Text", _entity, "Telefon", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            txtemail.DataBindings.Add("Text", _entity, "Email");
            txtweb.DataBindings.Add("Text", _entity, "Web");
            txtil.DataBindings.Add("Text", _entity, "Il");
            txtilce.DataBindings.Add("Text", _entity, "Ilce");
            txtsemt.DataBindings.Add("Text", _entity, "Semt");
            txtaylikmaas.DataBindings.Add("EditValue", _entity, "AylikMaasi", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            txtprimorani.DataBindings.Add("EditValue", _entity, "PrimOrani", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");

        }

        private void FrmPersonelIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (personelDal.AddOrUpdate(context, _entity))
            {
                saved = true;
                personelDal.Save(context);
                this.Close();
            }
        }
    }
}