using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2Ex1
{
    public partial class Form1 : Form
    {
        Retangulo volume = new Retangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = volume.CalcularVolume();
        }
    }
}
