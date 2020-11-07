using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1ex2
{
    class aula1Ex2
    {
        public int catetoOposto, catetoAdj, hipotenusa;      

        public string CalcularTriangulo()
        {
            if (catetoAdj == catetoOposto && catetoAdj == hipotenusa)
            {
                return "Triangulo Equilatero";
            }
            else
            {
                if (catetoAdj == catetoOposto || catetoAdj == hipotenusa || catetoOposto == hipotenusa)
                {
                    return "Triangulo Isósceles";
                }
                else
                {
                    if (catetoOposto < catetoAdj + hipotenusa || hipotenusa < catetoOposto + catetoAdj || catetoAdj < catetoOposto + hipotenusa)
                    {
                        return "Triangulo Escaleno";
                    }
                    else
                    {
                        return "Valores inválidos";
                    }
                }
            }
        }
    }
}
