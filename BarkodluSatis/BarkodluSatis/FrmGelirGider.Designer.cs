namespace BarkodluSatis
{
    partial class FrmGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirGider));
            this.lblGelirGider = new BarkodluSatis.lStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.txtNakit = new BarkodluSatis.tNumeric();
            this.txtkart = new BarkodluSatis.tNumeric();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.txtAciklama = new BarkodluSatis.tStandart();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.bStandart1 = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // lblGelirGider
            // 
            this.lblGelirGider.AutoSize = true;
            this.lblGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGelirGider.ForeColor = System.Drawing.Color.Navy;
            this.lblGelirGider.Location = new System.Drawing.Point(23, 27);
            this.lblGelirGider.Name = "lblGelirGider";
            this.lblGelirGider.Size = new System.Drawing.Size(84, 20);
            this.lblGelirGider.TabIndex = 0;
            this.lblGelirGider.Text = "lGelirGider";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.Navy;
            this.lStandart2.Location = new System.Drawing.Point(23, 67);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(97, 20);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "Ödeme Türü";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "KART - NAKİT"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(27, 100);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(215, 31);
            this.cmbOdemeTuru.TabIndex = 2;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // txtNakit
            // 
            this.txtNakit.BackColor = System.Drawing.Color.White;
            this.txtNakit.Enabled = false;
            this.txtNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNakit.Location = new System.Drawing.Point(27, 163);
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(93, 26);
            this.txtNakit.TabIndex = 3;
            this.txtNakit.Text = "0";
            this.txtNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtkart
            // 
            this.txtkart.BackColor = System.Drawing.Color.White;
            this.txtkart.Enabled = false;
            this.txtkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtkart.Location = new System.Drawing.Point(140, 163);
            this.txtkart.Name = "txtkart";
            this.txtkart.Size = new System.Drawing.Size(102, 26);
            this.txtkart.TabIndex = 4;
            this.txtkart.Text = "0";
            this.txtkart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.Navy;
            this.lStandart3.Location = new System.Drawing.Point(23, 140);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(45, 20);
            this.lStandart3.TabIndex = 5;
            this.lStandart3.Text = "Nakit";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.Navy;
            this.lStandart4.Location = new System.Drawing.Point(136, 140);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(38, 20);
            this.lStandart4.TabIndex = 6;
            this.lStandart4.Text = "Kart";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAciklama.Location = new System.Drawing.Point(27, 223);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(226, 107);
            this.txtAciklama.TabIndex = 7;
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.Navy;
            this.lStandart5.Location = new System.Drawing.Point(23, 200);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(73, 20);
            this.lStandart5.TabIndex = 8;
            this.lStandart5.Text = "Açıklama";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(27, 356);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(226, 30);
            this.dtTarih.TabIndex = 9;
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.Navy;
            this.lStandart6.Location = new System.Drawing.Point(23, 333);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(44, 20);
            this.lStandart6.TabIndex = 10;
            this.lStandart6.Text = "Tarih";
            // 
            // bStandart1
            // 
            this.bStandart1.BackColor = System.Drawing.Color.Tomato;
            this.bStandart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bStandart1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bStandart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStandart1.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStandart1.ForeColor = System.Drawing.Color.White;
            this.bStandart1.Image = global::BarkodluSatis.Properties.Resources.Ekle24;
            this.bStandart1.Location = new System.Drawing.Point(140, 395);
            this.bStandart1.Margin = new System.Windows.Forms.Padding(1);
            this.bStandart1.Name = "bStandart1";
            this.bStandart1.Size = new System.Drawing.Size(111, 57);
            this.bStandart1.TabIndex = 0;
            this.bStandart1.Text = "Ekle";
            this.bStandart1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bStandart1.UseVisualStyleBackColor = false;
            this.bStandart1.Click += new System.EventHandler(this.bStandart1_Click);
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(291, 462);
            this.Controls.Add(this.bStandart1);
            this.Controls.Add(this.lStandart6);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.lStandart5);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lStandart4);
            this.Controls.Add(this.lStandart3);
            this.Controls.Add(this.txtkart);
            this.Controls.Add(this.txtNakit);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lStandart2);
            this.Controls.Add(this.lblGelirGider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(307, 501);
            this.MinimumSize = new System.Drawing.Size(307, 501);
            this.Name = "FrmGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GELİR GİDER İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lblGelirGider;
        private lStandart lStandart2;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private lStandart lStandart3;
        private lStandart lStandart4;
        private lStandart lStandart5;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private lStandart lStandart6;
        private bStandart bStandart1;
        internal tNumeric txtNakit;
        internal tNumeric txtkart;
        internal tStandart txtAciklama;
    }
}