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

namespace netsatis.backoffice.FrmAnaMenu.OdemeTuru
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        public  Tanim _entity;
        TanimDAL tanimDal = new TanimDAL();
        private TanimTuru _tanimturu;
        public FrmTanim(TanimTuru tanimturu)
        {
            InitializeComponent();
            _tanimturu = tanimturu;
          
        }

        private void navigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTanim_Load(object sender, EventArgs e)
        {
            Listele();
      }
        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            OzelKod1,
            OzelKod2,
            OzelKod3,
            OzelKod4,
            PersonelUnvan

        }



        private void grpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigationPage2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void KayitAc()
        {
            btnsec.Enabled = false;
            btnekle.Enabled = false;
            btnduzenle.Enabled = false;
            btnsil.Enabled = false;
            btnkaydet.Enabled = true;
            btnvazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage2;
            txttanim.DataBindings.Add("Text", _entity, "Tanimi");
            txtaciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }
        void KayitKapat()
        {
            btnsec.Enabled = true;
            btnekle.Enabled = true;
            btnduzenle.Enabled = true;
            btnsil.Enabled = true;
            btnkaydet.Enabled = false;
        btnvazgec.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage1;
            txttanim.DataBindings.Clear();
            txtaciklama.DataBindings.Clear();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            _entity = new Tanim();
            KayitAc();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColıd));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            KayitAc();
        }

        void Listele()
        {
            gridControl1.DataSource = tanimDal.GetAll(context);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("secili olan veriyi silmeye emin misiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColıd));
                tanimDal.Delete(context, c => c.Id == secilen);
                tanimDal.Save(context);
                Listele();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            _entity.Turu = _tanimturu.ToString();

            if (tanimDal.AddOrUpdate(context, _entity))
            {
                tanimDal.Save(context);
                KayitKapat();
            }
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridColıd));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            this.Close();
        }
    }
}