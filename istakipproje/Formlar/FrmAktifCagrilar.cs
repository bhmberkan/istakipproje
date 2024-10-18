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
    public partial class FrmAktifCagrilar : Form
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

       
        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblCagrilar
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
                            }).Where(x => x.Durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriAtama fr = new FrmCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();

            // 89. derste kaldım

        }
    }
}
