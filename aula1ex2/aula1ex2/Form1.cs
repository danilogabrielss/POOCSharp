using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1ex2
{
    public partial class Form1 : Form
    {
        aula1Ex2 aula;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularTriangulo_Click(object sender, EventArgs e)
        {
            aula = new aula1Ex2();
            aula.catetoOposto = Convert.ToInt32(catetoOpostoTextBox.Text);
            aula.catetoAdj = Convert.ToInt32(catetoAdjTextBox.Text);
            aula.hipotenusa = Convert.ToInt32(hipotenusaTextBox.Text);
            lblResultado.Text = aula.CalcularTriangulo();
        }
    }
}
