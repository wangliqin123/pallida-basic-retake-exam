using System;
using System.Collections.Generic;

namespace PokeBag
{
    public class PokeBag
    {
        public int HP;       
        public string speak;
        public int strenght;

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