using System;
using System.Collections.Generic;

namespace OI_pro
{
    internal class Program
    {
        public static bool Find_Words(string word, char ck)
        {
            foreach (char c in word)
            {
                if (ck == c)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            List<string> list_word = new List<string>();
            Console.WriteLine("Please enter some string words and use ',' to separate: ");
            string words = Console.ReadLine();

            list_word.AddRange(words.Split(','));

            Console.WriteLine("Please enter a word that you want to check:");
            ConsoleKeyInfo Thekey = Console.ReadKey();
            char check = Thekey.KeyChar;

            List<int> result = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (Find_Words(list_word[i], check))
                    result.Add(i);

            }

            Console.WriteLine(result.ToArray());
        }
    }
}
 