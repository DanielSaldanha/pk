using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pk
{
    public class Pokemonplus : Pokemon
    {
        public Pokemonplus() : base()
        {
            this.poder = 0;
        }
        public Pokemonplus(string nome, string descricao, int Poder) : base() 
        {
            this.poder = Poder;
        }
        public int poder { get; set; }
        public void exibirplus()
        {
            Console.WriteLine("nome pokemon: " + this.Nome);
            Console.WriteLine("descriçao pokemon: " + this.Descricao);
            Console.WriteLine("poder" + this.poder);
        }
    }
}

