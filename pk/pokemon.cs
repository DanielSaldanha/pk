using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pk
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        public Pokemon(string nome, string dc)
        {
            this.Nome = nome;
            this.Descricao = dc;
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                string texto = value;
                nome = texto;
            }
        }
        private string dc;//armazena o valor da propriedade descriçao

        public string Descricao//representa as caracteristicas, descriçao do pokemon
        {
            get { return dc; }
            set
            {
                this.dc = value;
            }
        }
        public void exibir()//sem parametro
        {
            Console.WriteLine("nome pokemon: " + this.Nome);
            Console.WriteLine("descriçao pokemon: " + this.Descricao);

        }
        public void exibir(Boolean formatado)//com parametro
        {

            if (formatado == true)
            {
                Console.WriteLine("nome pokemon: " + this.Nome + " " + this.Descricao.ToLower());
            }
            else
            {
                Console.WriteLine("nome pokemon: " + this.Nome);
                Console.WriteLine("descriçao pokemon: " + this.Descricao);
            }





        }
    }
}
