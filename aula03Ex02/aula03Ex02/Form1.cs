using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            AntecessorSucessor n1 = new AntecessorSucessor();
            n1.number = Convert.ToDouble(numeroTextBox.Text);
            labelAntecessor.Text = Convert.ToString(n1.CalcularAntecessor());
            labelSucessor.Text = Convert.ToString(n1.CalcularSucessor());
        }
    }
}
