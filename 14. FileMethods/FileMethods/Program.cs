using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\04. Proyectos\FileMethods\test.txt";
            string content = "Mehtod values";

            Console.WriteLine("Write a file");
            File.WriteAllText(path, content);
            Console.WriteLine();

            string di = Directory.GetCurrentDirectory();
            Console.WriteLine($"Directory is: {di}");
            Console.ReadKey();

        }
    }
}
