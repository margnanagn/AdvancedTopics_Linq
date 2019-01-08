using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            // old example
            var newWords = new List<string>();
            foreach (var word in catNames)
            {
                if (word.Contains("e")) 
                    {
                        newWords.Add(word);
                    }
            }
            Console.WriteLine(string.Join(", ",newWords));
        }
    }
}
