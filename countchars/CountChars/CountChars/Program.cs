using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\VatoLoco\greenfox\pallida-basic-retake-exam\countchars\da_vinci_code.txt";
            CountChars1(path);
            //Console.WriteLine(article);
            Console.ReadLine();
        }

        public static void CountChars1(string path)
        {
            Dictionary<string, int> article = new Dictionary<string, int>();
            string text = File.ReadAllText(path);          
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (article.ContainsKey(word))
                {
                    article[word]++;
                }
                else
                {
                    article[word] = 1;
                }
            }

            foreach (KeyValuePair<string, int> vocable in article)
            {
                if (vocable.Value > 2)
                {
                    Console.WriteLine("\"" + vocable.Key + "\"" + " " + vocable.Value);
                }
            }
        }
    }
}
