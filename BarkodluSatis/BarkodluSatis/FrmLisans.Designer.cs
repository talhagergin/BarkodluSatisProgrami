namespace BarkodluSatis
{
    partial class FrmLisans
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
            this.lblKontro = new BarkodluSatis.lStandart();
            this.lblKontrolNo = new BarkodluSatis.lStandart();
            this.txtKontrolNo = new BarkodluSatis.tStandart();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKontro
            // 
            this.lblKontro.AutoSize = true;
            this.lblKontro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKontro.ForeColor = System.Drawing.Color.Navy;
            this.lblKontro.Location = new System.Drawing.Point(77, 31);
            this.lblKontro.Name = "lblKontro";
            this.lblKontro.Size = new System.Drawing.Size(111, 20);
            this.lblKontro.TabIndex = 0;
            this.lblKontro.Text = "KONTROL NO";
            // 
            // lblKontrolNo
            // 
            this.lblKontrolNo.AutoSize = true;
            this.lblKontrolNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKontrolNo.ForeColor = System.Drawing.Color.Navy;
            this.lblKontrolNo.Location = new System.Drawing.Point(89, 63);
            this.lblKontrolNo.Name = "lblKontrolNo";
            this.lblKontrolNo.Size = new System.Drawing.Size(83, 20);
            this.lblKontrolNo.TabIndex = 1;
            this.lblKontrolNo.Text = "lStandart2";
            // 
            // txtKontrolNo
            // 
            this.txtKontrolNo.BackColor = System.Drawing.Color.White;
            this.txtKontrolNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKontrolNo.Location = new System.Drawing.Point(52, 106);
            this.txtKontrolNo.Name = "txtKontrolNo";
            this.txtKontrolNo.Size = new System.Drawing.Size(164, 26);
            this.txtKontrolNo.TabIndex = 2;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(81, 150);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // FrmLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 250);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtKontrolNo);
            this.Controls.Add(this.lblKontrolNo);
            this.Controls.Add(this.lblKontro);
            this.Name = "FrmLisans";
            this.Text = "FrmLisans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lblKontro;
        private tStandart txtKontrolNo;
        internal lStandart lblKontrolNo;
        private System.Windows.Forms.Button btnTamam;
    }
}