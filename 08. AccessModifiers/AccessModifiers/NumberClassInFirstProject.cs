using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class NumberClassInFirstProject
    {
        internal int internalAccessFirstProject = 20;

    }

    class ProgramInFirstProject
    {
        void Print()
        {
            NumberClassInFirstProject num = new NumberClassInFirstProject();
            Console.WriteLine(num.internalAccessFirstProject);
        }
    }
}