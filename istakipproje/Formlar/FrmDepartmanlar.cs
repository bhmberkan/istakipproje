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
    public partial class FrmDepartmanlar : Form
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        void listele()
        {
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.ID,
                                x.Ad

                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t = new TblDepartmanlar();
            t.Ad = TxtAD.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("departman başarılı bir şekilde sisteme kaydedildi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            TxtAD.Text = " ";
            listele();

            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman silme işlemi başarılı.","Bigli",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            txtID.Text = " ";
            TxtAD.Text = " ";
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // imleç bir hücreden başka bir hüücreye geçtiğinde tıkladığında yapıalcak işlemler için.
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAD.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void FrmDepartmanlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.TblDepartmanlar.Find(x);
            deger.Ad = TxtAD.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman güncelleme işlemi başarı ile gerçekleşti.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            txtID.Text = " ";
            TxtAD.Text = " "; 
            listele();



        }
    }
}
