namespace BarkodluSatis
{
    partial class FrmMusteriDetayGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriDetayGoster));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblAd = new BarkodluSatis.lStandart();
            this.lblMusteriNo = new BarkodluSatis.lStandart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwMusteri = new BarkodluSatis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblAd);
            this.splitContainer1.Panel1.Controls.Add(this.lblMusteriNo);
            this.splitContainer1.Panel1.Enabled = false;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwMusteri);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAd.ForeColor = System.Drawing.Color.Navy;
            this.lblAd.Location = new System.Drawing.Point(120, 7);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(83, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "lStandart1";
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMusteriNo.ForeColor = System.Drawing.Color.Navy;
            this.lblMusteriNo.Location = new System.Drawing.Point(16, 7);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(83, 20);
            this.lblMusteriNo.TabIndex = 0;
            this.lblMusteriNo.Text = "lStandart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGösterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // detayGösterToolStripMenuItem
            // 
            this.detayGösterToolStripMenuItem.Name = "detayGösterToolStripMenuItem";
            this.detayGösterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.detayGösterToolStripMenuItem.Text = "Detay Göster";
            this.detayGösterToolStripMenuItem.Click += new System.EventHandler(this.detayGösterToolStripMenuItem_Click);
            // 
            // dgwMusteri
            // 
            this.dgwMusteri.AllowUserToAddRows = false;
            this.dgwMusteri.AllowUserToDeleteRows = false;
            this.dgwMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteri.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwMusteri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMusteri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMusteri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteri.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwMusteri.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMusteri.EnableHeadersVisualStyles = false;
            this.dgwMusteri.Location = new System.Drawing.Point(0, 0);
            this.dgwMusteri.Name = "dgwMusteri";
            this.dgwMusteri.ReadOnly = true;
            this.dgwMusteri.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMusteri.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMusteri.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgwMusteri.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgwMusteri.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwMusteri.RowTemplate.Height = 32;
            this.dgwMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMusteri.Size = new System.Drawing.Size(800, 390);
            this.dgwMusteri.TabIndex = 23;
            // 
            // FrmMusteriDetayGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMusteriDetayGoster";
            this.Text = "MÜŞTERİ DETAY ";
            this.Load += new System.EventHandler(this.FrmMusteriDetayGoster_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private lStandart lblMusteriNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayGösterToolStripMenuItem;
        private lStandart lblAd;
        private gridOzel dgwMusteri;
    }
}