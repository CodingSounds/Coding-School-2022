using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{


    public class University : Institute

    {
    
    public List<Student> Students { get; set; }

    
    public List<Course> Courses { get; set; }

    
    public List<Grade> Grades { get; set; }

    

    public List<Schedule> ScheduledCourses { get; set; }








    public University():base()
        {
            
        Students = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                Students.Add(new Student());

            }

            
            Courses = new List<Course>();
            for (int i = 0; i < 20; i++)
            {
                Courses.Add(new Course());
            }
        ScheduledCourses = new List<Schedule>();
            for (int i = 0; i < 60; i++)
            {
                ScheduledCourses.Add(new Schedule());
            }
            Grades=new List<Grade>();
            for (int i = 0; i < 80; i++)
            {
                Grades.Add(new Grade());

            }
        }

      



    }
}
