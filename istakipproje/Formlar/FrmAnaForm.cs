using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using istakipproje.Entity;

namespace istakipproje.Formlar
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGörevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Pesonel = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad,
                                           x.Durum

                                       }).Where(y => y.Durum == true).ToList();

            gridView1.Columns["Durum"].Visible = false; //  durum kısmı görünmesin sadece durumu tru olanları listeleyelim


            // bugün yapılan görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            //  MessageBox.Show(bugun.ToString());
            gridControl2.DataSource = (from x in db.TblGörevDetay
                                       select new
                                       {
                                           görev = x.TblGörevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih


                                       }).Where(x => x.Tarih == bugun).ToList();

            // Aktif çarğı listesi
            gridControl3.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();

            gridView3.Columns["Durum"].Visible = false;

            // Fihrist komutları
            gridControl4.DataSource = (from x in db.TblFirmalar
                                    select new
                                    {
                                        x.Ad,
                                        x.Telefon,
                                        x.Mail

                                    }).ToList();

            // Çağrı grafikleri
            int aktif_cagri = db.TblCagrilar.Where(x => x.Durum == true).Count();
            int pasif_cagri = db.TblCagrilar.Where(x => x.Durum == false).Count();

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", aktif_cagri);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasif_cagri);


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
