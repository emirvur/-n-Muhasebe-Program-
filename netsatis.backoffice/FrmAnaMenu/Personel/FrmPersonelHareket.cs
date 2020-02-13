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
    public partial class FrmPersonelHareket : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        PersonelDAL personelDal = new PersonelDAL();
        FisDAL fisDal = new FisDAL();
        private string _personelKodu;
        public FrmPersonelHareket(string personelKodu,string personelAdi)
        {
            InitializeComponent();
            _personelKodu = personelKodu;
            lblBaslik.Text = personelKodu + " -" + personelAdi;
             
        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            gridContpersHareket.DataSource = fisDal.GetAll(context, c => c.PlasiyerKodu == _personelKodu);
            gridControl2.DataSource = personelDal.PersonelFisToplam(context, _personelKodu);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = true ? gridView1.OptionsView.ShowAutoFilterRow == false : gridView1.OptionsView.ShowAutoFilterRow == true;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}