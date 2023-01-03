using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal Amount : ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Year : ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest ; ");
            double R = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly payment with interest: " +payment );
            Console.ReadLine();

        }  
    }
}
