using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FindLongestFileNameInDir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the path: ");
            string directoryPath = Console.ReadLine();

            Console.WriteLine(GetLongestFileName(directoryPath));
                

            Console.ReadKey();
        }

        public static string GetLongestFileName(string path)
        {
            string[] arrFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            var list = new List<string>();

            foreach (var arrFile in arrFiles)
            {
                list.Add(Path.GetFileName(arrFile));
            }

            return list.OrderByDescending(s => s.Length)
                .FirstOrDefault();
        }
    }
}
