using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03Ex02
{
    class AntecessorSucessor
    {
        //Atributos
        private double numero;

        //Construtor
        public AntecessorSucessor()
        {
            numero = 0;
        }
        //Propriedades
        public double number
        {
            get { return numero; }
            set { numero = value; }
        }
        //Metodos
        public double CalcularAntecessor()
        {
            return (numero - 1);
        }
        public double CalcularSucessor()
        {
            return (numero + 1);
        }
    }
}
