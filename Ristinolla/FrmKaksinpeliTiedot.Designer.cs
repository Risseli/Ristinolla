namespace Ristinolla
{
    partial class FrmKaksinpeliTiedot
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
            this.lblPelaaja1Tiedot = new System.Windows.Forms.Label();
            this.lblPelaaja2Tiedot = new System.Windows.Forms.Label();
            this.tbEtunimiPelaaja1 = new System.Windows.Forms.TextBox();
            this.tbSukunimiPelaaja1 = new System.Windows.Forms.TextBox();
            this.lblPelaaja1Etunimi = new System.Windows.Forms.Label();
            this.lblPelaaja1Sukunimi = new System.Windows.Forms.Label();
            this.lblPelaaja2Sukunimi = new System.Windows.Forms.Label();
            this.lblPelaaja2Etunimi = new System.Windows.Forms.Label();
            this.tbSukunimiPelaaja2 = new System.Windows.Forms.TextBox();
            this.tbEtunimiPelaaja2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudP1 = new System.Windows.Forms.NumericUpDown();
            this.nudP2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPelaaja1Tiedot
            // 
            this.lblPelaaja1Tiedot.AutoSize = true;
            this.lblPelaaja1Tiedot.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1Tiedot.Location = new System.Drawing.Point(31, 23);
            this.lblPelaaja1Tiedot.Name = "lblPelaaja1Tiedot";
            this.lblPelaaja1Tiedot.Size = new System.Drawing.Size(219, 23);
            this.lblPelaaja1Tiedot.TabIndex = 3;
            this.lblPelaaja1Tiedot.Text = "Anna pelaajan 1 tiedot";
            this.lblPelaaja1Tiedot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPelaaja2Tiedot
            // 
            this.lblPelaaja2Tiedot.AutoSize = true;
            this.lblPelaaja2Tiedot.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2Tiedot.Location = new System.Drawing.Point(318, 23);
            this.lblPelaaja2Tiedot.Name = "lblPelaaja2Tiedot";
            this.lblPelaaja2Tiedot.Size = new System.Drawing.Size(219, 23);
            this.lblPelaaja2Tiedot.TabIndex = 4;
            this.lblPelaaja2Tiedot.Text = "Anna pelaajan 2 tiedot";
            this.lblPelaaja2Tiedot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEtunimiPelaaja1
            // 
            this.tbEtunimiPelaaja1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEtunimiPelaaja1.Location = new System.Drawing.Point(22, 104);
            this.tbEtunimiPelaaja1.Name = "tbEtunimiPelaaja1";
            this.tbEtunimiPelaaja1.Size = new System.Drawing.Size(213, 32);
            this.tbEtunimiPelaaja1.TabIndex = 0;
            this.tbEtunimiPelaaja1.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimiPelaaja1_Validating);
            this.tbEtunimiPelaaja1.Validated += new System.EventHandler(this.tbEtunimiPelaaja1_Validated);
            // 
            // tbSukunimiPelaaja1
            // 
            this.tbSukunimiPelaaja1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSukunimiPelaaja1.Location = new System.Drawing.Point(22, 176);
            this.tbSukunimiPelaaja1.Name = "tbSukunimiPelaaja1";
            this.tbSukunimiPelaaja1.Size = new System.Drawing.Size(213, 32);
            this.tbSukunimiPelaaja1.TabIndex = 1;
            this.tbSukunimiPelaaja1.Validating += new System.ComponentModel.CancelEventHandler(this.tbSukunimiPelaaja1_Validating);
            this.tbSukunimiPelaaja1.Validated += new System.EventHandler(this.tbEtunimiPelaaja1_Validated);
            // 
            // lblPelaaja1Etunimi
            // 
            this.lblPelaaja1Etunimi.AutoSize = true;
            this.lblPelaaja1Etunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1Etunimi.Location = new System.Drawing.Point(18, 81);
            this.lblPelaaja1Etunimi.Name = "lblPelaaja1Etunimi";
            this.lblPelaaja1Etunimi.Size = new System.Drawing.Size(82, 23);
            this.lblPelaaja1Etunimi.TabIndex = 7;
            this.lblPelaaja1Etunimi.Text = "etunimi";
            this.lblPelaaja1Etunimi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPelaaja1Etunimi.Visible = false;
            // 
            // lblPelaaja1Sukunimi
            // 
            this.lblPelaaja1Sukunimi.AutoSize = true;
            this.lblPelaaja1Sukunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1Sukunimi.Location = new System.Drawing.Point(18, 153);
            this.lblPelaaja1Sukunimi.Name = "lblPelaaja1Sukunimi";
            this.lblPelaaja1Sukunimi.Size = new System.Drawing.Size(97, 23);
            this.lblPelaaja1Sukunimi.TabIndex = 8;
            this.lblPelaaja1Sukunimi.Text = "sukunimi";
            this.lblPelaaja1Sukunimi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPelaaja1Sukunimi.Visible = false;
            // 
            // lblPelaaja2Sukunimi
            // 
            this.lblPelaaja2Sukunimi.AutoSize = true;
            this.lblPelaaja2Sukunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2Sukunimi.Location = new System.Drawing.Point(318, 153);
            this.lblPelaaja2Sukunimi.Name = "lblPelaaja2Sukunimi";
            this.lblPelaaja2Sukunimi.Size = new System.Drawing.Size(97, 23);
            this.lblPelaaja2Sukunimi.TabIndex = 12;
            this.lblPelaaja2Sukunimi.Text = "sukunimi";
            this.lblPelaaja2Sukunimi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPelaaja2Sukunimi.Visible = false;
            // 
            // lblPelaaja2Etunimi
            // 
            this.lblPelaaja2Etunimi.AutoSize = true;
            this.lblPelaaja2Etunimi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2Etunimi.Location = new System.Drawing.Point(318, 81);
            this.lblPelaaja2Etunimi.Name = "lblPelaaja2Etunimi";
            this.lblPelaaja2Etunimi.Size = new System.Drawing.Size(82, 23);
            this.lblPelaaja2Etunimi.TabIndex = 11;
            this.lblPelaaja2Etunimi.Text = "etunimi";
            this.lblPelaaja2Etunimi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPelaaja2Etunimi.Visible = false;
            // 
            // tbSukunimiPelaaja2
            // 
            this.tbSukunimiPelaaja2.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSukunimiPelaaja2.Location = new System.Drawing.Point(322, 176);
            this.tbSukunimiPelaaja2.Name = "tbSukunimiPelaaja2";
            this.tbSukunimiPelaaja2.Size = new System.Drawing.Size(213, 32);
            this.tbSukunimiPelaaja2.TabIndex = 4;
            this.tbSukunimiPelaaja2.Validating += new System.ComponentModel.CancelEventHandler(this.tbSukunimiPelaaja2_Validating);
            this.tbSukunimiPelaaja2.Validated += new System.EventHandler(this.tbSukunimiPelaaja2_Validated);
            // 
            // tbEtunimiPelaaja2
            // 
            this.tbEtunimiPelaaja2.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEtunimiPelaaja2.Location = new System.Drawing.Point(322, 104);
            this.tbEtunimiPelaaja2.Name = "tbEtunimiPelaaja2";
            this.tbEtunimiPelaaja2.Size = new System.Drawing.Size(213, 32);
            this.tbEtunimiPelaaja2.TabIndex = 3;
            this.tbEtunimiPelaaja2.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimiPelaaja2_Validating);
            this.tbEtunimiPelaaja2.Validated += new System.EventHandler(this.tbEtunimiPelaaja2_Validated);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(22, 308);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 37);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudP1
            // 
            this.nudP1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudP1.Location = new System.Drawing.Point(22, 238);
            this.nudP1.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudP1.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudP1.Name = "nudP1";
            this.nudP1.Size = new System.Drawing.Size(213, 32);
            this.nudP1.TabIndex = 2;
            this.nudP1.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudP1.Enter += new System.EventHandler(this.nudP1_Enter);
            // 
            // nudP2
            // 
            this.nudP2.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudP2.Location = new System.Drawing.Point(322, 238);
            this.nudP2.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudP2.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudP2.Name = "nudP2";
            this.nudP2.Size = new System.Drawing.Size(213, 32);
            this.nudP2.TabIndex = 6;
            this.nudP2.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudP2.Enter += new System.EventHandler(this.nudP2_Enter);
            // 
            // FrmKaksinpeliTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 367);
            this.ControlBox = false;
            this.Controls.Add(this.nudP2);
            this.Controls.Add(this.nudP1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPelaaja2Sukunimi);
            this.Controls.Add(this.lblPelaaja2Etunimi);
            this.Controls.Add(this.tbSukunimiPelaaja2);
            this.Controls.Add(this.tbEtunimiPelaaja2);
            this.Controls.Add(this.lblPelaaja1Sukunimi);
            this.Controls.Add(this.lblPelaaja1Etunimi);
            this.Controls.Add(this.tbSukunimiPelaaja1);
            this.Controls.Add(this.tbEtunimiPelaaja1);
            this.Controls.Add(this.lblPelaaja2Tiedot);
            this.Controls.Add(this.lblPelaaja1Tiedot);
            this.Name = "FrmKaksinpeliTiedot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaksinpeli";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPelaaja1Tiedot;
        private System.Windows.Forms.Label lblPelaaja2Tiedot;
        private System.Windows.Forms.TextBox tbEtunimiPelaaja1;
        private System.Windows.Forms.TextBox tbSukunimiPelaaja1;
        private System.Windows.Forms.Label lblPelaaja1Etunimi;
        private System.Windows.Forms.Label lblPelaaja1Sukunimi;
        private System.Windows.Forms.Label lblPelaaja2Sukunimi;
        private System.Windows.Forms.Label lblPelaaja2Etunimi;
        private System.Windows.Forms.TextBox tbSukunimiPelaaja2;
        private System.Windows.Forms.TextBox tbEtunimiPelaaja2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudP2;
        private System.Windows.Forms.NumericUpDown nudP1;
    }
}