namespace BarkodluSatis
{
    partial class FrmUrunGrubuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunGrubuEkle));
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.txtGrupAd = new BarkodluSatis.tStandart();
            this.lstGrup = new System.Windows.Forms.ListBox();
            this.bStandart1 = new BarkodluSatis.bStandart();
            this.btnEkle = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.Navy;
            this.lStandart1.Location = new System.Drawing.Point(85, 25);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(120, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Grubu Adı";
            // 
            // txtGrupAd
            // 
            this.txtGrupAd.BackColor = System.Drawing.Color.White;
            this.txtGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGrupAd.Location = new System.Drawing.Point(36, 59);
            this.txtGrupAd.Name = "txtGrupAd";
            this.txtGrupAd.Size = new System.Drawing.Size(226, 26);
            this.txtGrupAd.TabIndex = 1;
            // 
            // lstGrup
            // 
            this.lstGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstGrup.FormattingEnabled = true;
            this.lstGrup.ItemHeight = 20;
            this.lstGrup.Location = new System.Drawing.Point(36, 105);
            this.lstGrup.Name = "lstGrup";
            this.lstGrup.Size = new System.Drawing.Size(226, 144);
            this.lstGrup.TabIndex = 2;
            // 
            // bStandart1
            // 
            this.bStandart1.BackColor = System.Drawing.Color.LawnGreen;
            this.bStandart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bStandart1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bStandart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStandart1.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStandart1.ForeColor = System.Drawing.Color.White;
            this.bStandart1.Image = global::BarkodluSatis.Properties.Resources.clear4848;
            this.bStandart1.Location = new System.Drawing.Point(36, 266);
            this.bStandart1.Margin = new System.Windows.Forms.Padding(1);
            this.bStandart1.Name = "bStandart1";
            this.bStandart1.Size = new System.Drawing.Size(100, 52);
            this.bStandart1.TabIndex = 0;
            this.bStandart1.Text = "Sil";
            this.bStandart1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bStandart1.UseVisualStyleBackColor = false;
            this.bStandart1.Click += new System.EventHandler(this.bStandart1_Click);
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
            this.btnEkle.Location = new System.Drawing.Point(156, 266);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 52);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 375);
            this.Controls.Add(this.bStandart1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstGrup);
            this.Controls.Add(this.txtGrupAd);
            this.Controls.Add(this.lStandart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunGrubuEkle";
            this.Text = "ÜRÜN GRUBU İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private tStandart txtGrupAd;
        private System.Windows.Forms.ListBox lstGrup;
        private bStandart btnEkle;
        private bStandart bStandart1;
    }
}