using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1
{
    public partial class Form1 : Form
    {
        aula1 aula;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aula = new aula1();
            aula.altura = Convert.ToDouble(alturaTextBox.Text);
            aula.sexo = Convert.ToInt32(sexoTextBox.Text);
            lblResultado.Text = aula.CalcularPeso();
        }

    }
}