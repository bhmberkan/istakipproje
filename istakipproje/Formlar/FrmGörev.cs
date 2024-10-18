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
    public partial class FrmGörev : Form
    {
        public FrmGörev()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmGörev_Load(object sender, EventArgs e)
        {
            var görev = (from x in db.TblPersonel
                         select new
                         {
                             x.ID,
                             adsoyad = x.Ad +" "+ x.Soyad
                         }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "adsoyad";
            lookUpEdit1.Properties.DataSource = görev;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TblGörevler t = new TblGörevler();
            t.Aciklama = TxtAçıklama.Text;
            t.Durum = true;
            t.GörevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.GörevVeren = 1;
            db.TblGörevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
