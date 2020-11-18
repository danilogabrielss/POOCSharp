using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03Ex01
{
    class SomaQuadrados
    {
        //Atributos
        private double n1;
        private double n2;
        private double n3;
        
        //Construtor
        public SomaQuadrados()
        {
            n1 = 0;
            n2 = 0;
            n3 = 0;
        }
        //Propriedades
        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }
        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }
        public double N3
        {
            get { return n3; }
            set { n3 = value; }
        }
        //Metodos
        public string CalcularSomaQuadrados()
        {
            return "A soma dos quadrados é igual a " + (n1 + n2 + n3);
        }
    }
}
