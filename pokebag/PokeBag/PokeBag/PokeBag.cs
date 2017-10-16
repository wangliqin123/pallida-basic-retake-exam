using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBag
{
    public class PokeBag
    {
        public string type;
        public int HP;
        public int strenght;
        public string speak;

        public List<PokeBag> pokemons = new List<PokeBag>();



        public void Add(PokeBag pokemon)
        {
            pokemons.Add(pokemon);
        }
        public virtual void Speak()
        {
            Console.WriteLine("");
        }
    }
}
