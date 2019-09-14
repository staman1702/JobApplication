using System;

namespace Permutations
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("input text:");
            string input = Console.ReadLine();
            Permuatations("", input);
            Console.ReadKey();
        }

        static void Permuatations(string prefix, string input)
        {
            int n = input.Length;
            if (n == 0) { Console.WriteLine(prefix); }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Permuatations(prefix + input[i], 
                        input.Substring(0, i) + input.Substring(i + 1, n - (i + 1)));
                }
            }
        }
    }
}
