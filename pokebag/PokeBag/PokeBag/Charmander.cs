using System;

namespace PokeBag
{
    public class Charmander : PokeBag
    {
        public Charmander()
        {
            this.HP = 10;
            this.speak = "Char-char";
        }

        public override void Speak()
        {
            Console.WriteLine(speak);
        }
    }
}