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

namespace istakipproje.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        Form1 fr;
        Personel_Görev.FrmPersonelFormu fr2;
        private void button1_Click(object sender, EventArgs e)
        {

            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == TxtKadi.Text && x.Sifre == TxtŞif.Text).FirstOrDefault();
            if (adminvalue != null)
            {

                if (fr == null || fr.IsDisposed)
                {
                    XtraMessageBox.Show("Hoşgeldiniz");
                    fr = new Form1();
                    fr.Show();
                    this.Hide();
                }
                
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş yaptınız");
            }

            TxtKadi.Text = "";
            TxtŞif.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pesonelvalue = db.TblPersonel.Where(x => x.Mail == TxtKadi.Text && x.Sifre == TxtŞif.Text).FirstOrDefault();
            if (pesonelvalue != null)
            {

                if (fr2 == null || fr2.IsDisposed)
                {
                    XtraMessageBox.Show("Hoş Geldiniz");
                    fr2 = new Personel_Görev.FrmPersonelFormu();
                    fr2.mail = TxtKadi.Text; // personel formuna mail adresini gönderik yani kullanıcı adını
                    fr2.Show();
                    this.Hide();
                }
               
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş Yaptınız");
            }

            TxtKadi.Text = "";
            TxtŞif.Text = "";


        }



        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Sienna;
            panel3.BackColor = Color.AntiqueWhite;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Sienna;
            panel2.BackColor = Color.AntiqueWhite;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.AntiqueWhite;
            panel3.BackColor = Color.AntiqueWhite;
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
