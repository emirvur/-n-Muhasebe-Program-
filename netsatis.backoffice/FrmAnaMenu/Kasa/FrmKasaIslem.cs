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
using netsatis.Context;
using netsatis.DataAccess;

namespace netsatis.backoffice.FrmAnaMenu.Kasa
{
   
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        netsatisContext context = new netsatisContext();
        public bool Kaydedildi = false;
        private tables.Kasa _entity;
        public FrmKasaIslem(tables.Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtkasakodu.DataBindings.Add("Text", _entity, "KasaKodu");
            txtkasaadi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtyetkilikodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtyetkiliadı.DataBindings.Add("Text", _entity, "YetkiliAdi");
            memoaciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupgruplar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (kasaDal.AddOrUpdate(context, _entity))
            {
                kasaDal.Save(context);
                Kaydedildi = true;
                this.Close();
            }
        }
    }
}