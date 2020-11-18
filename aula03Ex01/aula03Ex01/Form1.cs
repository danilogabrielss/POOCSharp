using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SomaQuadrados soma = new SomaQuadrados();
            soma.N1 = Convert.ToDouble(primeiroTextBox.Text);
            soma.N2 = Convert.ToDouble(segundoTextBox.Text);
            soma.N3 = Convert.ToDouble(terceiroTextBox.Text);
            labelResultado.Text = soma.CalcularSomaQuadrados();
        }
    }
}
