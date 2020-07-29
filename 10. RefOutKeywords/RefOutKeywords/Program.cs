using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutKeywords
{

    class Program
    {
        public static void ChangeAndWrite(int number)
        {
            number = 20;
            Console.WriteLine($"Inside Number values is: {number}");
        }
        public static void ChangeAndWrite(ref int number)
        {
            number = 20;
            Console.WriteLine($"Inside Number values is: {number}");
        }
        public static void ChangeAndWriteNewObject(Pen pen)
        {
            pen = new Pen(Color.Red);
            Console.WriteLine($"Inside Color values is: {pen.Color}");
        }
        public static void ChangeAndWriteNewObject(ref Pen pen)
        {
            pen = new Pen(Color.Red);
            Console.WriteLine($"Inside Color values is: {pen.Color}");
        }

        static void Main(string[] args)
        {

            int number = 5;
            Console.WriteLine($"Prior number value is: {number}");
            ChangeAndWrite(number);
            Console.WriteLine($"After number value is: {number}");

            Console.WriteLine();

            ChangeAndWrite(ref number);
            Console.WriteLine($"After ref number value is: {number}");

            Console.WriteLine();

            Pen pen = new Pen(Color.Blue);
            Console.WriteLine($"Prior color value is: {pen.Color}");
            ChangeAndWriteNewObject(pen);
            Console.WriteLine($"After color value is: {pen.Color}");

            Console.WriteLine();

            ChangeAndWriteNewObject(ref pen);
            Console.WriteLine($"After ref number value is: {pen.Color}");

            Console.ReadKey();
        }
    }
}
