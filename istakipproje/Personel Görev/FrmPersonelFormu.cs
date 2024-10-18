using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istakipproje.Personel_Görev
{
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }

        Personel_Görev.FrmAktifGörevler frm;
        Personel_Görev.FrmPasifGörevler frm2;
        Personel_Görev.FrmCagriListesi frm3;
        Login.FrmLogin log;
        public string mail;
        private void BtnAktifGörevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Personel_Görev.FrmAktifGörevler();
                frm.MdiParent = this;
                frm.mail2 = mail; // bpersonel formundaki k.adını aktif görevlere aktardık
                frm.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm.IsDisposed)
            {
                frm2 = new Personel_Görev.FrmPasifGörevler();
                frm2.MdiParent = this;
                frm2.mail2 = mail;
                frm2.Show();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3==null ||frm3.IsDisposed)
            {
                frm3 = new Personel_Görev.FrmCagriListesi();
                frm3.MdiParent = this;
                frm3.mail2 = mail;
                frm3.Show();
            }
        }

        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {
           // this.Text = mail.ToString();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (log == null || frm.IsDisposed)
            {
                log = new Login.FrmLogin();
                log.Show();
                this.Close();
            }
        }
    }
}
