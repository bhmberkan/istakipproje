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
    public partial class FrmPersonelistatistik : Form
    {
        public FrmPersonelistatistik()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmPersonelistatistik_Load(object sender, EventArgs e)
        {

            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            LblToplamFirma.Text = db.TblFirmalar.Count().ToString();
            LblToplamPersonel.Text = db.TblPersonel.Count().ToString();

            // aktif pasif iş tanımları
            LblAktifİşSay.Text = db.TblGörevler.Count(x => x.Durum == true).ToString();
            LblPasifİş.Text = db.TblGörevler.Count(x => x.Durum == false).ToString();

            // en son eklenen görevi getiricem
            // ilk başta listeyi tersine çevirdim descending ile daha sonra firsordefault ile en üstteki veriyi getirdim
            lblSongorev.Text = db.TblGörevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault().ToString();


            // il sayısını sayacağız ancak daha once var olan bir ifadeyi sadece bir defa saymak istiyoruz o zaman distinct kullanıyoruz.
            LblSehirsay.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            LblSektorSay.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();

            DateTime bugun = DateTime.Today;
            LblBugunGörev.Text = db.TblGörevler.Count(x => x.Tarih == bugun).ToString();


            //ayın personeli
            var d1 = db.TblGörevler.GroupBy(x => x.GörevAlan).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
            LblAyınPersoneli.Text = db.TblPersonel.Where(x => x.ID == d1).Select(y => y.Ad + " " + y.Soyad).FirstOrDefault().ToString();

            //ayın departmanı
            LblAyınDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == db.TblPersonel.Where(t => t.ID == d1).Select(z => z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();


            LblsongorevTarih.Text = db.TblGörevDetay.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();

            // ders 36 da kaldım
        }


    }
}
