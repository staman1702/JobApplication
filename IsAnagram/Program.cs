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
                        
            
            if (IsAnagram(allChars1, allChars2) == true)
            {
                Console.WriteLine("Is anagram");
            }
            if (IsAnagram(allChars1, allChars2) == false)
            {
                Console.WriteLine("Is not anagram");
            }


            Console.ReadKey();
        }
        
        public static bool IsAnagram(char[] s1, char[] s2)
        {
            
            if (s1.Count() == s2.Count() && 
                !s1.Except(s2).Any())
                return true;

            else
                return false;
            
        }
    }
}
