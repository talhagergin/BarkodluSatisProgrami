namespace BarkodluSatis
{
    partial class FrmMusteriBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriBilgi));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.btnYeniMusteri = new BarkodluSatis.bStandart();
            this.txtMahalle = new BarkodluSatis.tStandart();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMusteriAra = new BarkodluSatis.tStandart();
            this.txtMusteriSayisi = new BarkodluSatis.tNumeric();
            this.lStandart10 = new BarkodluSatis.lStandart();
            this.lStandart9 = new BarkodluSatis.lStandart();
            this.btnKaydet = new BarkodluSatis.bStandart();
            this.btnİptal = new BarkodluSatis.bStandart();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.txtSoyad = new BarkodluSatis.tStandart();
            this.txtAd = new BarkodluSatis.tStandart();
            this.txtMusteriNo = new BarkodluSatis.tStandart();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.dgwMusteriler = new BarkodluSatis.gridOzel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barkodDbDataSet = new BarkodluSatis.BarkodDbDataSet();
            this.musteriTableAdapter = new BarkodluSatis.BarkodDbDataSetTableAdapters.MusteriTableAdapter();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkodDbDataSet)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.cmbIslemTuru);
            this.splitContainer1.Panel1.Controls.Add(this.btnYeniMusteri);
            this.splitContainer1.Panel1.Controls.Add(this.txtMahalle);
            this.splitContainer1.Panel1.Controls.Add(this.txtTelefon);
            this.splitContainer1.Panel1.Controls.Add(this.txtMusteriAra);
            this.splitContainer1.Panel1.Controls.Add(this.txtMusteriSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart10);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart9);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btnİptal);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.txtAd);
            this.splitContainer1.Panel1.Controls.Add(this.txtMusteriNo);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwMusteriler);
            this.splitContainer1.Size = new System.Drawing.Size(834, 522);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.Navy;
            this.lStandart6.Location = new System.Drawing.Point(346, 169);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(130, 20);
            this.lStandart6.TabIndex = 41;
            this.lStandart6.Text = "Arama Kategorisi";
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Mahalleye Göre Sırala",
            "İsme Göre Sırala"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(498, 164);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(234, 31);
            this.cmbIslemTuru.TabIndex = 40;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.DarkOrange;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeniMusteri.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMusteri.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniMusteri.ForeColor = System.Drawing.Color.White;
            this.btnYeniMusteri.Image = global::BarkodluSatis.Properties.Resources.Ekle24;
            this.btnYeniMusteri.Location = new System.Drawing.Point(736, 136);
            this.btnYeniMusteri.Margin = new System.Windows.Forms.Padding(1);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(80, 62);
            this.btnYeniMusteri.TabIndex = 39;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // txtMahalle
            // 
            this.txtMahalle.BackColor = System.Drawing.Color.White;
            this.txtMahalle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMahalle.Location = new System.Drawing.Point(465, 61);
            this.txtMahalle.Name = "txtMahalle";
            this.txtMahalle.Size = new System.Drawing.Size(226, 30);
            this.txtMahalle.TabIndex = 38;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(465, 32);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(226, 20);
            this.txtTelefon.TabIndex = 37;
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.BackColor = System.Drawing.Color.White;
            this.txtMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMusteriAra.Location = new System.Drawing.Point(108, 169);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(226, 26);
            this.txtMusteriAra.TabIndex = 33;
            this.txtMusteriAra.TextChanged += new System.EventHandler(this.txtMusteriAra_TextChanged);
            // 
            // txtMusteriSayisi
            // 
            this.txtMusteriSayisi.BackColor = System.Drawing.Color.White;
            this.txtMusteriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMusteriSayisi.Location = new System.Drawing.Point(576, 104);
            this.txtMusteriSayisi.Name = "txtMusteriSayisi";
            this.txtMusteriSayisi.ReadOnly = true;
            this.txtMusteriSayisi.Size = new System.Drawing.Size(115, 26);
            this.txtMusteriSayisi.TabIndex = 35;
            this.txtMusteriSayisi.TabStop = false;
            this.txtMusteriSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart10
            // 
            this.lStandart10.AutoSize = true;
            this.lStandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart10.ForeColor = System.Drawing.Color.Navy;
            this.lStandart10.Location = new System.Drawing.Point(464, 107);
            this.lStandart10.Name = "lStandart10";
            this.lStandart10.Size = new System.Drawing.Size(106, 20);
            this.lStandart10.TabIndex = 34;
            this.lStandart10.Text = "Müşteri Sayısı";
            // 
            // lStandart9
            // 
            this.lStandart9.AutoSize = true;
            this.lStandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart9.ForeColor = System.Drawing.Color.Navy;
            this.lStandart9.Location = new System.Drawing.Point(12, 172);
            this.lStandart9.Name = "lStandart9";
            this.lStandart9.Size = new System.Drawing.Size(90, 20);
            this.lStandart9.TabIndex = 32;
            this.lStandart9.Text = "Müşteri Ara";
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
            this.btnKaydet.Location = new System.Drawing.Point(736, 76);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 58);
            this.btnKaydet.TabIndex = 24;
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
            this.btnİptal.Location = new System.Drawing.Point(736, 16);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(1);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(80, 54);
            this.btnİptal.TabIndex = 27;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.Navy;
            this.lStandart5.Location = new System.Drawing.Point(386, 61);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(64, 20);
            this.lStandart5.TabIndex = 25;
            this.lStandart5.Text = "Mahalle";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.White;
            this.txtSoyad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(156, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(226, 30);
            this.txtSoyad.TabIndex = 17;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.White;
            this.txtAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(156, 66);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(226, 30);
            this.txtAd.TabIndex = 14;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.BackColor = System.Drawing.Color.White;
            this.txtMusteriNo.Enabled = false;
            this.txtMusteriNo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(156, 30);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(226, 30);
            this.txtMusteriNo.TabIndex = 13;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.Navy;
            this.lStandart4.Location = new System.Drawing.Point(388, 30);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(62, 20);
            this.lStandart4.TabIndex = 18;
            this.lStandart4.Text = "Telefon";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.Navy;
            this.lStandart3.Location = new System.Drawing.Point(87, 112);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(54, 20);
            this.lStandart3.TabIndex = 16;
            this.lStandart3.Text = "Soyad";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.Navy;
            this.lStandart2.Location = new System.Drawing.Point(104, 76);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(29, 20);
            this.lStandart2.TabIndex = 15;
            this.lStandart2.Text = "Ad";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.Navy;
            this.lStandart1.Location = new System.Drawing.Point(56, 35);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(85, 20);
            this.lStandart1.TabIndex = 12;
            this.lStandart1.Text = "Müşteri No";
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.AllowUserToAddRows = false;
            this.dgwMusteriler.AllowUserToDeleteRows = false;
            this.dgwMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteriler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMusteriler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwMusteriler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMusteriler.EnableHeadersVisualStyles = false;
            this.dgwMusteriler.Location = new System.Drawing.Point(0, 0);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.ReadOnly = true;
            this.dgwMusteriler.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMusteriler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMusteriler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgwMusteriler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgwMusteriler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwMusteriler.RowTemplate.Height = 32;
            this.dgwMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMusteriler.Size = new System.Drawing.Size(834, 314);
            this.dgwMusteriler.TabIndex = 21;
            this.dgwMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGösterToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.ödemeAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // detayGösterToolStripMenuItem
            // 
            this.detayGösterToolStripMenuItem.Name = "detayGösterToolStripMenuItem";
            this.detayGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detayGösterToolStripMenuItem.Text = "Detay Göster";
            this.detayGösterToolStripMenuItem.Click += new System.EventHandler(this.detayGösterToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.barkodDbDataSet;
            // 
            // barkodDbDataSet
            // 
            this.barkodDbDataSet.DataSetName = "BarkodDbDataSet";
            this.barkodDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            this.ödemeAlToolStripMenuItem.Click += new System.EventHandler(this.ödemeAlToolStripMenuItem_Click);
            // 
            // FrmMusteriBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 522);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMusteriBilgi";
            this.Text = "MÜŞTERİ BİLGİ";
            this.Load += new System.EventHandler(this.FrmMusteriBilgi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkodDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private bStandart btnKaydet;
        private bStandart btnİptal;
        private lStandart lStandart5;
        private tStandart txtSoyad;
        private tStandart txtAd;
        internal tStandart txtMusteriNo;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private lStandart lStandart2;
        private lStandart lStandart1;
        private gridOzel dgwMusteriler;
        private tStandart txtMusteriAra;
        private tNumeric txtMusteriSayisi;
        private lStandart lStandart10;
        private lStandart lStandart9;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private tStandart txtMahalle;
        private BarkodDbDataSet barkodDbDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private BarkodDbDataSetTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private bStandart btnYeniMusteri;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private lStandart lStandart6;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
    }
}