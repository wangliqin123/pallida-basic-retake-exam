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

        List<PokeBag> pokemons = new List<PokeBag>();

        Random random = new Random();

        public PokeBag()
        {
            this.strenght = random.Next(1, 10);

        }

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
