using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istakipproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Formlar.FrmGörev fr;
        Formlar.FrmDepartmanlar frm;
        Formlar.FrmGörevDetay fr2;
        Formlar.Frmpersoneller frm2;
        Formlar.FrmGörevListesi frm4;
        Formlar.FrmPersonelistatistik frm3;
        Formlar.FrmAnaForm anaform;
        Formlar.FrmAktifCagrilar fr5;
        Login.FrmLogin log;
        Formlar.FrmPasifCagrilarr pas;
        Firmalar.FrmFirmaListesi firm;
        Formlar.FrmAktifGörevler aktif;
        Formlar.FrmPasifGörevler pasgör;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;  // mdi üzerinde açılması için yazdık
                frm.Show();
            }

        }

        private void btnPersonellistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.Frmpersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void BtnPersonelistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmPersonelistatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }

        }


        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGörevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmGörev();
                fr.Show();
            }

        }

        private void BtnGörevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.FrmGörevDetay();
                fr2.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaform == null || anaform.IsDisposed)
            {
                anaform = new Formlar.FrmAnaForm();
                anaform.MdiParent = this;
                anaform.Show();
            }

        }

        private void BtnAktifÇağrılar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.FrmAktifCagrilar();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (log == null || frm.IsDisposed)
            {
                log = new Login.FrmLogin();
                log.Show();
                this.Close();

            }



            // nasıl yapılır serisi 21. videoya bak  // baktım çhart kısmını sadece verilen linkte bulunan duruma göre yaparsak olacak
            // partial ayırıp yapabiliriz // web kısmını şu anlık böyle biraktım ancak mesaj ekleme kısmı yapılabilir fırmalar ararsı
            // basit zaten çağrı ekleme işleminin aynısı 


            // 25 te de ıframe ile harita bilgisi getirme anlatılıyor
            // 27 de rol verme mantığı anlatılmış


            // bazı alanlar boş kaldı onları tamamlayıp githuba ekle
        }

        private void BtnPasifÇağrılar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pas == null || pas.IsDisposed)
            {
                pas = new Formlar.FrmPasifCagrilarr();
                pas.MdiParent = this;
                pas.Show();

            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (firm == null || firm.IsDisposed)
            {
                firm = new Firmalar.FrmFirmaListesi();
                firm.MdiParent = this;
                firm.Show();
            }

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (aktif==null ||aktif.IsDisposed)
            {
                aktif = new Formlar.FrmAktifGörevler();
                aktif.MdiParent = this;
                aktif.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (pasgör==null || pasgör.IsDisposed)
            {
                pasgör = new Formlar.FrmPasifGörevler();
                pasgör.MdiParent = this;
                pasgör.Show();
            }

        }
    }
}
