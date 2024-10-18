﻿using System;
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
    public partial class FrmPasifGörevler : Form
    {
        public FrmPasifGörevler()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmPasifGörevler_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblGörevler
                            select new
                            {

                                Görev_veren = x.TblPersonel.Ad,
                                x.Aciklama,
                                x.Durum,
                                x.Tarih



                            }).Where(x => x.Durum == false).ToList();

            gridControl1.DataSource = degerler;


        }
    }
}
