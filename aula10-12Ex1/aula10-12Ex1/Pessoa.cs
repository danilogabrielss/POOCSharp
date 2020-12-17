using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula10_12Ex1
{
    class Pessoa
    {
        //Atributos
        private string nome;
        private string telefone;

        //Construtor
        public Pessoa()
        {
            name = " ";
            tel = "(12)3456-7890";
        }
        // Propriedades
        public string name
        {
            get { return nome; }
            set { nome = value; }
        }
        public string tel
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public class Amigo : Pessoa
        {
            //Atributos
            private string local;
            private double anoDeConhecimento;

            //Construtor
            public Amigo()
            {
                lugar = " ";
                ano = 0;
            }
            //Propriedades
            public string lugar
            {
                get { return local; }
                set { local = value; }
            }
            public double ano
            {
                get { return anoDeConhecimento; }
                set { anoDeConhecimento = value; }
            }
        }
        public class Colega : Pessoa
        {
            //Atributos
            private string localDeTrabalho;
            private string profissao;

            //Consturtor
            public Colega()
            {
                local = "";
                profissa = "";
            }

            //Propriedades
            public string local
            {
                get { return localDeTrabalho; }
                set { localDeTrabalho = value; }
            }
            public string profissa
            {
                get { return profissao; }
                set { profissao = value; }
            }
        }
    }
}
