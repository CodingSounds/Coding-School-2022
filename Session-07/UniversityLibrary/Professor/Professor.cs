using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Professor : Person

    {
        public string Rank { get; set; }

        
        public List<Course> Courses { get; set; }

        public Professor() : base()
        {   Courses = new List<Course>();
            for (int i = 0; i < 6; i++)
            {
                var item=new Course();
                Courses.Add(item);
            }


        }


        


       
    public void Teach(Course course, DateTime dateTime)
        {


        }
  
    }
}
