using System;

namespace Wordreverser
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedWords = WordReverser("lleW ,enod taht saw ton taht drah");
            Console.WriteLine(reversedWords);
            Console.ReadLine();
        }

        public static string WordReverser(string reversedWords)
        {
            char[] charArray = reversedWords.ToCharArray();
            Array.Reverse(charArray);
            charArray.ToString();

            string sentence = new string(charArray);
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
    
}