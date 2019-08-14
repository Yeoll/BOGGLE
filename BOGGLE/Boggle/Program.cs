using System;

namespace Boggle
{
    class Program
    {
        static char[,] array = new char[5, 5] { 
            { 'u', 'r', 'l', 'p', 'm' },
            { 'x', 'p', 'r', 'e', 't' },
            { 'g', 'i', 'a', 'e', 't' },
            { 'x', 't', 'n', 'z', 'y' },
            { 'x', 'o', 'q', 'r', 's' },
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("input : ");
            string word = Console.ReadLine();
            string[] words = word.Split(",");
            
            Console.WriteLine("output : {0}", hasWord(Int32.Parse(words[0]), Int32.Parse(words[1]), words[2]));
            Console.WriteLine("output : {0}", hasWordUsingLoop(Int32.Parse(words[0]), Int32.Parse(words[1]), words[2]));
        }

        static bool hasWordUsingLoop(int y, int x, string word)
        {
            if (x < 0 || x > 4 || y < 0 || y > 4)
            {
                return false;
            }
            return false;
        }
        static bool hasWord(int y, int x, string word)
        {
            if (x < 0 || x > 4 || y < 0 || y > 4)
            {
                return false;
            }
            else if (word.Length == 0)
            {
                return true;
            }
            else if (word[0] != array[y, x])
            {
                return false;
            }
            else
            {
                return(hasWord(y - 1, x, word.Substring(1, word.Length - 1))
                    || hasWord(y - 1, x - 1, word.Substring(1, word.Length - 1))
                    || hasWord(y - 1, x + 1, word.Substring(1, word.Length - 1))
                    || hasWord(y, x - 1, word.Substring(1, word.Length - 1))
                    || hasWord(y, x + 1, word.Substring(1, word.Length - 1))
                    || hasWord(y + 1, x, word.Substring(1, word.Length - 1))
                    || hasWord(y + 1, x - 1, word.Substring(1, word.Length - 1))
                    || hasWord(y + 1, x + 1, word.Substring(1, word.Length - 1))
                    );
            }
        }
    }
}
