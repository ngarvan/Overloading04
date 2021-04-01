using System;

namespace Overloading04
{
    class Prog
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1: " + number.FindMinimum(3, 1));
            Console.WriteLine("Minimum #2: " + number.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: " + number.FindMaximum(3, 1));
            Console.WriteLine("Maximum #2: " + number.FindMaximum(3, 2, 4));
        }
    }
}
