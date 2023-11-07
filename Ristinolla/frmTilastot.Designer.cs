namespace Ristinolla
{
    partial class FrmTilastot
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
            this.dgvTilastot = new System.Windows.Forms.DataGridView();
            this.btnSulje = new System.Windows.Forms.Button();
            this.btnNollaaLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTilastot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTilastot
            // 
            this.dgvTilastot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTilastot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTilastot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTilastot.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTilastot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTilastot.Location = new System.Drawing.Point(42, 49);
            this.dgvTilastot.Name = "dgvTilastot";
            this.dgvTilastot.RowHeadersWidth = 62;
            this.dgvTilastot.RowTemplate.Height = 28;
            this.dgvTilastot.Size = new System.Drawing.Size(664, 761);
            this.dgvTilastot.TabIndex = 0;
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(793, 49);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(138, 32);
            this.btnSulje.TabIndex = 16;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // btnNollaaLista
            // 
            this.btnNollaaLista.Location = new System.Drawing.Point(793, 119);
            this.btnNollaaLista.Name = "btnNollaaLista";
            this.btnNollaaLista.Size = new System.Drawing.Size(138, 32);
            this.btnNollaaLista.TabIndex = 17;
            this.btnNollaaLista.Text = "Nollaa lista";
            this.btnNollaaLista.UseVisualStyleBackColor = true;
            this.btnNollaaLista.Click += new System.EventHandler(this.btnNollaaLista_Click);
            // 
            // FrmTilastot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 839);
            this.Controls.Add(this.btnNollaaLista);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.dgvTilastot);
            this.Name = "FrmTilastot";
            this.Text = "Pelaaja tilastot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTilastot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTilastot;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.Button btnNollaaLista;
    }
}