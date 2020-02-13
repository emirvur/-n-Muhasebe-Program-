using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using netsatis.Context;
using netsatis.DataAccess;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;

namespace NetSatis.BackUP
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        netsatisContext context = new netsatisContext();
        public FrmBackup()
        {
            InitializeComponent();
         //   KlasoreIzınVer();
        }

     /*   private void KlasoreIzınVer()
        {
            DirectorySecurity izin = Directory.GetAccessControl(Application.StartupPath);
            SecurityIdentifier Everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            izin.AddAccessRule(new FileSystemAccessRule(Everyone, FileSystemRights.FullControl, AccessControlType.Allow));
        }
        */
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sqlcumle = $"USE netsatis;BACKUP DATABASE netsatis TO DISK='{Application.StartupPath + "\\netSatisYedek.nsy"}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlcumle);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "NetSatış Yedekleme Dosyası *.nsy|*.nsy";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string sqlcumle = $"USE master;ALTER DATABASE netsatis SET SİNGLE_USER WITH ROLLBACK IMMEDIATE;ALTER DATABASE netsatis SET READ_ONLY;RESTORE DATABASE netsatis FROM DISK='{dialog.FileName}';ALTER DATABASE netsatis SET MULTI_USER;";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlcumle);

            }//netsatısın n sı buyuk olabılır test et
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
