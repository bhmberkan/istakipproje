using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using istakipproje.Entity;

namespace istakipproje.Personel_Görev
{
    public partial class FrmCagrıDetayGirisi : Form
    {
        public FrmCagrıDetayGirisi()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        public int id;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagrıDetayGirisi_Load(object sender, EventArgs e)
        {
            TxtCagrıID.Enabled = false;
            TxtCagrıID.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            TxtTarih.Text = tarih;
            TxtSaat.Text = saat;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(TxtCagrıID.Text);
            t.Saat = TxtSaat.Text;
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.Aciklama = TxtAçıklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Cagri Detayi Sisteme başarılı Bir Şekilde Kaydedildi");


            //89. derste kaldık hata çözülmedi

        }
    }
}
