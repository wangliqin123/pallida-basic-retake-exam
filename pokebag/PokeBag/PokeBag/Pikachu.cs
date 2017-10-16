using System;

namespace PokeBag
{
    public class Pikachu : PokeBag
    {
        public Pikachu()
        {
            this.HP = 12;
            this.speak = "Pika-pika";         
        }

        public override void Speak()
        {
            Console.WriteLine(speak);
        }
    }
}