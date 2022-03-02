using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotis2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 exersice
            Console.WriteLine("Hello Kyriakos");

            //2 exersice
            float number1 = 3.2f;
            float number2 = 4.2f;
            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 / number2);
            //3 exersice

            Console.WriteLine(-1 + 5 * 6);
            Console.WriteLine(38 + 5 % 7);
            Console.WriteLine(14 + (-3 * 6) / 7.0);
            Console.WriteLine(2 + (13 / 6.0) * 6 + Math.Sqrt(7));
            Console.WriteLine((Math.Pow(6, 4) + Math.Pow(5, 7)) / (9.0 % 4));

            //4 Exersice
            string gender = "male";
            int age = 30;
            Console.WriteLine("You are " + gender + " and look younger than " + age);

            //5 Exersice
            int seconds = 347923564;
            int minutes = seconds / 60;
            int hours = minutes / 60;
            int days = hours / 24;
            int years = days / 365;
            Console.WriteLine("Minutes:" + minutes);
            Console.WriteLine("Hours:" + hours);
            Console.WriteLine("Days:" + days);
            Console.WriteLine("Years:" + years);


            //7 Exersice
            //Supposedly we are not intrested in the de

            int celsius = 27;
            double fahrenheit = (3.345 + 2.0);



            Console.ReadLine();

        }
    }
}
