﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10_12Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Propriedades.Casa a = new Propriedades.Casa();
            a.localidade = ("Campos do Jordão");
            a.Categoria(2000);
                        
        }        
    }
}
