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

namespace istakipproje.Firmalar
{
    public partial class FrmFirmaListesi : Form
    {
        public FrmFirmaListesi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();

         void listele()
        {
            var liste = (from x in db.TblFirmalar
                         select new
                         {
                             x.ID,
                             x.Ad,
                             x.Yetkili,
                             x.Telefon,
                             x.Mail,
                             x.Sifre,
                             x.Sektor,
                             x.il,
                             x.ilce,
                             x.Adres,
                             x.Görsel
                         }).ToList();
            gridControl1.DataSource = liste;

          
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["Sifre"].Visible = false;
            gridView1.Columns["il"].Visible = false;
            gridView1.Columns["ilce"].Visible = false;
            gridView1.Columns["Görsel"].Visible = false;
        }
        private void FrmFirmaListesi_Load(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Fotograflar kısmına hızlı resim linki eklenmelidir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LabelID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAD.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtYetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            TxtSifre.Text = gridView1.GetFocusedRowCellValue("Sifre").ToString();
            TxtSektör.Text = gridView1.GetFocusedRowCellValue("Sektor").ToString();
            Txtİl.Text = gridView1.GetFocusedRowCellValue("il").ToString();
            Txtİlçe.Text = gridView1.GetFocusedRowCellValue("ilce").ToString();
            TxtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            TxtFoto.Text = gridView1.GetFocusedRowCellValue("Görsel").ToString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                TblFirmalar t = new TblFirmalar();
              
                t.Ad = TxtAD.Text;
                t.Yetkili = TxtYetkili.Text;
                t.Telefon = TxtTelefon.Text;
                t.Mail = TxtMail.Text;
                t.Sifre = TxtSifre.Text;
                t.Sektor = TxtSektör.Text;
                t.il = Txtİl.Text;
                t.ilce = Txtİlçe.Text;
                t.Adres = TxtAdres.Text;
                t.Görsel = TxtFoto.Text;
                db.TblFirmalar.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Firma başarılı bir şekilde sisteme kaydedildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = "";
                    }
                }
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message);
                
            }
          
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(LabelID.Text);
                var deger = db.TblFirmalar.Find(x);
                db.TblFirmalar.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Firma Silme işlemi başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message);
                
            }
            
          
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

            try
            {
                int x = int.Parse(LabelID.Text);
                var deger = db.TblFirmalar.Find(x);
                deger.Ad = TxtAD.Text;
                deger.Yetkili = TxtYetkili.Text;
                deger.Telefon = TxtTelefon.Text;
                deger.Mail = TxtMail.Text;
                deger.Sifre = TxtSifre.Text;
                deger.Sektor = TxtSektör.Text;
                deger.il = Txtİl.Text;
                deger.ilce = Txtİlçe.Text;
                deger.Adres = TxtAdres.Text;
                deger.Görsel = TxtFoto.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Firma Başarı ile Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                listele();
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message);
                
            }
          
        }

       
    }
}
