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
using netsatis.tables;

namespace netsatis.backoffice.FrmAnaMenu.Personel
{
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        PersonelDAL personelDal = new PersonelDAL();
        private string _secilen = null;
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridControl1.DataSource = personelDal.PersonelListele(context);
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();        }

        private void btnka_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("secili kaydı silinecek","uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                _secilen=gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
                personelDal.Delete(context, c => c.PersonelKodu == _secilen);
                personelDal.Save(context);
                Listele();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmPersonelIslem form = new FrmPersonelIslem(new tables.Personel());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            string _secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelIslem form = new FrmPersonelIslem(personelDal.GetByFilter(context, c => c.PersonelKodu == _secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnpersonelhareket_Click(object sender, EventArgs e)
        {
            string _secilen = gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelHareket form = new FrmPersonelHareket(_secilen,gridView1.GetFocusedRowCellValue(colPersonelKodu).ToString());//colpersoneladını koda cevirdim
            form.ShowDialog();
        }

        private void btnkopyala_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            netsatis.tables.Personel personelentity = new netsatis.tables.Personel();
            personelentity = personelDal.GetByFilter(context, c => c.Id == secilen);
            personelentity.Id = -1;
            personelentity.PersonelKodu = null;
            FrmPersonelIslem form = new FrmPersonelIslem(personelentity, true);
            form.ShowDialog();
        }
    }
}