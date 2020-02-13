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
using netsatis.DataAccess;
using netsatis.Context;

namespace netsatis.backoffice.FrmAnaMenu.Personel
{
    public partial class FrmPersonelSec : DevExpress.XtraEditors.XtraForm
    {
        PersonelDAL personelDal = new PersonelDAL();
        public bool secildi = false;
        private DateTime _donem;
        netsatisContext context = new netsatisContext();
        public List<tables.PersonelHareket> secilen = new List<tables.PersonelHareket>();
        public FrmPersonelSec(DateTime donemi, bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim == true)
            {
                lbluyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
            _donem = donemi;
            gridControl1.DataSource = personelDal.TariheGorePersonelListele(context,donemi.Month,donemi.Year);

        }

        private void FrmPersonelSec_Load(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsec_Click(object sender, EventArgs e)
        {

            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string personelkodu = gridView1.GetRowCellValue(row,colPersonelKodu ).ToString();// colperskod ekle altta da
                    secilen.Add(new tables.PersonelHareket
                    {
                        PersonelKodu = gridView1.GetRowCellValue(row, colPersonelKodu).ToString(),
                        PersonelAdi = gridView1.GetRowCellValue(row, colPersonelAdi).ToString(),
                        TcKimlikNo = gridView1.GetRowCellValue(row, colTcKimlikNo).ToString(),
                        Unvani = gridView1.GetRowCellValue(row, colUnvani).ToString(),
                        Donemi = _donem,
                        AylikMaasi = Convert.ToDecimal(gridView1.GetRowCellValue(row,colAylikMaasi)),
                        PrimOrani = Convert.ToDecimal(gridView1.GetRowCellValue(row, colPrimOrani)),
                        ToplamSatis = Convert.ToDecimal(gridView1.GetRowCellValue(row, colToplamSatis)),


                    }); ;

                }
                secildi = true;
                this.Close();
              
            }
            else
            {
                MessageBox.Show("secilen cari bulunamadı");
            }
        }
    }
}