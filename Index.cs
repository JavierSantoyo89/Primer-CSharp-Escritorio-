using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpInicio.Calculadora;
using CSharpInicio.OperadoresRelacionales;

namespace CSharpInicio
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString();
            lblDate.Text = fecha;
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCalculadora frmCalc= new FrmCalculadora();
            frmCalc.lblNameUser.Text = txtNameUser.Text;
            frmCalc.ShowDialog();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOpRel_Click(object sender, EventArgs e)
        {
            FrmOpRelacionales FrmOpRel = new FrmOpRelacionales();
            FrmOpRel.lblNameUser.Text = txtNameUser.Text;
            FrmOpRel.ShowDialog();
            this.Hide();

        }
    }
}
