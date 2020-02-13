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
using netsatis.tables;
using netsatis.DataAccess;


namespace netsatis.backoffice.FrmAnaMenu.OdemeTuru
{
    public partial class FrmOdemeTuruİslem : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        OdemeTuruDAL odemeturuDal = new OdemeTuruDAL();
        private tables.OdemeTuru _entity;
        public FrmOdemeTuruİslem(tables.OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtodemeturukodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtodemeturuadi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            memoaciklama.DataBindings.Add("Text", _entity, "Aciklama");
       
        }

        private void FrmOdemeTuruİslem_Load(object sender, EventArgs e)
        {

        }

        private void txtdepokodu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (odemeturuDal.AddOrUpdate(context, _entity))
            {
                odemeturuDal.Save(context);
                this.Close();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}