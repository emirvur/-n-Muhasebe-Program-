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
using System.Data.Entity;
using netsatis.backoffice.FrmAnaMenu.Stok;
using netsatis.backoffice.FrmAnaMenu.Cari;
using netsatis.backoffice.FrmAnaMenu.Depo;
using netsatis.backoffice.FrmAnaMenu.Kasa;
using netsatis.tables.OtherTables;
using netsatis.backoffice.FrmAnaMenu.Personel;

namespace netsatis.backoffice.FrmAnaMenu.Fis
{
    public partial class FrmFisİslem : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        FisDAL fisDal = new FisDAL();
        FisAyarlari ayarlar = new FisAyarlari();
        StokHareketDAL stokhareketDal = new StokHareketDAL();
        KasaHareketDAL kasahareketDal = new KasaHareketDAL();
        PersonelHareketDAL personelhareketDal = new PersonelHareketDAL();
        tables.Fis _fisentity = new tables.Fis();
        CariDAL cariDal = new CariDAL();
        private CariBakiye entityBakiye = new CariBakiye();

        public FrmFisİslem(string fisKodu=null,string fisTuru=null)
        {
            InitializeComponent();
            if (fisKodu != null)
            {
                _fisentity = context.Fisler.SingleOrDefault(c => c.FisKodu == fisKodu); //sonradan değiştirdim 2.bölüm ders3 volkanınsorusu
                if (_fisentity == null)
                {
                    return;
                }
                context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();

                toggleSwitch1.IsOn = context.KasaHareketleri.Count(c => c.FisKodu == fisKodu && c.Hareket == "Kasa Giris") == 0;
                if (_fisentity.CariKodu!=null)
                {
                    entityBakiye = this.cariDal.CariBakiyesi(context, _fisentity.CariKodu);
                    txtalacak.Text = entityBakiye.Alacak.ToString("C2");
                    txtborc.Text = entityBakiye.Borc.ToString("C2");
                    txtbakiye.Text = entityBakiye.Bakiye.ToString("C2");
                }
             
               
            
            }
            else
            {
                _fisentity.FisTuru = fisTuru;
                _fisentity.Tarih = DateTime.Now;
            }
          
            txtfiskodu.DataBindings.Add("Text", _fisentity, "FisKodu",false,DataSourceUpdateMode.OnPropertyChanged);
            txtfisturu.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbtarih.DataBindings.Add("EditValue", _fisentity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged);
            txtbelgeno.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtaciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcarikod.DataBindings.Add("Text", _fisentity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcariad.DataBindings.Add("Text", _fisentity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);

            txtfatur.DataBindings.Add("Text", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcep.DataBindings.Add("Text", _fisentity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtil.DataBindings.Add("Text", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtilce.DataBindings.Add("Text", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtsemt.DataBindings.Add("Text", _fisentity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtadres.DataBindings.Add("Text", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtvergida.DataBindings.Add("Text", _fisentity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtvergino.DataBindings.Add("Text", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);


            gridcontStokhareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridcontKasahareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridcontpershar.DataSource = context.PersonelHareketleri.Local.ToBindingList();
            FisAyar();
            Toplamlar();
            OdenenTutarGuncelle();
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {


                    Name = item.OdemeTuruKodu,
                    Text = item.OdemeTuruAdi,
                    Height = 42,
                    Width = 125
                };
                buton.Click += odemeEkle_Click;
                flowLayoutPanel2.Controls.Add(buton);

            }

            var PersonelSecimİptali = new CheckButton
            {


                Name = "Yok",
                Text = "Yok",
                GroupIndex = 1,
                Height = 42,
                Width = 125,
                Checked = _fisentity.PlasiyerKodu==null
            };
            PersonelSecimİptali.Click += PersonelYukle_Click;
            flowpersonel.Controls.Add(PersonelSecimİptali);

            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {


                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    GroupIndex = 1,
                    Height = 42,
                    Width = 125,
                    Checked = item.PersonelKodu == _fisentity.PlasiyerKodu
                };
                buton.Click += PersonelYukle_Click;
                flowpersonel.Controls.Add(buton);

            }

        }
        private void PersonelYukle_Click(object sender,EventArgs e)
        {
            var buton = sender as CheckButton;

            if (buton.Name == "Yok")
            {
                _fisentity.PlasiyerKodu = null;
                _fisentity.PlasiyerAdi = null;
            }
            else {
                _fisentity.PlasiyerKodu = buton.Name;
                _fisentity.PlasiyerAdi = buton.Text;
            }
         

        }

        private void FisAyar()
        {
         
            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                ayarlar.StokHareketi = "Stok Giriş";
            ayarlar.KasaHareketi = "Kasa Çıkış";
                 

                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                 
                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                 

                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                

                    break;
                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                  

                    break;
                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                   
                    break;
                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış";
                

                    break;
                case "Stok Devir Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                 

                    break;

                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                 

                    break;

                case "Odeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
               

                    navpersonelislem.SelectedPage = navodemeekr;

                    break;

                case "Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                
                    navpersonelislem.SelectedPage = navodemeekr;

                    break;

            }


        }
        private void odemeEkle_Click(object sender,EventArgs e)
        {
            var buton = (sender as SimpleButton);
            if (ayarlar.SatisEkrani == false)
            {
                FrmOdemeEkrani form = new FrmOdemeEkrani(buton.Text,buton.Name);
                form.ShowDialog();
                if (form.entity!=null)
                {
                    kasahareketDal.AddOrUpdate(context, form.entity);
                    OdenenTutarGuncelle();
                }
             
            }
            else {
                if (calcEditodenmesigerek.Value <= 0)
                {
                    MessageBox.Show("ödenmesi gereken zaten ödenmiş");
                }
                else
                {

                    KasaHareket entitykasahareket = new KasaHareket
                    {
                        OdemeTuruKodu = buton.Name,
                        OdemeTuruAdi = buton.Text,
                        Tutar = calcEditodenmesigerek.Value
                    };

                    kasahareketDal.AddOrUpdate(context, entitykasahareket);
                    OdenenTutarGuncelle();
                }

            }


        }

        private void OdenenTutarGuncelle()
        {
            gridkasaha.UpdateSummary();

            if (ayarlar.SatisEkrani)
            {
                calcEditodenentutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                calcEditodenmesigerek.Value = calcEditgeneltoplam.Value - calcEditodenentutar.Value;
            }
            else
            {
                calcEditgeneltoplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }
        }


        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        private StokHareket StokSec(tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            stokHareket.StokKodu = entity.StokKodu;
            stokHareket.StokAdi = entity.StokAdi;
            stokHareket.Barkod = entity.Barkod;
            stokHareket.BarkodTuru = entity.BarkodTuru;
            stokHareket.BirimFiyati = txtfisturu.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Birimi = entity.Birimi;
            stokHareket.Miktar = txtmiktar.Value;
            stokHareket.Kdv = entity.SatisKdv;
            stokHareket.Tarih = DateTime.Now;
            return stokHareket;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbtarih_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblvergino_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit9_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void btncarisec_Click(object sender, EventArgs e)
        {

        }

        private void lblceptelefon_Click(object sender, EventArgs e)
        {

        }

        private void btnsecc_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokhareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                Toplamlar();
            }
        }

        private void txtbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tables.Stok entity;
                entity = context.Stoklar.Where(c => c.Barkod == txtbarkod.Text).SingleOrDefault();
               if (entity != null)
                {
                    stokhareketDal.AddOrUpdate(context, StokSec(entity));
                    Toplamlar();
                }
                else
                {
                    MessageBox.Show("aradıgınız barkod no urunler arasında yok");
                }
                txtbarkod.Text = null;
            }
        }

        private void btncarisec_Click_1(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = this.cariDal.CariBakiyesi(context, entity.CariKodu);

                txtcarikod.Text = entity.CariKodu;
                txtcariad.Text = entity.CariAdi;
                txtfatur.Text = entity.FaturaUnvani;
                txtvergida.Text = entity.VergiDairesi;
                txtvergino.Text = entity.VergiNo;
                txtcep.Text = entity.CepTelefonu;
                txtil.Text = entity.Il;
                txtilce.Text = entity.Ilce;
                txtsemt.Text = entity.Semt;
                txtadres.Text = entity.Adres;
                txtalacak.Text = entityBakiye.Alacak.ToString();
                txtborc.Text = entityBakiye.Borc.ToString();
                txtbakiye.Text = entityBakiye.Bakiye.ToString();

            }
        }

        private void btncaritemizle_Click(object sender, EventArgs e)
        {
            txtcarikod.Text = null;
            txtcariad.Text = null;
            txtfatur.Text = null;
            txtvergida.Text = null;
            txtvergino.Text = null;
            txtcep.Text = null;
            txtil.Text = null;
            txtilce.Text = null;
            txtsemt.Text = null;
            txtadres.Text = null;
            txtalacak.Text = "görüntülenemiyor";
            txtborc.Text = "görüntülenemiyor";
            txtbakiye.Text = "görüntülenemiyor";
        }

        private void txtalacak_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void repodepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmDepoSec form = new FrmDepoSec(gridstokha.GetFocusedRowCellValue(colStokKodu).ToString());
            form.ShowDialog();
            if (form.secildi)
            {
                gridstokha.SetFocusedRowCellValue(colDepoKodu, form.entity.DepoKodu);
                gridstokha.SetFocusedRowCellValue(colDepoAdi, form.entity.DepoAdi);
            }
        }

        private void repobirimfiyat_BeforeShowMenu(object sender, DevExpress.XtraEditors.Controls.BeforeShowMenuEventArgs e)
        {

        }

        private void repobirimfiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            string fiyatsecilen = gridstokha.GetFocusedRowCellValue(colStokKodu).ToString();
            tables.Stok fiyatentity = context.Stoklar.Where(c => c.StokKodu == fiyatsecilen).SingleOrDefault();

            barfiyat1.Tag =txtfisturu.Text=="Alış Faturası"? fiyatentity.AlisFiyati1?? 0:fiyatentity.SatisFiyati1 ?? 0;
            barfiyat2.Tag = txtfisturu.Text == "Alış Faturası" ? fiyatentity.AlisFiyati2 ?? 0 : fiyatentity.SatisFiyati2 ?? 0;
            barfiyat3.Tag = txtfisturu.Text == "Alış Faturası" ? fiyatentity.AlisFiyati3 ?? 0 : fiyatentity.SatisFiyati3 ?? 0;
            barfiyat1.Caption = string.Format("{0:C2}", barfiyat1.Tag);
            barfiyat2.Caption = string.Format("{0:C2}", barfiyat2.Tag);
            barfiyat3.Caption = string.Format("{0:C2}", barfiyat3.Tag);


            radialfiyat.ShowPopup(MousePosition);
        }

        private void fiyatsec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridstokha.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }

        private void reposerino_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridstokha.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNo form = new FrmSeriNo(veri);
            form.ShowDialog();
            gridstokha.SetFocusedRowCellValue(colSeriNo, form);
        }

        private void reposil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(MessageBox.Show("emin misiniz seçili veriyi silmeye","uyarı",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridstokha.DeleteSelectedRows();
                Toplamlar();
            }
        }

        private void repokasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridkasaha.SetFocusedRowCellValue(colKasaKodu, form.entity.KasaKodu);
                gridkasaha.SetFocusedRowCellValue(colKasaAdi, form.entity.KasaAdi);
            }
        }

        private void reposill_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("emin misiniz seçili veriyi silmeye", "uyarı",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridkasaha.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }

        private void FrmFisİslem_Load(object sender, EventArgs e)
        {

        }

        private void gridstokha_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == coltoplamtutar)
            {
                Toplamlar();
            }
         

        }
        private void Toplamlar()
        {
            gridstokha.UpdateSummary();
            calcEditiskontotutar.Value= Convert.ToDecimal(coltoplamtutar.SummaryItem.SummaryValue)/100*calcEditiskontotutar.Value;
            calcEditgeneltoplam.Value = Convert.ToDecimal(coltoplamtutar.SummaryItem.SummaryValue)-calcEditiskontotutar.Value;
            calcEditkdvtoplam.Value = Convert.ToDecimal(colkdvtoplam.SummaryItem.SummaryValue);
            calcEditindirimtoplam.Value = Convert.ToDecimal(colindirimtutar.SummaryItem.SummaryValue);
            calcEditodenmesigerek.Value = calcEditgeneltoplam.Value - calcEditodenentutar.Value;
        }

        private void calcEditgeneltoplam_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void calcEditiskontooran_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void calcEditiskontooran_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void btnislemikaydet_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                ayarlar.KasaHareketi = "Kasa Çıkış";
            }
            else {
                ayarlar.KasaHareketi = "Kasa Giriş";
            }

            int StokHata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int KasaHata = context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();
            string message = null;
            int hata = 0;
            if (gridstokha.RowCount == 0&& ayarlar.SatisEkrani==true)
            {
                message += "satış ekranında eklenmiş ürün bulunmaıd" + System.Environment.NewLine;
                hata++;
            }

            if (_fisentity.CariKodu==null&&ayarlar.SatisEkrani==false)
            {
                message += txtfisturu.Text+"türünde cari seçimi zorunludur" + System.Environment.NewLine;
                hata++;
            }
            if (txtfiskodu.Text == "")
            {
                message += "fis kodu alanı boş gecilemez" + System.Environment.NewLine;
                hata++;           
            }
            if (calcEditodenmesigerek.Value !=0&&ayarlar.OdemeEkrani==true)
            {
                message += "ödenmesi gereken tutar ödenmemiş gözüküyor" + System.Environment.NewLine;
                hata++;
            }
            if (StokHata!=0)
            {
                message += "satış ekranındaki ürünlerin depo seçimlerinde eksiklikler var" + System.Environment.NewLine;
                hata++;
            }
            if (KasaHata!=0)
            {
                message += "odeme ekranındaki ürünlerin kasa seçimlerinde eksiklikler var"; 
                hata++;
            }

            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }
            
                foreach (var stokVeri in context.StokHareketleri.Local.ToList())
                {
                    stokVeri.Tarih = stokVeri.Tarih == null ? Convert.ToDateTime(cmbtarih.DateTime) : Convert.ToDateTime(stokVeri.Tarih);
                    stokVeri.FisKodu = txtfiskodu.Text;
                    stokVeri.Hareket = ayarlar.StokHareketi;
                }

                if (ayarlar.OdemeEkrani)
                {
                    foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                    {
                        kasaVeri.Tarih = kasaVeri.Tarih == null ? Convert.ToDateTime(cmbtarih.DateTime) : Convert.ToDateTime(kasaVeri.Tarih);
                        kasaVeri.FisKodu = txtfiskodu.Text;
                        kasaVeri.Hareket = ayarlar.KasaHareketi;
                        kasaVeri.CariKodu = lblcarikodu.Text;
                        kasaVeri.CariAdi = lblcariadi.Text;
                    }
                }
            _fisentity.CariKodu = txtcarikod.Text;
            //sonradan ekledim
            _fisentity.CariAdi = txtcariad.Text;

            _fisentity.ToplamTutar = calcEditgeneltoplam.Value;
                _fisentity.İskontoOrani = calcEditiskontooran.Value;
                _fisentity.İskontoTutar = calcEditiskontotutar.Value;
                fisDal.AddOrUpdate(context,_fisentity);
                context.SaveChanges();
            this.Close();
            }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (gridstokha.RowCount != 0)
            {
                if(MessageBox.Show("satış ekranına eklenmış urunler var bu işlemi iptal edip formu kapatmak istiyor musunuz?","uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
                { this.Close(); }
                        }
            else
            {
                this.Close();
            }
        }

        private void navpersonelislem_Click(object sender, EventArgs e)
        {

        }

        private void btnpersbul_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(Convert.ToInt32(cmbyil.Text),cmbay.Month,1);
            FrmPersonelSec form = new FrmPersonelSec(time);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach(var itemhareket in form.secilen.ToList())
                {
                    personelhareketDal.AddOrUpdate(context, itemhareket);
                }
            }
            
        }
    }
    }
