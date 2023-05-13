namespace WindowsForms
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnt3 = new System.Windows.Forms.Button();
            this.bnt2 = new System.Windows.Forms.Button();
            this.btnPoupanca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(225, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema de apoio gerencial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForms.Properties.Resources.undraw_digital_currency_qpak;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bnt3
            // 
            this.bnt3.FlatAppearance.BorderSize = 0;
            this.bnt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt3.Image = ((System.Drawing.Image)(resources.GetObject("bnt3.Image")));
            this.bnt3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnt3.Location = new System.Drawing.Point(423, 144);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(102, 70);
            this.bnt3.TabIndex = 5;
            this.bnt3.Text = "Agencia Bancaria";
            this.bnt3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt3.UseVisualStyleBackColor = true;
            // 
            // bnt2
            // 
            this.bnt2.FlatAppearance.BorderSize = 0;
            this.bnt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt2.Image = ((System.Drawing.Image)(resources.GetObject("bnt2.Image")));
            this.bnt2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnt2.Location = new System.Drawing.Point(325, 144);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(83, 70);
            this.bnt2.TabIndex = 4;
            this.bnt2.Text = "Pagamentos";
            this.bnt2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt2.UseVisualStyleBackColor = true;
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.BackColor = System.Drawing.Color.White;
            this.btnPoupanca.FlatAppearance.BorderSize = 0;
            this.btnPoupanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoupanca.Image = global::WindowsForms.Properties.Resources.savings_FILL0_wght400_GRAD0_opsz48;
            this.btnPoupanca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPoupanca.Location = new System.Drawing.Point(217, 144);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(81, 70);
            this.btnPoupanca.TabIndex = 3;
            this.btnPoupanca.Text = "Poupança";
            this.btnPoupanca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPoupanca.UseVisualStyleBackColor = false;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnt3);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.btnPoupanca);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Button bnt2;
        private System.Windows.Forms.Button bnt3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

