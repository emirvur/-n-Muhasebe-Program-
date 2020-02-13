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
//ana griddeki verileri data sourcetan otomatik çekmedim elle o sütunu doldurdum sıkıntı çıkarsa kaynağı belki odur

namespace netsatis.backoffice.FrmAnaMenu.Kasa
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        netsatisContext context = new netsatisContext();

        public FrmKasa()
        {
            InitializeComponent();
        }
        public void Guncelle()
        {
            gridContKasalr.DataSource = kasaDal.KasaListele(context);
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void btnfiltkapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Guncelle();
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Guncelle();
        }

        private void gridContKasalr_Click(object sender, EventArgs e)
        {

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnfiltiptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem form = new FrmKasaIslem(new tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            //getbyfilter da hiç eleman olmadığında sıkıntı çıkabiliyor
            string secilen = (gridView1.GetFocusedRowCellValue(colKasaKodu).ToString());
            FrmKasaIslem form = new FrmKasaIslem(kasaDal.GetByFilter(context, c => c.KasaKodu == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("secili olan veriyi silmeye emin misiniz", "uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                kasaDal.Delete(context, c => c.KasaKodu == secilen);
                kasaDal.Save(context);
                Guncelle();
            }
        }

        private void btnkasahareket_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            string secilenad = gridView1.GetFocusedRowCellValue(colKasaAdi).ToString();
            FrmKasaHareket form = new FrmKasaHareket(secilen, secilenad);
            form.ShowDialog();
        }
    }
}