namespace Ristinolla
{
    partial class FrmTiedot
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
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPelaaja1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudSyntymaVuosi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSyntymaVuosi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEtunimi.Location = new System.Drawing.Point(150, 89);
            this.tbEtunimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(164, 32);
            this.tbEtunimi.TabIndex = 0;
            this.tbEtunimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimi_Validating);
            this.tbEtunimi.Validated += new System.EventHandler(this.tbEtunimi_Validated);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSukunimi.Location = new System.Drawing.Point(147, 140);
            this.tbSukunimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(164, 32);
            this.tbSukunimi.TabIndex = 1;
            this.tbSukunimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbSukunimi_Validating);
            this.tbSukunimi.Validated += new System.EventHandler(this.tbSukunimi_Validated);
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimi.Location = new System.Drawing.Point(25, 89);
            this.lblEtunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(86, 23);
            this.lblEtunimi.TabIndex = 3;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(22, 151);
            this.lblSukunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(101, 23);
            this.lblSukunimi.TabIndex = 4;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(26, 248);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 37);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPelaaja1
            // 
            this.lblPelaaja1.AutoSize = true;
            this.lblPelaaja1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1.Location = new System.Drawing.Point(36, 29);
            this.lblPelaaja1.Name = "lblPelaaja1";
            this.lblPelaaja1.Size = new System.Drawing.Size(206, 23);
            this.lblPelaaja1.TabIndex = 6;
            this.lblPelaaja1.Text = "Syötä pelaajan tiedot";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudSyntymaVuosi
            // 
            this.nudSyntymaVuosi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSyntymaVuosi.Location = new System.Drawing.Point(147, 196);
            this.nudSyntymaVuosi.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudSyntymaVuosi.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudSyntymaVuosi.Name = "nudSyntymaVuosi";
            this.nudSyntymaVuosi.Size = new System.Drawing.Size(168, 32);
            this.nudSyntymaVuosi.TabIndex = 2;
            this.nudSyntymaVuosi.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudSyntymaVuosi.Enter += new System.EventHandler(this.nudSyntymaVuosi_Enter);
            this.nudSyntymaVuosi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudSyntymaVuosi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Syntymävuosi";
            // 
            // FrmTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 308);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSyntymaVuosi);
            this.Controls.Add(this.lblPelaaja1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTiedot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelaajan tiedot";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSyntymaVuosi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPelaaja1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudSyntymaVuosi;
        private System.Windows.Forms.Label label1;
    }
}