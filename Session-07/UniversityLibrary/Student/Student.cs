using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversityLibrary
{
    public class Student : Person
    {
        public List<Course> Courses { get; set; }
        //public Course[] Courses { get; set; }
        public Student()
        {

            Courses = new List<Course>();
            for (int i = 0; i < 5; i++)
            {
                var item = new Course();
                Courses.Add(item);
            }
        }


        public int RegistrationNumber { get; set; }
        



 
    }
}
