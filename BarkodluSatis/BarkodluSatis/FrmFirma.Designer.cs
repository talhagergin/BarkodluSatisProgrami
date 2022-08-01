namespace BarkodluSatis
{
    partial class FrmFirma
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirma));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.txtGenelBorc = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.detayGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnBorcEkle = new System.Windows.Forms.Button();
            this.lblKullaniciId = new BarkodluSatis.lStandart();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.txtFirmaAd = new BarkodluSatis.tStandart();
            this.lStandart12 = new BarkodluSatis.lStandart();
            this.txtFirmaAra = new BarkodluSatis.tStandart();
            this.txtFirmaSayisi = new BarkodluSatis.tNumeric();
            this.lStandart10 = new BarkodluSatis.lStandart();
            this.lStandart9 = new BarkodluSatis.lStandart();
            this.lStandart11 = new BarkodluSatis.lStandart();
            this.lblKullanici = new BarkodluSatis.lStandart();
            this.btnRaporAl = new BarkodluSatis.bStandart();
            this.btnKaydet = new BarkodluSatis.bStandart();
            this.btnİptal = new BarkodluSatis.bStandart();
            this.txtKalan = new BarkodluSatis.tNumeric();
            this.lStandart7 = new BarkodluSatis.lStandart();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.txtIlce = new BarkodluSatis.tStandart();
            this.txtIl = new BarkodluSatis.tStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.dgwFirma = new BarkodluSatis.gridOzel();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.detayGösterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 70);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // txtOdenen
            // 
            this.txtOdenen.Enabled = false;
            this.txtOdenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenen.Location = new System.Drawing.Point(503, 64);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(115, 26);
            this.txtOdenen.TabIndex = 5;
            this.txtOdenen.Text = "0";
            this.txtOdenen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGenelBorc
            // 
            this.txtGenelBorc.Enabled = false;
            this.txtGenelBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGenelBorc.Location = new System.Drawing.Point(503, 32);
            this.txtGenelBorc.Name = "txtGenelBorc";
            this.txtGenelBorc.Size = new System.Drawing.Size(115, 26);
            this.txtGenelBorc.TabIndex = 4;
            this.txtGenelBorc.Text = "0";
            this.txtGenelBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTelefon);
            this.splitContainer1.Panel1.Controls.Add(this.btnOdeme);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorcEkle);
            this.splitContainer1.Panel1.Controls.Add(this.lblKullaniciId);
            this.splitContainer1.Panel1.Controls.Add(this.txtAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirmaAd);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart12);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirmaAra);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirmaSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart10);
            this.splitContainer1.Panel1.Controls.Add(this.txtOdenen);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart9);
            this.splitContainer1.Panel1.Controls.Add(this.txtGenelBorc);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart11);
            this.splitContainer1.Panel1.Controls.Add(this.lblKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.btnRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btnİptal);
            this.splitContainer1.Panel1.Controls.Add(this.txtKalan);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart7);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.txtIlce);
            this.splitContainer1.Panel1.Controls.Add(this.txtIl);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwFirma);
            this.splitContainer1.Size = new System.Drawing.Size(992, 443);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(440, 128);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(249, 61);
            this.txtAciklama.TabIndex = 4;
            this.txtAciklama.Text = "";
            // 
            // detayGösterToolStripMenuItem
            // 
            this.detayGösterToolStripMenuItem.Name = "detayGösterToolStripMenuItem";
            this.detayGösterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.detayGösterToolStripMenuItem.Text = "Detay Göster";
            this.detayGösterToolStripMenuItem.Click += new System.EventHandler(this.detayGösterToolStripMenuItem_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOdeme.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdeme.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdeme.ForeColor = System.Drawing.Color.White;
            this.btnOdeme.Image = global::BarkodluSatis.Properties.Resources.Ekle20;
            this.btnOdeme.Location = new System.Drawing.Point(624, 66);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(99, 26);
            this.btnOdeme.TabIndex = 34;
            this.btnOdeme.Text = "Ödeme Ekle";
            this.btnOdeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnBorcEkle
            // 
            this.btnBorcEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBorcEkle.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnBorcEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorcEkle.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorcEkle.ForeColor = System.Drawing.Color.White;
            this.btnBorcEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle20;
            this.btnBorcEkle.Location = new System.Drawing.Point(624, 32);
            this.btnBorcEkle.Name = "btnBorcEkle";
            this.btnBorcEkle.Size = new System.Drawing.Size(99, 26);
            this.btnBorcEkle.TabIndex = 33;
            this.btnBorcEkle.Text = "Borç Ekle";
            this.btnBorcEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorcEkle.UseVisualStyleBackColor = false;
            this.btnBorcEkle.Click += new System.EventHandler(this.btnBorcEkle_Click);
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKullaniciId.ForeColor = System.Drawing.Color.Navy;
            this.lblKullaniciId.Location = new System.Drawing.Point(880, 118);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(83, 20);
            this.lblKullaniciId.TabIndex = 32;
            this.lblKullaniciId.Text = "lStandart9";
            this.lblKullaniciId.Visible = false;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.Navy;
            this.lStandart4.Location = new System.Drawing.Point(352, 148);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(73, 20);
            this.lStandart4.TabIndex = 30;
            this.lStandart4.Text = "Açıklama";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.Navy;
            this.lStandart1.Location = new System.Drawing.Point(33, 152);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(62, 20);
            this.lStandart1.TabIndex = 28;
            this.lStandart1.Text = "Telefon";
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.BackColor = System.Drawing.Color.White;
            this.txtFirmaAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAd.Location = new System.Drawing.Point(110, 46);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Size = new System.Drawing.Size(226, 30);
            this.txtFirmaAd.TabIndex = 0;
            // 
            // lStandart12
            // 
            this.lStandart12.AutoSize = true;
            this.lStandart12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart12.ForeColor = System.Drawing.Color.Navy;
            this.lStandart12.Location = new System.Drawing.Point(22, 51);
            this.lStandart12.Name = "lStandart12";
            this.lStandart12.Size = new System.Drawing.Size(73, 20);
            this.lStandart12.TabIndex = 25;
            this.lStandart12.Text = "Firma Ad";
            // 
            // txtFirmaAra
            // 
            this.txtFirmaAra.BackColor = System.Drawing.Color.White;
            this.txtFirmaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirmaAra.Location = new System.Drawing.Point(113, 209);
            this.txtFirmaAra.Name = "txtFirmaAra";
            this.txtFirmaAra.Size = new System.Drawing.Size(226, 26);
            this.txtFirmaAra.TabIndex = 5;
            this.txtFirmaAra.TextChanged += new System.EventHandler(this.txtFirmaAra_TextChanged);
            // 
            // txtFirmaSayisi
            // 
            this.txtFirmaSayisi.BackColor = System.Drawing.Color.White;
            this.txtFirmaSayisi.Enabled = false;
            this.txtFirmaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirmaSayisi.Location = new System.Drawing.Point(503, 206);
            this.txtFirmaSayisi.Name = "txtFirmaSayisi";
            this.txtFirmaSayisi.ReadOnly = true;
            this.txtFirmaSayisi.Size = new System.Drawing.Size(115, 26);
            this.txtFirmaSayisi.TabIndex = 19;
            this.txtFirmaSayisi.TabStop = false;
            this.txtFirmaSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart10
            // 
            this.lStandart10.AutoSize = true;
            this.lStandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart10.ForeColor = System.Drawing.Color.Navy;
            this.lStandart10.Location = new System.Drawing.Point(391, 209);
            this.lStandart10.Name = "lStandart10";
            this.lStandart10.Size = new System.Drawing.Size(94, 20);
            this.lStandart10.TabIndex = 18;
            this.lStandart10.Text = "Firma Sayısı";
            // 
            // lStandart9
            // 
            this.lStandart9.AutoSize = true;
            this.lStandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart9.ForeColor = System.Drawing.Color.Navy;
            this.lStandart9.Location = new System.Drawing.Point(21, 212);
            this.lStandart9.Name = "lStandart9";
            this.lStandart9.Size = new System.Drawing.Size(78, 20);
            this.lStandart9.TabIndex = 16;
            this.lStandart9.Text = "Firma Ara";
            // 
            // lStandart11
            // 
            this.lStandart11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lStandart11.AutoSize = true;
            this.lStandart11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart11.ForeColor = System.Drawing.Color.Navy;
            this.lStandart11.Location = new System.Drawing.Point(771, -16);
            this.lStandart11.Name = "lStandart11";
            this.lStandart11.Size = new System.Drawing.Size(70, 20);
            this.lStandart11.TabIndex = 21;
            this.lStandart11.Text = "Kullanıcı:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKullanici.ForeColor = System.Drawing.Color.Navy;
            this.lblKullanici.Location = new System.Drawing.Point(847, -16);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(81, 20);
            this.lblKullanici.TabIndex = 20;
            this.lblKullanici.Text = "lblKullanici";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRaporAl.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRaporAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporAl.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporAl.ForeColor = System.Drawing.Color.White;
            this.btnRaporAl.Image = global::BarkodluSatis.Properties.Resources.icons8_export_pdf_40;
            this.btnRaporAl.Location = new System.Drawing.Point(884, 182);
            this.btnRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(108, 64);
            this.btnRaporAl.TabIndex = 0;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Image = global::BarkodluSatis.Properties.Resources.save24;
            this.btnKaydet.Location = new System.Drawing.Point(866, 32);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 62);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Red;
            this.btnİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnİptal.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİptal.ForeColor = System.Drawing.Color.White;
            this.btnİptal.Image = global::BarkodluSatis.Properties.Resources.cancel24;
            this.btnİptal.Location = new System.Drawing.Point(741, 32);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(1);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(100, 62);
            this.btnİptal.TabIndex = 9;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtKalan
            // 
            this.txtKalan.BackColor = System.Drawing.Color.White;
            this.txtKalan.Enabled = false;
            this.txtKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKalan.Location = new System.Drawing.Point(503, 96);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(115, 26);
            this.txtKalan.TabIndex = 6;
            this.txtKalan.Text = "0";
            this.txtKalan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart7
            // 
            this.lStandart7.AutoSize = true;
            this.lStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart7.ForeColor = System.Drawing.Color.Navy;
            this.lStandart7.Location = new System.Drawing.Point(436, 96);
            this.lStandart7.Name = "lStandart7";
            this.lStandart7.Size = new System.Drawing.Size(49, 20);
            this.lStandart7.TabIndex = 10;
            this.lStandart7.Text = "Kalan";
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.Navy;
            this.lStandart6.Location = new System.Drawing.Point(419, 67);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(66, 20);
            this.lStandart6.TabIndex = 9;
            this.lStandart6.Text = "Ödenen";
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.Navy;
            this.lStandart5.Location = new System.Drawing.Point(396, 38);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(89, 20);
            this.lStandart5.TabIndex = 8;
            this.lStandart5.Text = "Genel Borc";
            // 
            // txtIlce
            // 
            this.txtIlce.BackColor = System.Drawing.Color.White;
            this.txtIlce.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlce.Location = new System.Drawing.Point(110, 118);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(226, 30);
            this.txtIlce.TabIndex = 2;
            // 
            // txtIl
            // 
            this.txtIl.BackColor = System.Drawing.Color.White;
            this.txtIl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIl.Location = new System.Drawing.Point(110, 82);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(226, 30);
            this.txtIl.TabIndex = 1;
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.Navy;
            this.lStandart3.Location = new System.Drawing.Point(61, 123);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(34, 20);
            this.lStandart3.TabIndex = 2;
            this.lStandart3.Text = "İlçe";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.Navy;
            this.lStandart2.Location = new System.Drawing.Point(74, 87);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(17, 20);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "İl";
            // 
            // dgwFirma
            // 
            this.dgwFirma.AllowUserToAddRows = false;
            this.dgwFirma.AllowUserToDeleteRows = false;
            this.dgwFirma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwFirma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFirma.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwFirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwFirma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwFirma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFirma.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwFirma.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwFirma.EnableHeadersVisualStyles = false;
            this.dgwFirma.Location = new System.Drawing.Point(6, 3);
            this.dgwFirma.Name = "dgwFirma";
            this.dgwFirma.ReadOnly = true;
            this.dgwFirma.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwFirma.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwFirma.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgwFirma.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgwFirma.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwFirma.RowTemplate.Height = 32;
            this.dgwFirma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFirma.Size = new System.Drawing.Size(983, 348);
            this.dgwFirma.TabIndex = 20;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(110, 154);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(226, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // FrmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 443);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİRMALAR";
            this.Load += new System.EventHandler(this.FrmFirma_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private lStandart lStandart12;
        private tStandart txtFirmaAra;
        private tNumeric txtFirmaSayisi;
        private lStandart lStandart10;
        private System.Windows.Forms.TextBox txtOdenen;
        private lStandart lStandart9;
        private System.Windows.Forms.TextBox txtGenelBorc;
        private lStandart lStandart11;
        internal lStandart lblKullanici;
        private bStandart btnRaporAl;
        private bStandart btnKaydet;
        private tNumeric txtKalan;
        private lStandart lStandart7;
        private lStandart lStandart6;
        private bStandart btnİptal;
        private lStandart lStandart5;
        private tStandart txtIlce;
        private tStandart txtIl;
        private lStandart lStandart3;
        private lStandart lStandart2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private tStandart txtFirmaAd;
        private gridOzel dgwFirma;
        private lStandart lStandart1;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private lStandart lStandart4;
        private lStandart lblKullaniciId;
        private System.Windows.Forms.Button btnBorcEkle;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.ToolStripMenuItem detayGösterToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}