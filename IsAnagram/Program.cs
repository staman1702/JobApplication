using System;
using System.Collections;
using System.Linq;

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string1:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Input string2:");
            string string2 = Console.ReadLine();

            string1 = string1.Replace(" ", "");
            string2 = string2.Replace(" ", "");


            char[] allChars1 = string1.ToCharArray();
            char[] allChars2 = string2.ToCharArray();
                        
            
            if (allChars1.Count() == allChars2.Count() 
                && !allChars1.Except(allChars2).Any())
            {
                Console.WriteLine("Is anagram");
            }
            else
            {
                Console.WriteLine("Is not anagram");
            }


            Console.ReadKey();
        }
    }
}
