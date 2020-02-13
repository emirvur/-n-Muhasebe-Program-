using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using netsatis.backoffice.FrmAnaMenu;
using netsatis.backoffice.FrmAnaMenu.Cari;
using netsatis.backoffice.FrmAnaMenu.Depo;
using netsatis.backoffice.FrmAnaMenu.Fis;
using netsatis.backoffice.FrmAnaMenu.Hızlı_Satış;
using netsatis.backoffice.FrmAnaMenu.Kasa;
using netsatis.backoffice.FrmAnaMenu.Kasa_Hareket;
using netsatis.backoffice.FrmAnaMenu.OdemeTuru;
using netsatis.backoffice.FrmAnaMenu.Personel;
using netsatis.backoffice.FrmAnaMenu.Stok_Hareketleri;
using netsatis.backoffice.Raporlar;
using netsatis.Context;
using netsatis.DataAccess;
using netsatis.tables;
using Netsatis.Reports.Stok;
using NetSatis.BackUP;

namespace netsatis.backoffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
    //        KlasoreIzınVer();
        }

      /*  private void KlasoreIzınVer()
        {
            DirectorySecurity izin = Directory.GetAccessControl(Application.StartupPath);
            SecurityIdentifier Everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            izin.AddAccessRule(new FileSystemAccessRule(Everyone,FileSystemRights.FullControl,AccessControlType.Allow));
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            frmAnaMenuBilgi form = new frmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmCari form = new FrmCari();
            form.MdiParent = this;
            form.Show();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFis form =new FrmFis();
            form.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri form = new FrmStokHareketleri();
            form.MdiParent = null;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaHareketleri form = new FrmKasaHareketleri();
            form.ShowDialog();
   
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBackup  form = new FrmBackup();
            form.ShowDialog();
        }

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisİslem form = new FrmFisİslem(null,e.Item.Caption);
            form.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptStokHareketleri report = new RptStokHareketleri();
            FrmRaporGoruntule form = new FrmRaporGoruntule(report);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptStokdurumu report = new rptStokdurumu();
            FrmRaporGoruntule form = new FrmRaporGoruntule(report);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHizliSatis form = new FrmHizliSatis();
            form.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel form = new FrmPersonel();
            form.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo form = new FrmDepo();
            form.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa form = new FrmKasa();
            form.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru();
            form.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
