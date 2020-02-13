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
    public partial class FrmDepoİslem : DevExpress.XtraEditors.XtraForm
    {
        private tables.Depo _entity;
        netsatisContext context = new netsatisContext();
        DepoDAL depoDal = new DepoDAL();
        public FrmDepoİslem(tables.Depo entity)
        {
            InitializeComponent();
            _entity = entity;
            txtdepokodu.DataBindings.Add("Text", _entity, "DepoKodu");
            txtdepoadi.DataBindings.Add("Text", _entity, "DepoAdi");
            txtyetkilikodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtyetkiliadı.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
           memoaciklama.DataBindings.Add("Text", _entity, "Aciklama");

        }

        private void FrmDepoİslem_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (depoDal.AddOrUpdate(context, _entity))
            {
                depoDal.Save(context);
                this.Close();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}