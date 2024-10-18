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
    public partial class FrmPasifCagrilarr : Form
    {
        public FrmPasifCagrilarr()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmPasifCagrilarr_Load(object sender, EventArgs e)
        {
            var pasifcagrilar = (from x in db.TblCagrilar
                                 select new
                                 {
                                     x.ID,
                                     x.TblFirmalar.Ad,
                                     x.TblFirmalar.Telefon,
                                     x.Konu,
                                     x.Aciklama,
                                     x.Tarih,
                                     personel = x.TblPersonel.Ad,

                                     x.Durum
                                 }).Where(x => x.Durum == false).ToList();
            gridControl1.DataSource = pasifcagrilar;
        }
    }
}
