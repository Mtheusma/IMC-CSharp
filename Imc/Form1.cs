using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
{
    public partial class lblStatus : Form
    {
        public lblStatus()
        {
            InitializeComponent();
        }

        private void grbOperacao_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;
            if (txtPeso.Text != "" && txtAltura.Text != "")
            {
                n1 = double.Parse(txtPeso.Text);
                n2 = double.Parse(txtAltura.Text);
            }
            resultado = n1 / Math.Pow(n2, 2);

            // Verificar as opcoes:

            if (resultado <= 18.5)
            {
                lblImc.Text = resultado.ToString();
                lblResultados.Text = "abaixo do peso";

            }
            else if (resultado > 18.5 && resultado <= 24.9)
            {
                lblImc.Text = resultado.ToString();
                lblResultados.Text = "peso ideal";
            }
            else if (resultado > 25 && resultado <= 29.9)
            {
                lblImc.Text = resultado.ToString();
                lblResultados.Text = "levemente acima do peso";
            }
            else if (resultado > 30 && resultado <= 34.9)
            {
                lblImc.Text = resultado.ToString();
                lblResultados.Text = "obesidade primeiro grau";
            }
            else if (resultado < 35 && resultado <= 39.9)
            {
                lblImc.Text = resultado.ToString();
                lblResultados.Text = "obesidade segundo grau (severa)";
            }
            else
            {
                lblImc.Text = resultado.ToString();
                lblResultados.Text = "obesidade terceiro grau(mórbida)";
            }




        }

        private void lblImc_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblResultados_Click(object sender, EventArgs e)
        {

        }
    }
}
