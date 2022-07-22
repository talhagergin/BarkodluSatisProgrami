namespace ProgramRestore
{
    partial class FrmYedektenYukle
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
            this.txtDosyaAd = new System.Windows.Forms.TextBox();
            this.btnYedek = new System.Windows.Forms.Button();
            this.btnYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDosyaAd
            // 
            this.txtDosyaAd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaAd.Location = new System.Drawing.Point(12, 40);
            this.txtDosyaAd.Name = "txtDosyaAd";
            this.txtDosyaAd.Size = new System.Drawing.Size(310, 26);
            this.txtDosyaAd.TabIndex = 0;
            // 
            // btnYedek
            // 
            this.btnYedek.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedek.Location = new System.Drawing.Point(355, 35);
            this.btnYedek.Name = "btnYedek";
            this.btnYedek.Size = new System.Drawing.Size(120, 34);
            this.btnYedek.TabIndex = 1;
            this.btnYedek.Text = "Yedek Seç";
            this.btnYedek.UseVisualStyleBackColor = true;
            this.btnYedek.Click += new System.EventHandler(this.btnYedek_Click);
            // 
            // btnYukle
            // 
            this.btnYukle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.Location = new System.Drawing.Point(355, 75);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(120, 42);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "YÜKLE";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bu işlemi yaptığınız zaman mevcut veriler silinecek.\r\nYedeğinizdeki bilgiler yükl" +
    "enecektir !!!!!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "En son aldığınız yedeği seçiniz...\r\n";
            // 
            // FrmYedektenYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.btnYedek);
            this.Controls.Add(this.txtDosyaAd);
            this.Name = "FrmYedektenYukle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BARKODLU SATIŞ PROGRAMI YEDEKTEN YÜKLEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDosyaAd;
        private System.Windows.Forms.Button btnYedek;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

