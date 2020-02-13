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
using netsatis.tables;
using netsatis.Context;
using netsatis.DataAccess;

namespace netsatis.backoffice.FrmAnaMenu.Cari
{
    public partial class FrmCariİslem : DevExpress.XtraEditors.XtraForm
    {
        private tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private netsatisContext context = new netsatisContext();
        public FrmCariİslem(tables.Cari entity,bool kopyala=false)
        {
        
            InitializeComponent();
            if (kopyala)
            {
                _entity = new tables.Cari();
                _entity.Id = -1;
            _entity.CariKodu = "";
                _entity.Durumu = entity.Durumu;
                _entity.CariTuru = entity.CariTuru;
                _entity.CariAdi = entity.CariAdi;
                _entity.FaturaUnvani = entity.FaturaUnvani;
                _entity.YetkiliKisi = entity.YetkiliKisi;
                _entity.CepTelefonu = entity.CepTelefonu;
                _entity.Telefon = entity.Telefon;
                _entity.Fax = entity.Fax;
                _entity.Email = entity.Email;
                _entity.Aciklama = entity.Aciklama;
                _entity.Web = entity.Web;
                _entity.Il = entity.Il;
                _entity.Ilce = entity.Ilce;
                _entity.Semt = entity.Semt;
                _entity.OzelKod1 = entity.OzelKod1;
                _entity.OzelKod2 = entity.OzelKod2;
                _entity.OzelKod3 = entity.OzelKod3;
                _entity.OzelKod4 = entity.OzelKod4;
                _entity.Adres = entity.Adres;
                _entity.CariGrubu = entity.CariGrubu;
                _entity.CariAltGrubu = entity.CariAltGrubu;
                _entity.VergiDairesi = entity.VergiDairesi;
                _entity.VergiNo = entity.VergiNo;
                _entity.RiskLimiti = entity.RiskLimiti;
                _entity.AlisOzelFiyati = entity.AlisOzelFiyati;
                _entity.SatisOzelFiyati = entity.SatisOzelFiyati;
            }
            else
            {
                _entity = entity;
            }




            toggledurum.DataBindings.Add("EditValue", _entity, "Durumu");
            txtcarikodu.DataBindings.Add("Text", _entity, "CariKodu");
            txtyetkilikisi.DataBindings.Add("Text", _entity, "YetkiliKisi", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            cmbcaritur.DataBindings.Add("Text", _entity, "CariTuru");
            txtcariadi.DataBindings.Add("Text", _entity, "CariAdi");
            txtfaturaunvani.DataBindings.Add("Text", _entity, "FaturaUnvani");
            txtvergidairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            memotxtacıklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtvergino.DataBindings.Add("Text", _entity, "VergiNo");
            txtceptelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            txttelefon.DataBindings.Add("Text", _entity, "Telefon", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            txtemail.DataBindings.Add("Text", _entity, "Email");
            txtweb.DataBindings.Add("Text", _entity, "Web");
            txtil.DataBindings.Add("Text", _entity, "Il");
            txtilce.DataBindings.Add("Text", _entity, "Ilce");
            txtsemt.DataBindings.Add("Text", _entity, "Semt");
            txtadres.DataBindings.Add("Text", _entity, "Adres");
            btncarigrubu.DataBindings.Add("Text", _entity, "CariGrubu");
            btncarialtg.DataBindings.Add("Text", _entity, "CariAltGrubu");
            btnozelkod1.DataBindings.Add("Text", _entity, "OzelKod1", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            btnozelkod2.DataBindings.Add("Text", _entity, "OzelKod2", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            btnozelkod3.DataBindings.Add("Text", _entity, "OzelKod3", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            btnozelkod4.DataBindings.Add("Text", _entity, "OzelKod4", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            cmbalışozelfıyat.DataBindings.Add("Text", _entity, "AlisOzelFiyati", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            cmbsatisozelfiyat.DataBindings.Add("Text", _entity, "SatisOzelFiyati", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            
            txtiskontoorani.DataBindings.Add("Text", _entity, "IskontoOrani", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            
            txtrisklimiti.DataBindings.Add("Text", _entity, "RiskLimiti", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void groupgenel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context, _entity))
            {
                cariDal.Save(context);
                this.Close();
            }
        }

        private void txtyetkilikisi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcariadi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtvergino_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btncarigrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void FrmCariİslem_Load(object sender, EventArgs e)
        {

        }
    }
}