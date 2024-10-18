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

namespace istakipproje.Formlar
{
    public partial class FrmCagriAtama : Form
    {
        public FrmCagriAtama()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
         
        public int id;
        private void FrmCagriAtama_Load(object sender, EventArgs e)
        {
            //LookupEdit için verilerin listelenmesi
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad

                            }).ToList();
            TxtGörevAlan.Properties.ValueMember = "ID";
            TxtGörevAlan.Properties.DisplayMember = "AdSoyad";
            TxtGörevAlan.Properties.DataSource = degerler;

            TxtCagriId.Text = id.ToString();
            var gelenveri = db.TblCagrilar.Find(id);
            TxtAçıklama.Text = gelenveri.Aciklama;
            TxtTarih.Text = gelenveri.Tarih.ToString();
            TxtKonu.Text = gelenveri.Konu;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var gelenveri = db.TblCagrilar.Find(id);
                gelenveri.Konu = TxtKonu.Text;
                gelenveri.Tarih = Convert.ToDateTime(TxtTarih.Text);
                gelenveri.Aciklama = TxtAçıklama.Text;
                gelenveri.CagriPersonel = int.Parse(TxtGörevAlan.EditValue.ToString());
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme işlemi gerçekleşti");
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message);

               
            }
           

        }

    }
}
