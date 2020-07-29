using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Methods
{
    class Program
    {

        public int GetValue(int number)
        {
            return number + 3;
        }

        public void WriteName(string name)
        {
            Console.WriteLine(name);
        }

        public static void Sum(int a, int b)
        { 
            int result = a + b;
            Console.WriteLine($"Result for Sum: {result}");
        }

        public static void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Result for Substract: {result}");
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Result for Multiplication: {result}");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Insert two numbers and get sum, substraction, multiplication");
            Console.WriteLine("First Number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Sum(firstNumber, secondNumber);
            Subtract(firstNumber, secondNumber);
            Multiplication(firstNumber, secondNumber);

            Console.ReadKey();

        }
    }
}
