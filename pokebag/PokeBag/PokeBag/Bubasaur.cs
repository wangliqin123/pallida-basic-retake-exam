using System;

namespace PokeBag
{
    public class Bubasaur : PokeBag
    {
        public Bubasaur()
        {
            this.HP = 10;
            this.speak = "Bulba-saur";
        }

        public override void Speak()
        {
            Console.WriteLine(speak);
        }
    }
}