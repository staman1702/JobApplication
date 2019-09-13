using System;
using System.Collections;

namespace MostOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ulazni niz:");
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(" ", "");

            char[] allChars = sentence.ToCharArray();


            ArrayList arrUniqueChars = new ArrayList();

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
            
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Character {0} - has {1} occurences.",
                    arrUniqueChars[i],
                    NumberOfOccurences(arrUniqueChars[i].ToString(), sentence));
            }
            // varijabla "i" u for petlji se moze promjeniti da prikaže ne samo najčešće slovo, već može 
            // prikazati dva, tri, četiri najčešća slova u nizu...
            // ili jednostavno koristiti varijablu "aarUniqueChars" za ispis učestalosti svih slova u nizu


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
