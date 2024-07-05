using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pk = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                Console.Clear();
                if (resp == 1)
                {
                    pk.ListarPokemons();
                }
                if (resp == 2)
                {
                    pk.ListarPokemons();
                    Console.WriteLine("digite o codigo pukemon: ");
                    int codigo = int.Parse(Console.ReadLine());
                    //pegar pokemon do player
                    Pokemonplus player = pk.Pokemons[codigo];
                    //definir pokemon do pc
                    Random r = new Random();
                    codigo = r.Next(0, pk.Pokemons.Count);
                    Pokemonplus pc = pk.Pokemons[codigo];
                    //batalhar
                    if (player.poder >= pc.poder)
                    {
                        Console.WriteLine("eeebaaaaa vc ganhooooouuuuuu");
                    }
                    else
                    {
                        Console.WriteLine("naaaao vc perdeeeeuuuuuuuuuuu ahhhhhh");
                    }
                }

            }

            Console.ReadLine();
            Console.Clear();
        }
        static int Menu()
        {
            Console.WriteLine("batalha pikamon");
            Console.WriteLine("0 sair");
            Console.WriteLine("1 listar");
            Console.WriteLine("2 - batalhar");
            Console.WriteLine("o que deseja fazer: ");
            int resp = int.Parse(Console.ReadLine());
            return resp;
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////
   
}
