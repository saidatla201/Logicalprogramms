using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class temperatureconversion
    {
        static void Main(string[] args)
        {
            // Celsius to Farhenheat
            Console.WriteLine("Enter the Temperature in celsius: ");
            float Celsiusvalue=Convert.ToInt32 (Console .ReadLine());
            float CeltoFarvalue = ((Celsiusvalue  * 9 / 5) + 32); ;
            Console.WriteLine("Temperature in Farhenheat:  ", CeltoFarvalue);

            //Farhenheat to Celsius

            Console.WriteLine("Enter the Temperature in Farhenheat: ");
            float Farhenheatvalue = Convert.ToInt32(Console.ReadLine());
            float FarhentoCelsius= (Farhenheatvalue  - 32) * (5 / (float)9);
            Console.WriteLine("Temperature in Farhenheat:  ",FarhentoCelsius );

            Console.ReadLine();




        }
    }
}
