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
    public partial class FrmAktifGörevler : Form
    {
        public FrmAktifGörevler()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
          public string mail2;

        private void FrmAktifGörevler_Load(object sender, EventArgs e)
        {
            var personelıd = db.TblPersonel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
           
            // mail2 den gelen değere göre personel ıd sini seçtirdik. daha sonra bu ıd yi personel ıd değişkenine aktardık
            // en sondunda da seçim yaparken gorevalan kullanıcıyı bu personel ıd ye göre eşleştirdik
            
            // amacımız burada hangi personel giriş yaptıysa onun verilerini getirmek.    
            var degerler = (from x in db.TblGörevler
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GörevAlan,
                                x.Durum
                            }).Where(x => x.GörevAlan == personelıd && x.Durum==true).ToList();
          
            gridControl1.DataSource = degerler;
            gridView1.Columns["GörevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;


            int görevsay = gridView1.RowCount;
            if (görevsay == 0)
            {
                XtraMessageBox.Show("Aktif Görev Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
