using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exersice 1

            string name = "Kyriakos";
             
            var class1=new Class1();

            string inverseName = class1.InverseName(name);
            Console.WriteLine(inverseName);

            //Exersice 2

            var class2 = new Class2();

            Console.WriteLine("Give a number to find the sum or the product");

            string s = Console.ReadLine();
            
            int number = Convert.ToInt32(s);

            Console.WriteLine("If you want the sum write true else false");

            string t=Console.ReadLine();

            bool yes= Convert.ToBoolean(t);



            Console.WriteLine(class2.SumYesOrProduct(yes, number));
        
            //Exersice 3

            var class3 = new Class3();

            Console.WriteLine("Give a number to find all the primes less or equal to this number");

            string j = Console.ReadLine();

            int numberPrime = Convert.ToInt32(j);







            

            class3.PrintPrimeNumbers(numberPrime);

            


            //|Exersice 4
            var class4=new Class4();

            Console.WriteLine("  \n");

            class4.MultMatrix();

            Console.WriteLine("  \n");

            //Exercise 5

            var class5=new Class5();

            class5.SortMatrix();


            

            
            

            Console.ReadLine();



        }
    }
}
