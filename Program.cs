using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Building_a_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to convert a string to a number
            int num = Convert.ToInt32("45"); //toInt16 holds a narrower range
            Console.WriteLine(num + 6);

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            //you can also convert to double, careful what your pc uses as decimal point(, or .)
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + num4);
            Console.Read();
        }
    }
}
