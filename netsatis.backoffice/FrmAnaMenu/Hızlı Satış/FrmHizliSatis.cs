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
using System.Data.Entity;
using netsatis.backoffice.FrmAnaMenu.Stok;

namespace netsatis.backoffice.FrmAnaMenu.Hızlı_Satış
{
    public partial class FrmHizliSatis : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        HizliSatisGrupDAL hizlisatisgrupDal = new HizliSatisGrupDAL();
        HizliSatisDAL hizlisatisDal = new HizliSatisDAL();
        public FrmHizliSatis()
        {
            InitializeComponent();
            context.HizliSatisGruplari.Load();
            context.HizliSatislar.Load();
            gridControl1.DataSource = context.HizliSatisGruplari.Local.ToBindingList();
            gridControl2.DataSource = context.HizliSatislar.Local.ToBindingList();
        }

        private void FrmHizliSatis_Load(object sender, EventArgs e)
        {

        }

        private void KayitAc()
        {
            groupgenel.Enabled = true;
            btnyeni.Enabled = false;
            btnsil.Enabled = false;
            btnkaydet.Enabled = true;
            btnvazgec.Enabled = true;
            gridControl2.Enabled = false;
            btnekle.Enabled = false;
            btnsil.Enabled = false;
        }

        private void KayitKapat()
        {
            groupgenel.Enabled = false;
            btnyeni.Enabled = true;
            btnsil.Enabled = true;
            btnkaydet.Enabled = false;
            btnvazgec.Enabled = false;
            gridControl2.Enabled = true;
            btnekle.Enabled = true;
            btnsil.Enabled = true;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView2.ActiveFilterString = $"GrupId='{gridView1.GetFocusedRowCellValue(colId)}'";
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            KayitKapat();
            hizlisatisgrupDal.AddOrUpdate(context, new tables.HizliSatisGrup
            {
                GrupAdi = txtgrupadı.Text,
                Aciklama=memotxtacıklama.Text,

            }); 
            hizlisatisgrupDal.Save(context);
            txtgrupadı.Text = null;
            memotxtacıklama.Text = null;
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
            txtgrupadı.Text = null;
            memotxtacıklama.Text = null;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("secili olan grup silinecek", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int grupId = (int)gridView1.GetFocusedRowCellValue(colId);
                hizlisatisDal.Delete(context, c => c.GrupId == grupId);
                gridView1.DeleteSelectedRows();
                hizlisatisDal.Save(context);
            }


           
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach(var itemstok in form.secilen)
                {
                    if (context.HizliSatislar.Count(c => c.Barkod == itemstok.Barkod) == 0)
                    {
                        hizlisatisDal.AddOrUpdate(context, new tables.HizliSatis
                        {
                            Barkod=itemstok.Barkod,
                            UrunAdi=itemstok.StokAdi,
                            GrupId=(int) gridView1.GetFocusedRowCellValue(colId)
                        });
                        hizlisatisDal.Save(context);
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("secili ürün silinecek","uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            gridView2.DeleteSelectedRows();
            hizlisatisDal.Save(context);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}