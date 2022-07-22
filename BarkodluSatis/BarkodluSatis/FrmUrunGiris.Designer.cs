namespace BarkodluSatis
{
    partial class FrmUrunGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunGiris));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnKullanilmayanSil = new System.Windows.Forms.Button();
            this.cbUrunTipi = new System.Windows.Forms.CheckBox();
            this.txtUrunAra = new BarkodluSatis.tStandart();
            this.txtKdvOrani = new System.Windows.Forms.TextBox();
            this.txtUrunSayisi = new BarkodluSatis.tNumeric();
            this.lStandart10 = new BarkodluSatis.lStandart();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.lStandart9 = new BarkodluSatis.lStandart();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.lStandart11 = new BarkodluSatis.lStandart();
            this.lblKullanici = new BarkodluSatis.lStandart();
            this.btnRaporAl = new BarkodluSatis.bStandart();
            this.btnKaydet = new BarkodluSatis.bStandart();
            this.btnİptal = new BarkodluSatis.bStandart();
            this.btnBarkod = new BarkodluSatis.bStandart();
            this.btnuUrunEkle = new BarkodluSatis.bStandart();
            this.txtMiktar = new BarkodluSatis.tNumeric();
            this.lStandart8 = new BarkodluSatis.lStandart();
            this.lStandart7 = new BarkodluSatis.lStandart();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.txtAciklama = new BarkodluSatis.tStandart();
            this.txtUrunAd = new BarkodluSatis.tStandart();
            this.txtBakod = new BarkodluSatis.tStandart();
            this.cmbUrunGrup = new System.Windows.Forms.ComboBox();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.dgwUrunler = new BarkodluSatis.gridOzel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnKullanilmayanSil);
            this.splitContainer1.Panel1.Controls.Add(this.cbUrunTipi);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunAra);
            this.splitContainer1.Panel1.Controls.Add(this.txtKdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart10);
            this.splitContainer1.Panel1.Controls.Add(this.txtSatisFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart9);
            this.splitContainer1.Panel1.Controls.Add(this.txtAlisFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart11);
            this.splitContainer1.Panel1.Controls.Add(this.lblKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.btnRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btnİptal);
            this.splitContainer1.Panel1.Controls.Add(this.btnBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.btnuUrunEkle);
            this.splitContainer1.Panel1.Controls.Add(this.txtMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart8);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart7);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.txtAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunAd);
            this.splitContainer1.Panel1.Controls.Add(this.txtBakod);
            this.splitContainer1.Panel1.Controls.Add(this.cmbUrunGrup);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(938, 629);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnKullanilmayanSil
            // 
            this.btnKullanilmayanSil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnKullanilmayanSil.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnKullanilmayanSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnKullanilmayanSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanilmayanSil.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanilmayanSil.ForeColor = System.Drawing.Color.Red;
            this.btnKullanilmayanSil.Location = new System.Drawing.Point(797, 54);
            this.btnKullanilmayanSil.Name = "btnKullanilmayanSil";
            this.btnKullanilmayanSil.Size = new System.Drawing.Size(129, 50);
            this.btnKullanilmayanSil.TabIndex = 23;
            this.btnKullanilmayanSil.Text = "Kullanılmayan Ürünleri Sil";
            this.btnKullanilmayanSil.UseVisualStyleBackColor = false;
            this.btnKullanilmayanSil.Click += new System.EventHandler(this.btnKullanilmayanSil_Click_1);
            // 
            // cbUrunTipi
            // 
            this.cbUrunTipi.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbUrunTipi.AutoSize = true;
            this.cbUrunTipi.BackColor = System.Drawing.Color.YellowGreen;
            this.cbUrunTipi.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbUrunTipi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick;
            this.cbUrunTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUrunTipi.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUrunTipi.ForeColor = System.Drawing.Color.White;
            this.cbUrunTipi.Location = new System.Drawing.Point(110, 7);
            this.cbUrunTipi.Name = "cbUrunTipi";
            this.cbUrunTipi.Size = new System.Drawing.Size(129, 25);
            this.cbUrunTipi.TabIndex = 22;
            this.cbUrunTipi.Text = "Barkodlu Ürün İşlemi";
            this.cbUrunTipi.UseVisualStyleBackColor = false;
            this.cbUrunTipi.CheckedChanged += new System.EventHandler(this.cbUrunTipi_CheckedChanged);
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.BackColor = System.Drawing.Color.White;
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrunAra.Location = new System.Drawing.Point(110, 260);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(226, 26);
            this.txtUrunAra.TabIndex = 17;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKdvOrani.Location = new System.Drawing.Point(503, 133);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(115, 26);
            this.txtKdvOrani.TabIndex = 7;
            this.txtKdvOrani.Text = "8";
            this.txtKdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUrunSayisi
            // 
            this.txtUrunSayisi.BackColor = System.Drawing.Color.White;
            this.txtUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrunSayisi.Location = new System.Drawing.Point(466, 260);
            this.txtUrunSayisi.Name = "txtUrunSayisi";
            this.txtUrunSayisi.ReadOnly = true;
            this.txtUrunSayisi.Size = new System.Drawing.Size(115, 26);
            this.txtUrunSayisi.TabIndex = 19;
            this.txtUrunSayisi.TabStop = false;
            this.txtUrunSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart10
            // 
            this.lStandart10.AutoSize = true;
            this.lStandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart10.ForeColor = System.Drawing.Color.Navy;
            this.lStandart10.Location = new System.Drawing.Point(371, 263);
            this.lStandart10.Name = "lStandart10";
            this.lStandart10.Size = new System.Drawing.Size(89, 20);
            this.lStandart10.TabIndex = 18;
            this.lStandart10.Text = "Ürün Sayısı";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat.Location = new System.Drawing.Point(503, 64);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(115, 26);
            this.txtSatisFiyat.TabIndex = 5;
            this.txtSatisFiyat.Text = "0";
            this.txtSatisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart9
            // 
            this.lStandart9.AutoSize = true;
            this.lStandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart9.ForeColor = System.Drawing.Color.Navy;
            this.lStandart9.Location = new System.Drawing.Point(22, 263);
            this.lStandart9.Name = "lStandart9";
            this.lStandart9.Size = new System.Drawing.Size(73, 20);
            this.lStandart9.TabIndex = 16;
            this.lStandart9.Text = "Ürün Ara";
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyat.Location = new System.Drawing.Point(503, 32);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(115, 26);
            this.txtAlisFiyat.TabIndex = 4;
            this.txtAlisFiyat.Text = "0";
            this.txtAlisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart11
            // 
            this.lStandart11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lStandart11.AutoSize = true;
            this.lStandart11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart11.ForeColor = System.Drawing.Color.Navy;
            this.lStandart11.Location = new System.Drawing.Point(717, 7);
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
            this.lblKullanici.Location = new System.Drawing.Point(793, 7);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(92, 20);
            this.lblKullanici.TabIndex = 20;
            this.lblKullanici.Text = "lStandart11";
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
            this.btnRaporAl.Location = new System.Drawing.Point(830, 227);
            this.btnRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(108, 64);
            this.btnRaporAl.TabIndex = 0;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Visible = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
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
            this.btnKaydet.Location = new System.Drawing.Point(640, 101);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 58);
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
            this.btnİptal.Location = new System.Drawing.Point(640, 32);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(1);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(100, 62);
            this.btnİptal.TabIndex = 9;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnBarkod
            // 
            this.btnBarkod.BackColor = System.Drawing.Color.Brown;
            this.btnBarkod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBarkod.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnBarkod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarkod.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarkod.ForeColor = System.Drawing.Color.White;
            this.btnBarkod.Image = global::BarkodluSatis.Properties.Resources.barcode4832;
            this.btnBarkod.Location = new System.Drawing.Point(191, 181);
            this.btnBarkod.Margin = new System.Windows.Forms.Padding(1);
            this.btnBarkod.Name = "btnBarkod";
            this.btnBarkod.Size = new System.Drawing.Size(148, 56);
            this.btnBarkod.TabIndex = 11;
            this.btnBarkod.Text = "Barkod Oluştur";
            this.btnBarkod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBarkod.UseVisualStyleBackColor = false;
            this.btnBarkod.Click += new System.EventHandler(this.btnBarkod_Click);
            // 
            // btnuUrunEkle
            // 
            this.btnuUrunEkle.BackColor = System.Drawing.Color.Khaki;
            this.btnuUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnuUrunEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnuUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuUrunEkle.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnuUrunEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle20;
            this.btnuUrunEkle.Location = new System.Drawing.Point(110, 181);
            this.btnuUrunEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btnuUrunEkle.Name = "btnuUrunEkle";
            this.btnuUrunEkle.Size = new System.Drawing.Size(79, 56);
            this.btnuUrunEkle.TabIndex = 10;
            this.btnuUrunEkle.Text = "Ürün Grup Ekle";
            this.btnuUrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnuUrunEkle.UseVisualStyleBackColor = false;
            this.btnuUrunEkle.Click += new System.EventHandler(this.btnuUrunEkle_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.White;
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMiktar.Location = new System.Drawing.Point(503, 96);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(115, 26);
            this.txtMiktar.TabIndex = 6;
            this.txtMiktar.Text = "0";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart8
            // 
            this.lStandart8.AutoSize = true;
            this.lStandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart8.ForeColor = System.Drawing.Color.Navy;
            this.lStandart8.Location = new System.Drawing.Point(396, 131);
            this.lStandart8.Name = "lStandart8";
            this.lStandart8.Size = new System.Drawing.Size(77, 20);
            this.lStandart8.TabIndex = 11;
            this.lStandart8.Text = "Kdv Oranı";
            // 
            // lStandart7
            // 
            this.lStandart7.AutoSize = true;
            this.lStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart7.ForeColor = System.Drawing.Color.Navy;
            this.lStandart7.Location = new System.Drawing.Point(419, 99);
            this.lStandart7.Name = "lStandart7";
            this.lStandart7.Size = new System.Drawing.Size(52, 20);
            this.lStandart7.TabIndex = 10;
            this.lStandart7.Text = "Miktar";
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.Navy;
            this.lStandart6.Location = new System.Drawing.Point(385, 67);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(86, 20);
            this.lStandart6.TabIndex = 9;
            this.lStandart6.Text = "Satış Fiyatı";
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.Navy;
            this.lStandart5.Location = new System.Drawing.Point(396, 38);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(75, 20);
            this.lStandart5.TabIndex = 8;
            this.lStandart5.Text = "Alış Fiyatı";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(110, 110);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(226, 30);
            this.txtAciklama.TabIndex = 2;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.BackColor = System.Drawing.Color.White;
            this.txtUrunAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(110, 74);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(226, 30);
            this.txtUrunAd.TabIndex = 1;
            // 
            // txtBakod
            // 
            this.txtBakod.BackColor = System.Drawing.Color.White;
            this.txtBakod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakod.Location = new System.Drawing.Point(110, 38);
            this.txtBakod.Name = "txtBakod";
            this.txtBakod.Size = new System.Drawing.Size(226, 30);
            this.txtBakod.TabIndex = 0;
            this.txtBakod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBakod_KeyDown);
            this.txtBakod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBakod_KeyPress);
            // 
            // cmbUrunGrup
            // 
            this.cmbUrunGrup.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrup.FormattingEnabled = true;
            this.cmbUrunGrup.Items.AddRange(new object[] {
            "Temel Gıda",
            "Manav",
            "Bakım "});
            this.cmbUrunGrup.Location = new System.Drawing.Point(110, 146);
            this.cmbUrunGrup.Name = "cmbUrunGrup";
            this.cmbUrunGrup.Size = new System.Drawing.Size(226, 31);
            this.cmbUrunGrup.TabIndex = 3;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.Navy;
            this.lStandart4.Location = new System.Drawing.Point(2, 151);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(93, 20);
            this.lStandart4.TabIndex = 3;
            this.lStandart4.Text = "Ürün Grubu";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.Navy;
            this.lStandart3.Location = new System.Drawing.Point(17, 115);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(73, 20);
            this.lStandart3.TabIndex = 2;
            this.lStandart3.Text = "Açıklama";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.Navy;
            this.lStandart2.Location = new System.Drawing.Point(19, 79);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(71, 20);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "Ürün Adı";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.Navy;
            this.lStandart1.Location = new System.Drawing.Point(30, 43);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(60, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Barkod";
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AllowUserToAddRows = false;
            this.dgwUrunler.AllowUserToDeleteRows = false;
            this.dgwUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwUrunler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUrunler.EnableHeadersVisualStyles = false;
            this.dgwUrunler.Location = new System.Drawing.Point(6, 3);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.ReadOnly = true;
            this.dgwUrunler.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUrunler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgwUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgwUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwUrunler.RowTemplate.Height = 32;
            this.dgwUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUrunler.Size = new System.Drawing.Size(929, 348);
            this.dgwUrunler.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // FrmUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 629);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN GİRİŞ";
            this.Load += new System.EventHandler(this.FrmUrunGiris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private tNumeric txtUrunSayisi;
        private lStandart lStandart10;
        private tStandart txtUrunAra;
        private lStandart lStandart9;
        private bStandart btnRaporAl;
        private bStandart btnKaydet;
        private bStandart btnİptal;
        private bStandart btnBarkod;
        private bStandart btnuUrunEkle;
        private lStandart lStandart8;
        private lStandart lStandart7;
        private lStandart lStandart6;
        private lStandart lStandart5;
        private tStandart txtAciklama;
        private tStandart txtUrunAd;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private lStandart lStandart2;
        private lStandart lStandart1;
        internal tStandart txtBakod;
        private lStandart lStandart11;
        internal lStandart lblKullanici;
        private gridOzel dgwUrunler;
        public System.Windows.Forms.ComboBox cmbUrunGrup;
        private System.Windows.Forms.TextBox txtKdvOrani;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private tNumeric txtMiktar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbUrunTipi;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.Button btnKullanilmayanSil;
    }
}