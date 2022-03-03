using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course english = new Course("c12","English");

            Course[] kyriakoscourses=new Course[] { english };
            Student kyriakos = new Student("Kyriakos Mousias", 29, 4,kyriakoscourses);
            Professor fotis = new Professor("Fotis", 40, "teacher", kyriakoscourses);
            
            Console.WriteLine(fotis.GetName());
            Console.WriteLine(kyriakos.GetName());
            Console.ReadLine();


           




        }
    }
}
