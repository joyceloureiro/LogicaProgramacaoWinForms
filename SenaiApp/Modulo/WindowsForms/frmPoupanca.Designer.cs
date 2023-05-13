namespace WindowsForms
{
    partial class frmPoupanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoupanca));
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicial = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.lblPoupar = new System.Windows.Forms.Label();
            this.txtPoupar = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcule o rendimento de um determinado valor na poupança";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.Location = new System.Drawing.Point(90, 57);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(69, 16);
            this.lblInicial.TabIndex = 1;
            this.lblInicial.Text = "Valor inicial";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(93, 86);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(148, 20);
            this.txtInicial.TabIndex = 2;
            // 
            // lblPoupar
            // 
            this.lblPoupar.AutoSize = true;
            this.lblPoupar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoupar.Location = new System.Drawing.Point(324, 57);
            this.lblPoupar.Name = "lblPoupar";
            this.lblPoupar.Size = new System.Drawing.Size(151, 16);
            this.lblPoupar.TabIndex = 5;
            this.lblPoupar.Text = "Poupar por quantos meses:";
            // 
            // txtPoupar
            // 
            this.txtPoupar.Location = new System.Drawing.Point(327, 86);
            this.txtPoupar.Name = "txtPoupar";
            this.txtPoupar.Size = new System.Drawing.Size(148, 20);
            this.txtPoupar.TabIndex = 6;
            // 
            // bntCalcular
            // 
            this.bntCalcular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bntCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcular.Location = new System.Drawing.Point(221, 130);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(118, 32);
            this.bntCalcular.TabIndex = 0;
            this.bntCalcular.Text = "CALCULAR";
            this.bntCalcular.UseVisualStyleBackColor = false;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalculaRendimento_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Green;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(40, 218);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "RESULTADO";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 283);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.txtPoupar);
            this.Controls.Add(this.lblPoupar);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.label1);
            this.Name = "frmPoupanca";
            this.Text = "frmPoupanca";
            this.Load += new System.EventHandler(this.frmPoupanca_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.Label lblPoupar;
        private System.Windows.Forms.TextBox txtPoupar;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}