using System;
using System.Collections;
using System.Linq;

namespace IsAnagram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input string1:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Input string2:");
            string string2 = Console.ReadLine(); 
            
            if (IsAnagram(string1, string2) == true)
            {
                Console.WriteLine("Is anagram");
            }
            if (IsAnagram(string1, string2) == false)
            {
                Console.WriteLine("Is not anagram");
            }
            Console.ReadKey();
        }
        
        public static bool IsAnagram(string s1, string s2)
        {
            s1 = s1.Replace(" ", "");
            s2 = s2.Replace(" ", "");

            string sc1 = String.Concat(s1.OrderBy(x => x));
            string sc2 = String.Concat(s2.OrderBy(x => x));
            
            if (sc1.ToLower() == sc2.ToLower())
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
