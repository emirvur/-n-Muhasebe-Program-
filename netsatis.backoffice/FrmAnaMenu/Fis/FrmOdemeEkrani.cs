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
using netsatis.backoffice.FrmAnaMenu.Kasa;
using netsatis.tables;

namespace netsatis.backoffice.FrmAnaMenu.Fis
{
    public partial class FrmOdemeEkrani : DevExpress.XtraEditors.XtraForm
    {
        public KasaHareket entity = new KasaHareket();
        private string _odemeTuruKodu = null;
        public FrmOdemeEkrani(string odemeTuru,string odemeTuruKodu)
        {
            InitializeComponent();
            txtodemeturu.Text = odemeTuru;
            _odemeTuruKodu = odemeTuruKodu;
        }

        private void FrmOdemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnkasasec_Click(object sender, EventArgs e)
        {
            FrmKasaSec form =new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                txtkasakodu.Text = form.entity.KasaKodu;
                txtkasaad.Text = form.entity.KasaAdi;
            }
           

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string message = null;
            int error = 0;
            if (txtkasaad.Text == "")
            {
                message += "kasa bilgileri boş bırakılamz" + System.Environment.NewLine;
                error++;
            }
            if (calcEdittutar.Value <= 0)
            {
                message += "tutar 0 değerine eşit veya küçük olamaz" + System.Environment.NewLine;
                error++;
            }
            if (error != 0)
            {
                MessageBox.Show(message);
                return;
            }
            entity = new KasaHareket();
            entity.OdemeTuruKodu = _odemeTuruKodu;
            entity.OdemeTuruAdi = txtodemeturu.Text;
            entity.KasaKodu = txtkasakodu.Text;
            entity.KasaAdi = txtkasaad.Text;
            entity.Tutar = calcEdittutar.Value;
            entity.Aciklama = memotxtacıklama.Text;
            this.Close();
        }
    }
}