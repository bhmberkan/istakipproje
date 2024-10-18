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
    public partial class Frmpersoneller : Form
    {
        public Frmpersoneller()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();

        void listele()
        {
            var degerler = from x in db.TblPersonel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               x.Telefon,
                               Departman = x.TblDepartmanlar.Ad,
                               x.Durum
                           };
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();

        }

        private void personeller_Load(object sender, EventArgs e)
        {
             listele();
            var depertmanlar = (from x in db.TblDepartmanlar
                                select new
                                {
                                    x.ID,
                                    x.Ad
                                }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = depertmanlar;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.Ad = TxtAD.Text;
            t.Soyad = TxtSoyad.Text;
            t.Mail = TxtMail.Text;
            t.Gorsel = Txtgörsel.Text;
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblPersonel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

            // 22. videoda kaldım
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtID.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel Başarılı bir şekilde Silindi. Silinen personeller listesinden silinen tüm personeller bilgisine erişebilirsiniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAD.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
           // Txtgörsel.Text = gridView1.GetFocusedRowCellValue("Görsel").ToString();
            
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
          
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Ad = TxtAD.Text;
            deger.Soyad = TxtSoyad.Text;
            deger.Mail = TxtMail.Text;
            deger.Gorsel = Txtgörsel.Text;
            deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Personel Başarılı bir şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }
    }
}
