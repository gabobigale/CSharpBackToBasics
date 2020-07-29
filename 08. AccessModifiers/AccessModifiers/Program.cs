using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class NumberClass
    {
        private int privateNumber = 10; // we can't access from another class, just avaliable from NumberClass
        public int publicNumber = 10; // we can access from other classes
        protected int protectedNumber = 10; // we can access from another derivedclass

    }

    class DerivedClass : NumberClass // this is inheritance
    {
        void Print()
        {
            Console.WriteLine(protectedNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberClassInFirstProject number = new NumberClassInFirstProject();
            Console.WriteLine($"Este es program: {number.internalAccessFirstProject}");

            //NumberClass num = new NumberClass();
            ////Console.WriteLine(num.);
            //Console.WriteLine(num.publicNumber);

        }
    }
}
