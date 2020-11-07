using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Ex1
{
    class Retangulo
    {
        private int comprimento;
        private int altura;
        private int largura;
        private int media;

        public Retangulo(int comprimentoRetangulo, int alturaRetangulo, int larguraRetangulo, int mediaRetangulo)
        {
            comprimento = comprimentoRetangulo;
            altura = alturaRetangulo;
            largura = larguraRetangulo;
            media = mediaRetangulo;
        }
        public Retangulo()
        {
            comprimento = 0;
            altura = 0;
            largura = 0;
            media = 0;
        }

        public string CalcularVolume()
        {
            media = comprimento * altura * largura;
            return "O volume do retangulo é " + media;
        }

    }
}
