using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmPoupanca : Form
    {
        public frmPoupanca()
        {
            InitializeComponent();
        }

        private void frmPoupanca_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bntCalculaRendimento_Click(object sender, EventArgs e)
        {
            var valorNaConta = double.Parse(txtInicial.Text);
            const double indice = 0.005;
            lblResultado.Text = (valorNaConta * indice).ToString();

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
