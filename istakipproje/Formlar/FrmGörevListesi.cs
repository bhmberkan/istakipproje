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
    public partial class FrmGörevListesi : Form
    {
        public FrmGörevListesi()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmGörevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGörevler
                                       select new
                                       {
                                           x.Aciklama
                                       }).ToList();


            //chartControl1.Series["Series 1"].Points.AddPoint("insan kaynakları",26);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bilgi İşlem", 34);
            //chartControl1.Series["Series 1"].Points.AddPoint(" Muhasebe ", 18);
            //chartControl1.Series["Series 1"].Points.AddPoint("Danışma ", 16);
            //chartControl1.Series["Series 1"].Points.AddPoint("Mutfak ", 21);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ulaştırma ", 19);
            //chartControl1.Series["Series 1"].Points.AddPoint("Staj ", 13);


            LblAktifGör.Text = db.TblGörevler.Where(x => x.Durum == true).Count().ToString();
            LblPasifGör.Text = db.TblGörevler.Where(x => x.Durum == false).Count().ToString();
            LblToplamDep.Text = db.TblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler",int.Parse(LblAktifGör.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(LblPasifGör.Text));

           
        }

       
    }
}
