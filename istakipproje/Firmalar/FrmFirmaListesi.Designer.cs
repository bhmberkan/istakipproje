
namespace istakipproje.Firmalar
{
    partial class FrmFirmaListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmaListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSektör = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Txtİl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txtİlçe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdres = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFoto = new DevExpress.XtraEditors.TextEdit();
            this.LabelID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSektör.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİlçe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFoto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-4, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(696, 355);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(826, 311);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(261, 29);
            this.BtnGüncelle.TabIndex = 15;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(826, 276);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(261, 29);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(826, 241);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(261, 29);
            this.BtnEkle.TabIndex = 13;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(782, 59);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Size = new System.Drawing.Size(154, 22);
            this.TxtAD.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(714, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Firma AD :";
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(782, 96);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(154, 22);
            this.TxtYetkili.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(697, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 16);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Firma Yetkili :";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(782, 131);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(154, 22);
            this.TxtTelefon.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(724, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 16);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Telefon :";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(782, 168);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(154, 22);
            this.TxtMail.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(744, 171);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 16);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Mail :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(782, 199);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(154, 22);
            this.TxtSifre.TabIndex = 23;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(740, 202);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 16);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Sifre :";
            // 
            // TxtSektör
            // 
            this.TxtSektör.Location = new System.Drawing.Point(1008, 56);
            this.TxtSektör.Name = "TxtSektör";
            this.TxtSektör.Size = new System.Drawing.Size(162, 22);
            this.TxtSektör.TabIndex = 25;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(956, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 16);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Sektör :";
            // 
            // Txtİl
            // 
            this.Txtİl.Location = new System.Drawing.Point(1008, 84);
            this.Txtİl.Name = "Txtİl";
            this.Txtİl.Size = new System.Drawing.Size(162, 22);
            this.Txtİl.TabIndex = 27;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(956, 87);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(16, 16);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "İl :";
            // 
            // Txtİlçe
            // 
            this.Txtİlçe.Location = new System.Drawing.Point(1008, 112);
            this.Txtİlçe.Name = "Txtİlçe";
            this.Txtİlçe.Size = new System.Drawing.Size(162, 22);
            this.Txtİlçe.TabIndex = 29;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(956, 115);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(29, 16);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "İlçe :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(955, 134);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 16);
            this.labelControl10.TabIndex = 30;
            this.labelControl10.Text = "Adres :";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(1008, 137);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(162, 59);
            this.TxtAdres.TabIndex = 32;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(940, 205);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 16);
            this.labelControl11.TabIndex = 34;
            this.labelControl11.Text = "Fotograf :";
            // 
            // TxtFoto
            // 
            this.TxtFoto.Location = new System.Drawing.Point(1008, 202);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(162, 22);
            this.TxtFoto.TabIndex = 33;
            // 
            // LabelID
            // 
            this.LabelID.Location = new System.Drawing.Point(720, 12);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(21, 16);
            this.LabelID.TabIndex = 35;
            this.LabelID.Text = "ID :";
            this.LabelID.Visible = false;
            // 
            // FrmFirmaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 353);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.TxtFoto);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.Txtİlçe);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.Txtİl);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.TxtSektör);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtAD);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFirmaListesi";
            this.Text = "Firma Listesi";
            this.Load += new System.EventHandler(this.FrmFirmaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSektör.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİlçe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFoto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.TextEdit TxtAD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtSektör;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit Txtİl;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit Txtİlçe;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit TxtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtFoto;
        private DevExpress.XtraEditors.LabelControl LabelID;
    }
}