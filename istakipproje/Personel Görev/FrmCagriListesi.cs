using istakipproje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istakipproje.Personel_Görev
{
    public partial class FrmCagriListesi : Form
    {
        public FrmCagriListesi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();

        public string mail2;
        private void FrmCagriListesi_Load(object sender, EventArgs e)
        {
            var personelıd = db.TblPersonel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();

            gridControl1.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.ID,
                                           x.TblFirmalar.Ad,
                                           x.TblFirmalar.Telefon,
                                           x.TblFirmalar.Mail,
                                           x.Aciklama,
                                           x.CagriPersonel,
                                           x.Durum



                                       }).Where(y => y.Durum == true && y.CagriPersonel==personelıd).ToList();

            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["CagriPersonel"].Visible = false;

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagrıDetayGirisi fr = new FrmCagrıDetayGirisi(); // cagridetaylardaki ıd ye tablodaki id yı taşıdık
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();


        }
    }
}
