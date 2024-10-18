using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using istakipproje.Entity;

namespace istakipproje.Formlar
{
    public partial class FrmGörevDetay : Form
    {
        public FrmGörevDetay()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmGörevDetay_Load(object sender, EventArgs e)
        {
            db.TblGörevDetay.Load();
            bindingSource1.DataSource = db.TblGörevDetay.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // güncelleme ve ekleme işlemleri yapmak için sadece savechanges dememız yeterli
            db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
