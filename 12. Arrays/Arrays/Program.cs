using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        public static void PopulateArray(int[] numbers)
        {
            Random r = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(20);
                Console.WriteLine($"Random Number {i + 1} is: {numbers[i]}");
            }
        }

        public static void CalculateSum(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum Result is: {sum}");
        }
        public static void ParametersArray(params int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine($"Params values: {i}");
            }
        }

        public static void MultidimensionalArray(int a, int b)
        {
            int maxRandom = 50;
            int[,] numbersMultiDim = new int[a, b];
            Random r = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    numbersMultiDim[i, j] = r.Next(maxRandom);
                    //Console.WriteLine($"Multidimensional Number: {numbersMultiDim[i, j]}");
                }                
            }

            //Print Multidimensional variable
            for (int i = 0; i < numbersMultiDim.GetLength(0); i++)
            {
                for (int j = 0; j < numbersMultiDim.GetLength(1); j++)
                {
                    Console.WriteLine($"Multidimensional Number: {numbersMultiDim[i, j]}");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1,2,3,4,5 };
            Pen[] pens = new Pen[3] { new Pen(Color.Red), new Pen(Color.Blue), new Pen(Color.Aqua) };

            Console.WriteLine("Present array Numbers for");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number: {numbers[i]}");
            }

            Console.WriteLine("Present array Numbers foreach");
            foreach (int i in numbers)
            {
                Console.WriteLine($"Number: {i}");
            }


            Console.WriteLine("Present array colors for");
            for (int i = 0; i < pens.Length; i++)
            {
                Console.WriteLine($"Number: {pens[i].Color}");
            }

            Console.WriteLine("Present array colors foreach");
            foreach (Pen i in pens)
            {
                Console.WriteLine($"Number: {i.Color}");
            }

            Console.WriteLine();

            Console.WriteLine("Insert a number, then will generate Random values");
            int capacity = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = new int[capacity];
            numbers.DefaultIfEmpty();
            numbers = new int[capacity];

            PopulateArray(numbers);
            Console.WriteLine();
            CalculateSum(numbers);

            //Parameters in methods
            Console.WriteLine();
            ParametersArray(1, 2, 3, 4, 5, 6);

            //Multidimensional array
            Console.WriteLine();
            Console.WriteLine("Get Row number:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Get Column number:");
            int column = Convert.ToInt32(Console.ReadLine());

            //Generate Multidimensional array
            MultidimensionalArray(row, column);


            Console.ReadKey();
        }
    }
}  