using System;
using System.IO;

namespace FindLongestFileNameInDir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the path: ");
            string directoryPath = Console.ReadLine();
            GetFiles(directoryPath);
            Console.ReadKey();
        }

        public static void GetFiles(string path)
        {
            string[] arrFiles = Directory.GetFiles(path);

            foreach (var arrFile in arrFiles)
            {
                Console.WriteLine(Path.GetFileName(arrFile));
            }

            string[] sDirs = Directory.GetDirectories(path);
            foreach (string sDir in sDirs)
            {
                GetFiles(sDir);
            }
        }
    }
}
