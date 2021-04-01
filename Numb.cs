using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading04
{
    public class Numb
    {
        public int FindMinimum(int number1, int number2)
        {
            int min;
            if (number1 < number2)
                min = number1;
            else
                min = number2;

            return min;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int intnumber3 = (int)Math.Ceiling(number3);

            int min;
            if (number1 < number2 && number1 < number3)
                min = number1;
            else if (number2 < number1 && number2 < number3)
                min = number2;
            else
                min = intnumber3;

            return min;
        }

        public int FindMaximum(int number1, int number2)
        {
            int max;
            if (number1 > number2)
                max = number1;
            else
                max = number2;

            return max;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int intnumber3 = (int)Math.Ceiling(number3);

            int max;
            if (number1 > number2 && number1 > number3)
                max = number1;
            else if (number2 > number1 && number2 > number3)
                max = number2;
            else
                max = intnumber3;

            return max;
        }
    }
}
