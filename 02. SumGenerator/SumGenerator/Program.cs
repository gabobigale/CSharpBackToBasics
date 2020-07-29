using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the First Integer:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the Second Integer:");
            int second = Convert.ToInt32(Console.ReadLine());


            int result = first + second;
            Console.WriteLine($"The result is: {result}");
            Console.ReadKey();

        }
    }
}
