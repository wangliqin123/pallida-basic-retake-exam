using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordreverser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a sentence as an input, reverses the letters in every word (but not reverses the words order in the sentence), and returns the sentence with the reversed words.
            // You shouldn't care about upper or lower case letters.
            // Example:
            //
            string reversedWords = WordReverser("lleW ,enod taht saw ton taht drah");
            Console.WriteLine(reversedWords);
            string reversed = "lleW ,enod taht saw ton taht drah";
           
            string updatereversed = "";
    
        }

        public static string WordReverser()
        {
            //for (int i = reversed.Length - 1; i >= 0; i--)
            //{
            //    updatereversed = updatereversed + reversed[i];
            //}
            //Console.WriteLine(updatereversed);
            //Console.ReadLine();
            text = String.Join(" ", text.Split(' ').Reverse().ToArray())

        }
    }
    
}
