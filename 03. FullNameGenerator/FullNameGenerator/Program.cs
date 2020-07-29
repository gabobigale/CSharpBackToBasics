using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write FirstName:");
            string firstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Write LastName:");
            string lastName = Convert.ToString(Console.ReadLine());

            string fullName = firstName + " " + lastName;
            Console.WriteLine($"The Full name is: {fullName}");

        }
    }
}
