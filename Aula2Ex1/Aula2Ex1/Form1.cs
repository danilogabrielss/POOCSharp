﻿using System;
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
            volume.altura = Convert.ToInt32 (alturaTextBox.Text);
            volume.comprimento = Convert.ToInt32(comprimetoTextBox.Text);
            volume.largura = Convert.ToInt32(larguraTextBox.Text);            
            lblResultado.Text = volume.CalcularVolume();
        }
    }
}
