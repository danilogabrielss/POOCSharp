using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class aula1
    {
        public double altura;
        public int sexo;

        public string CalcularPeso()
        {
            if (sexo == 1)
            {
                return "Seu peso ideal é " + ((72.7 * altura) - 58).ToString();
            }
            else
            {
                if (sexo == 2)
                {
                    return "Seu peso ideal é " + ((62.1 * altura) - 44.7).ToString();
                }
                else
                {
                    return "Valor invalido";
                }
            }
        }
    }
}
