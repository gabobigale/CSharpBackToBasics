using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStaments
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("IF Statements");
            Console.WriteLine("Ingresar numero para a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar numero para b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar numero para c:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a es mayor que b");
            }
            else if (a > c)
            {
                Console.WriteLine("a es mayor que c");
            }
            else if (b > a)
            {
                Console.WriteLine("b es mayor que a");
            }
            else if (b > c)
            {
                Console.WriteLine("b es mayor que c");
            }
            else if (c > a)
            {
                Console.WriteLine("c es mayor que a");
            }
            else if (c > b)
            {
                Console.WriteLine("c es mayor que b");
            }

            Console.WriteLine("CASE Statements");

            Console.WriteLine("Enter the number of the month:");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine("Number of days: 31");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine("Number of days: 30");
                    break;
                case 2:
                    Console.WriteLine("Number of days could be 28 or 29");
                    break;
                default:
                    Console.WriteLine("You number is not in (1,12)");
                    break;
            }
            Console.ReadKey();
        }
    }
}
