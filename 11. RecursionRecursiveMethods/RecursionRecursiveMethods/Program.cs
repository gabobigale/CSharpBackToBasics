using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionRecursiveMethods
{
    class Program
    {

        public static int CalculateSumRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateSumRecursively(a, b);

            Console.WriteLine($"Result is: {sum}");

        }
    }
}
