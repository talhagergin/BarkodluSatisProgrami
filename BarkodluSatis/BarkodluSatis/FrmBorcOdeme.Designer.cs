﻿namespace BarkodluSatis
{
    partial class FrmBorcOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorcOdeme));
            this.btnEkle = new BarkodluSatis.bStandart();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.txtAciklama = new BarkodluSatis.tStandart();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.txtkart = new BarkodluSatis.tNumeric();
            this.txtNakit = new BarkodluSatis.tNumeric();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.lblGelirGider = new BarkodluSatis.lStandart();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Tomato;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle24;
            this.btnEkle.Location = new System.Drawing.Point(83, 384);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 57);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.Navy;
            this.lStandart6.Location = new System.Drawing.Point(29, 327);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(44, 20);
            this.lStandart6.TabIndex = 22;
            this.lStandart6.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(33, 350);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(226, 30);
            this.dtTarih.TabIndex = 21;
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.Navy;
            this.lStandart5.Location = new System.Drawing.Point(29, 194);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(73, 20);
            this.lStandart5.TabIndex = 20;
            this.lStandart5.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAciklama.Location = new System.Drawing.Point(33, 217);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(226, 107);
            this.txtAciklama.TabIndex = 19;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.Navy;
            this.lStandart4.Location = new System.Drawing.Point(142, 134);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(38, 20);
            this.lStandart4.TabIndex = 18;
            this.lStandart4.Text = "Kart";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.Navy;
            this.lStandart3.Location = new System.Drawing.Point(29, 134);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(45, 20);
            this.lStandart3.TabIndex = 17;
            this.lStandart3.Text = "Nakit";
            // 
            // txtkart
            // 
            this.txtkart.BackColor = System.Drawing.Color.White;
            this.txtkart.Enabled = false;
            this.txtkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtkart.Location = new System.Drawing.Point(146, 157);
            this.txtkart.Name = "txtkart";
            this.txtkart.Size = new System.Drawing.Size(102, 26);
            this.txtkart.TabIndex = 16;
            this.txtkart.Text = "0";
            this.txtkart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNakit
            // 
            this.txtNakit.BackColor = System.Drawing.Color.White;
            this.txtNakit.Enabled = false;
            this.txtNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNakit.Location = new System.Drawing.Point(33, 157);
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(93, 26);
            this.txtNakit.TabIndex = 15;
            this.txtNakit.Text = "0";
            this.txtNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.cmbOdemeTuru.Location = new System.Drawing.Point(33, 94);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(215, 31);
            this.cmbOdemeTuru.TabIndex = 14;
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.Navy;
            this.lStandart2.Location = new System.Drawing.Point(29, 61);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(97, 20);
            this.lStandart2.TabIndex = 13;
            this.lStandart2.Text = "Ödeme Türü";
            // 
            // lblGelirGider
            // 
            this.lblGelirGider.AutoSize = true;
            this.lblGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGelirGider.ForeColor = System.Drawing.Color.Navy;
            this.lblGelirGider.Location = new System.Drawing.Point(29, 21);
            this.lblGelirGider.Name = "lblGelirGider";
            this.lblGelirGider.Size = new System.Drawing.Size(84, 20);
            this.lblGelirGider.TabIndex = 12;
            this.lblGelirGider.Text = "lGelirGider";
            // 
            // FrmBorcOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.btnEkle);
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
            this.Name = "FrmBorcOdeme";
            this.Text = "BORÇ ÖDEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bStandart btnEkle;
        private lStandart lStandart6;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private lStandart lStandart5;
        internal tStandart txtAciklama;
        private lStandart lStandart4;
        private lStandart lStandart3;
        internal tNumeric txtkart;
        internal tNumeric txtNakit;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private lStandart lStandart2;
        private lStandart lblGelirGider;
    }
}