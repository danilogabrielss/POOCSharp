using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula10_12Ex2
{
    class Propriedades
    {
        //Atributos
        private string proprietari;
        private float numeroFiscalProprietario;

        //Construtor
        public Propriedades()
        {
            numeroFiscalProprietario = 0;
            proprietari = "";
        }

        //Metodo
        public void calcularRendaMinima(float area, float renda, float rendaMinima)
        {
            float p1 = 0.2f;
            float p2 = 0.3f;
            if (area < 50)
            {
                renda = 100;
            }
            else if (area < 100)
            {
                renda = 100 + p1 * area;
            }
            else
            {
                renda = 100 + p2 * area;
            }
            rendaMinima = renda;
        }

        //Getters and Setters
        public string proprietario
        {
            get { return proprietari; }
            set { proprietari  = value; }
        }
        public float numeroFiscal
        {
            get { return numeroFiscalProprietario; }
            set { numeroFiscalProprietario = value; }
        }

        //Subclasses
        public class Casa : Propriedades
        {
            //Atributos
            private string local, categoria;
            //Construtor
            public Casa()
            {
                local = "";
                categoria = "";
            }
            public void Categoria(float renda)
            {
                switch (local)
                {
                    case ("Santos"):
                        categoria = "A";
                        break;
                    case ("São Vicente"):
                        categoria = "B";
                        break;
                    case ("Guarujá"):
                        categoria = "C";
                        break;
                    case ("Campos do Jordão"):
                        categoria = "D";
                        break;
                }
                switch (categoria)
                {
                    case ("A" + "B"):
                        renda = 7000;
                        break;
                    case ("C"):
                        renda = 4000;
                        break;
                    case ("D"):
                        renda = 2000;
                        break;
                }
            }
            public string localidade
            {
                get { return local; }
                set { local = value; }
            }
            public string categ
            {
                get { return categoria; }
                set { categoria = value; }
            }
        }
        public class Apartamento : Propriedades
        {
            //Atributos
            private string tipo;
            private float areaa;

            //Construtor
            public Apartamento()
            {
                areaa = 0;
                tipo = "";
            }
            public string type
            {
                get { return tipo; }
                set { tipo = value; }
            }
            public float area
            {
                get { return areaa; }
                set { areaa = value; }
            }
        }
    }
}
