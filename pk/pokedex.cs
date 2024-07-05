using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pk
{
    internal class Pokedex
    {
        public Pokedex()
        {
            this.Inicia();
        }
        private List<Pokemonplus> pokemons;

        public List<Pokemonplus> Pokemons
        {
            get { return pokemons; }//os usuarios apenas poderao ler/pegar os dados (adues set)

        }
        private void Inicia()
        {
            //instanciar lista
            this.pokemons = new List<Pokemonplus>();
            Pokemonplus p = new Pokemonplus("bulbasauro", "sua descrçao", 100);//sobrecarga + 1? ignifica que vc possui uma com e outra sem parametro      
            this.pokemons.Add(p);
            p = new Pokemonplus("1", "fudido", 60);
            this.pokemons.Add(p);
            p = new Pokemonplus("2", "cuzudo", 70);
            this.pokemons.Add(p);
            p = new Pokemonplus("3", "leitoso", 2);
            this.pokemons.Add(p);
            p = new Pokemonplus("4", "azarado", 40);
            this.pokemons.Add(p);
            p = new Pokemonplus("5", "lascado", 88);
            this.pokemons.Add(p);
            p = new Pokemonplus("6", "pirocudo", 10);
            this.pokemons.Add(p);
            p = new Pokemonplus("7", "arrombado", 70);
            this.pokemons.Add(p);
            p = new Pokemonplus("8", "zZz", 44);
            this.pokemons.Add(p);
            p = new Pokemonplus("9", "to sem criatividade", 77);
            this.pokemons.Add(p);
            p = new Pokemonplus("10", "fumante", 20);
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.pokemons.Count; i++)//o valor de "0" fara com que o for percorra a lista inteira
            {
                Console.WriteLine("codigo do pokemon " + i);
                this.Pokemons[i].exibir();
                //   pokemon p = this.pokemons[i];
                //  p.exibir();
            }

        }
    }
}
