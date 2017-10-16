using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
