using System;
using System.Collections;

namespace MostOccurences
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("input the text:");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower().Replace(" ", "");
            char[] allChars = sentence.ToCharArray();
            ArrayList arrUniqueChars = new ArrayList();
            int max = int.MinValue;

            for (int i=0; i<allChars.Length; i++)
            {
                bool add = true;

                for (int j =0; j < arrUniqueChars.Count; j++)
                {
                    if (allChars[i].ToString() == arrUniqueChars[j].ToString())
                    {
                        add = false;
                        break;
                    }
                }

                if(add)
                {
                    arrUniqueChars.Add(allChars[i]);
                }
            }

            for (int i = 0; i < arrUniqueChars.Count; i++)
            {
                if (max < NumberOfOccurences(arrUniqueChars[i].ToString(), sentence))
                {
                    max = NumberOfOccurences(arrUniqueChars[i].ToString(), sentence);
                }
            }

            for (int i = 0; i < arrUniqueChars.Count; i++)
            {
                if (max == NumberOfOccurences(arrUniqueChars[i].ToString(), sentence))
                {
                    Console.WriteLine("Character {0} has {1} occurences.",
                    arrUniqueChars[i],
                    NumberOfOccurences(arrUniqueChars[i].ToString(), sentence));
                }
            }
            Console.ReadKey();
        }

        static int NumberOfOccurences(string character, string sentence)
        {
            int numberOfOccurences = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence.Substring(i, character.Length) == character)
                {
                    numberOfOccurences++;
                }
            }                         
            return numberOfOccurences;
        }
    }
}
