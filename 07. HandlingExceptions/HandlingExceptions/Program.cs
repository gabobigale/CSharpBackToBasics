using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Handling Exceptions
            try
            {

                Console.WriteLine("Enter a string number to handler exception");
                Console.WriteLine("First Number");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Math.Sqrt(a));
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Exception is: {ex}");
            }
        }
    }
}