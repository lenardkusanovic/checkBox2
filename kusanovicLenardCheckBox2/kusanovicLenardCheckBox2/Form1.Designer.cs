namespace kusanovicLenardCheckBox2
{
    partial class Form1
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
            this.chkDorucak = new System.Windows.Forms.CheckBox();
            this.chkRucak = new System.Windows.Forms.CheckBox();
            this.chkVecera = new System.Windows.Forms.CheckBox();
            this.chkSakrijiNarudzbu = new System.Windows.Forms.CheckBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkDorucak
            // 
            this.chkDorucak.AutoSize = true;
            this.chkDorucak.Location = new System.Drawing.Point(48, 58);
            this.chkDorucak.Name = "chkDorucak";
            this.chkDorucak.Size = new System.Drawing.Size(67, 17);
            this.chkDorucak.TabIndex = 0;
            this.chkDorucak.Text = "Dorucak";
            this.chkDorucak.UseVisualStyleBackColor = true;
            this.chkDorucak.CheckedChanged += new System.EventHandler(this.ChkDorucak_CheckedChanged);
            // 
            // chkRucak
            // 
            this.chkRucak.AutoSize = true;
            this.chkRucak.Location = new System.Drawing.Point(48, 130);
            this.chkRucak.Name = "chkRucak";
            this.chkRucak.Size = new System.Drawing.Size(58, 17);
            this.chkRucak.TabIndex = 1;
            this.chkRucak.Text = "Rucak";
            this.chkRucak.UseVisualStyleBackColor = true;
            this.chkRucak.CheckedChanged += new System.EventHandler(this.ChkRucak_CheckedChanged);
            // 
            // chkVecera
            // 
            this.chkVecera.AutoSize = true;
            this.chkVecera.Location = new System.Drawing.Point(48, 203);
            this.chkVecera.Name = "chkVecera";
            this.chkVecera.Size = new System.Drawing.Size(60, 17);
            this.chkVecera.TabIndex = 2;
            this.chkVecera.Text = "Vecera";
            this.chkVecera.UseVisualStyleBackColor = true;
            this.chkVecera.CheckedChanged += new System.EventHandler(this.ChkVecera_CheckedChanged);
            // 
            // chkSakrijiNarudzbu
            // 
            this.chkSakrijiNarudzbu.AutoSize = true;
            this.chkSakrijiNarudzbu.Location = new System.Drawing.Point(189, 362);
            this.chkSakrijiNarudzbu.Name = "chkSakrijiNarudzbu";
            this.chkSakrijiNarudzbu.Size = new System.Drawing.Size(103, 17);
            this.chkSakrijiNarudzbu.TabIndex = 3;
            this.chkSakrijiNarudzbu.Text = "Sakriji Narudžbu";
            this.chkSakrijiNarudzbu.UseVisualStyleBackColor = true;
            this.chkSakrijiNarudzbu.CheckedChanged += new System.EventHandler(this.ChkSakrijiNarudzbu_CheckedChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(48, 356);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.BtnPosalji_Click);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(253, 12);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(515, 320);
            this.txtPrikaz.TabIndex = 5;
            this.txtPrikaz.Text = "Odabrali ste:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.chkSakrijiNarudzbu);
            this.Controls.Add(this.chkVecera);
            this.Controls.Add(this.chkRucak);
            this.Controls.Add(this.chkDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDorucak;
        private System.Windows.Forms.CheckBox chkRucak;
        private System.Windows.Forms.CheckBox chkVecera;
        private System.Windows.Forms.CheckBox chkSakrijiNarudzbu;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtPrikaz;
    }
}

