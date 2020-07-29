using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("USING WHILE");
            Console.WriteLine("Number of position to get last number with first number:");
            Console.WriteLine("First Number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Last Number:");
            b = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int sum = 0;
            while (sum < b)
            {
                sum += a;
                count++;
            }
            Console.WriteLine($"Numbers of positions: {count}");

            a = 0;
            b = 0;
            count = 0;
            Console.WriteLine("USING LOOP");
            Console.WriteLine("Number of positions from A number to B number");
            Console.WriteLine("First Number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Last Number:");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                count++;
            }
            Console.WriteLine($"Positions Loop: {count}");
            Console.ReadKey();
        }
    }
}
