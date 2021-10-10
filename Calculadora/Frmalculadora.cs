using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharpInicio.Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }
       // double Numero1, Numero2, Resultados;


        private void btnSuma_Click(object sender, EventArgs e)
        {
            string operador = "+";
            formula(operador);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            string operador = "-";
            formula(operador);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            string operador = "*";
            formula(operador);
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
        }

        private void lblNameUser_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string operador = "/";
            formula(operador);
        }

        void formula(String operador)
        {
            double Numero1 = 0, Numero2 = 0, Resultados=0;
            switch (operador)
            {
                case "+":
                    txtNum1.Text = txtNum1.Text.Replace(",", ".");
                    txtNum2.Text = txtNum2.Text.Replace(",", ".");

                    Numero1 = Convert.ToDouble(txtNum1.Text);
                    Numero2 = Convert.ToDouble(txtNum2.Text);

                    Resultados = Numero1 + Numero2;

                    lblResultado.Text = Convert.ToString(Resultados);
                    break;

               case "-":
                    txtNum1.Text = txtNum1.Text.Replace(",", ".");
                    txtNum2.Text = txtNum2.Text.Replace(",", ".");
                    
                    Numero1 = Convert.ToDouble(txtNum1.Text);
                    Numero2 = Convert.ToDouble(txtNum2.Text);

                    Resultados = Numero1 - Numero2;

                    lblResultado.Text = Convert.ToString(Resultados);
                    break;

               case "*":
                    txtNum1.Text = txtNum1.Text.Replace(",", ".");
                    txtNum2.Text = txtNum2.Text.Replace(",", ".");

                    Numero1 = Convert.ToDouble(txtNum1.Text);
                    Numero2 = Convert.ToDouble(txtNum2.Text);

                    Resultados = Numero1 * Numero2;

                    lblResultado.Text = Convert.ToString(Resultados);
                    break;

               case "/":
                    txtNum1.Text = txtNum1.Text.Replace(",", ".");
                    txtNum2.Text = txtNum2.Text.Replace(",", ".");

                    Numero1 = Convert.ToDouble(txtNum1.Text);
                    Numero2 = Convert.ToDouble(txtNum2.Text);

                    Resultados = Numero1 / Numero2;

                    lblResultado.Text = Convert.ToString(Resultados);
                    break;
            }

        }
    }
}
