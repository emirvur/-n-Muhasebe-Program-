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

namespace netsatis.backoffice.FrmAnaMenu.Fis
{
    public partial class FrmSeriNo : DevExpress.XtraEditors.XtraForm
    {
        public string veriserino;
        public bool kilitli = true;
        public FrmSeriNo(string veri)
        {
            InitializeComponent();
            if (veri != null)
            {
                string[] verilistesi =
         veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in verilistesi)
                {
                    listserino.Items.Add(item);
                }
            }
            if (kilitli)
            {
                grpMenu.Enabled = false;
            }

        }

        private void FrmSeriNo_Load(object sender, EventArgs e)
        {

        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtserino.Focus();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            listserino.Items.Remove(listserino.SelectedItem);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            listserino.Items.Add(txtserino.Text);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeriNo_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in listserino.Items)
            {
                if (listserino.Items.Count != 0)
                {
                    veriserino += item + System.Environment.NewLine;
                }
            }
        }
    }
}