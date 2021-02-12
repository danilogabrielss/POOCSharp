using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula10_12Ex1
{
    class Pessoa
    {

        //Construtor
        public Pessoa()
        {
            name = " ";
            tel = "(12)3456-7890";
        }
        // Propriedades
        public string name { get; set; }
        public string tel { get; set; }
        public class Amigo : Pessoa
        {
            //Construtor
            public Amigo()
            {
                lugar = " ";
                ano = 0;
            }
            //Propriedades
            public string lugar { get; set; }
            public double ano { get; set; }
        }
        public class Colega : Pessoa
        {

            //Consturtor
            public Colega()
            {
                local = "";
                profissao = "";
            }

            //Propriedades
            public string local { get; set; }
            public string profissao { get; set; }
        }
    }
}
