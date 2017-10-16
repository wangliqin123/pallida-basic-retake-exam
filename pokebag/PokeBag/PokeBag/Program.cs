using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBag
{
    class Program
    {
        static void Main(string[] args)
        {
            PokeBag pokeBag = new PokeBag();

            Pikachu pikachu1 = new Pikachu();
            Pikachu pikachu2 = new Pikachu();
            Bubasaur bubasaur1 = new Bubasaur();
            Bubasaur bubasaur2 = new Bubasaur();
            Charmander charmander1 = new Charmander();

            pokeBag.Add(pikachu1);
            pokeBag.Add(pikachu2);
            pokeBag.Add(bubasaur1);
            pokeBag.Add(bubasaur2);
            pokeBag.Add(charmander1);
            // 
            pokeBag.Speak();
            Console.WriteLine(pokemons[0].Speak());

            // 
            // var stongestPokemon = pokeBag.GetStrongest();
            // Should return the pokemon with the highest strength value
        }
    }
}
