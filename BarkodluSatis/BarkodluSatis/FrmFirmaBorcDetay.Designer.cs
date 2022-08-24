namespace BarkodluSatis
{
    partial class FrmFirmaBorcDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmaBorcDetay));
            this.dgwListe = new BarkodluSatis.gridOzel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.lblBorcNo = new BarkodluSatis.lStandart();
            this.dgwListeOdeme = new BarkodluSatis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListe
            // 
            this.dgwListe.AllowUserToAddRows = false;
            this.dgwListe.AllowUserToDeleteRows = false;
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwListe.EnableHeadersVisualStyles = false;
            this.dgwListe.Location = new System.Drawing.Point(0, 0);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.ReadOnly = true;
            this.dgwListe.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgwListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgwListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwListe.RowTemplate.Height = 32;
            this.dgwListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListe.Size = new System.Drawing.Size(595, 421);
            this.dgwListe.TabIndex = 24;
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
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            this.splitContainer1.Panel1.Controls.Add(this.lblBorcNo);
            this.splitContainer1.Panel1.Enabled = false;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwListeOdeme);
            this.splitContainer1.Panel2.Controls.Add(this.dgwListe);
            this.splitContainer1.Size = new System.Drawing.Size(1219, 481);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 5;
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.Navy;
            this.lStandart2.Location = new System.Drawing.Point(868, 27);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(209, 20);
            this.lStandart2.TabIndex = 2;
            this.lStandart2.Text = "Ödenen Borç Detay Tablosu";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.Navy;
            this.lStandart1.Location = new System.Drawing.Point(200, 27);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(169, 20);
            this.lStandart1.TabIndex = 1;
            this.lStandart1.Text = "Alınan Ürünler Tablosu";
            // 
            // lblBorcNo
            // 
            this.lblBorcNo.AutoSize = true;
            this.lblBorcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBorcNo.ForeColor = System.Drawing.Color.Navy;
            this.lblBorcNo.Location = new System.Drawing.Point(16, 7);
            this.lblBorcNo.Name = "lblBorcNo";
            this.lblBorcNo.Size = new System.Drawing.Size(83, 20);
            this.lblBorcNo.TabIndex = 0;
            this.lblBorcNo.Text = "lStandart1";
            // 
            // dgwListeOdeme
            // 
            this.dgwListeOdeme.AllowUserToAddRows = false;
            this.dgwListeOdeme.AllowUserToDeleteRows = false;
            this.dgwListeOdeme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListeOdeme.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwListeOdeme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwListeOdeme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwListeOdeme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwListeOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListeOdeme.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwListeOdeme.EnableHeadersVisualStyles = false;
            this.dgwListeOdeme.Location = new System.Drawing.Point(601, -3);
            this.dgwListeOdeme.Name = "dgwListeOdeme";
            this.dgwListeOdeme.ReadOnly = true;
            this.dgwListeOdeme.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwListeOdeme.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwListeOdeme.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgwListeOdeme.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgwListeOdeme.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwListeOdeme.RowTemplate.Height = 32;
            this.dgwListeOdeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListeOdeme.Size = new System.Drawing.Size(618, 421);
            this.dgwListeOdeme.TabIndex = 25;
            // 
            // FrmFirmaBorcDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 481);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFirmaBorcDetay";
            this.Text = "FİRMA BORÇ DETAY ";
            this.Load += new System.EventHandler(this.FrmFirmaBorcDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeOdeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private gridOzel dgwListe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private lStandart lblBorcNo;
        private gridOzel dgwListeOdeme;
        private lStandart lStandart2;
        private lStandart lStandart1;
    }
}