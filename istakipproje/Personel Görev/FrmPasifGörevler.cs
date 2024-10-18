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
    public partial class FrmPasifGörevler : Form
    {
        public FrmPasifGörevler()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        public string mail2;

        private void FrmPasifGörevler_Load(object sender, EventArgs e)
        {
            var personelıd = db.TblPersonel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();

            var degerler = (from x in db.TblGörevler
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GörevAlan,
                                x.Durum
                            }).Where(x => x.GörevAlan == personelıd && x.Durum == false).ToList();

            gridControl1.DataSource = degerler;
            gridView1.Columns["GörevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;

            int görevsay = gridView1.RowCount;
            if (görevsay==0)
            {
                XtraMessageBox.Show("Pasif Görev Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
