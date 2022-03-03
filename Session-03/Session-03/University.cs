using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute

    {
    public Student[] Students { get; }

    public Course[] Courses { get; }

    public Grade[] Grades { get; }
    public Schedule[] ScheduledCourses { get; }


     


    

    public University(string name, int yearsofservice):base(name, yearsofservice)
        {
         Name = name;
        YearsInServvice = yearsofservice;
        Students = new Student[30];
        Courses = new Course[20];
        ScheduledCourses = new Schedule[60];
        }

      

        public Course[] GetCourses()
        {            return Courses;
        }
        public Student[] GetStudents()
        {
            return Students;
        }

        public Grade[] GetGrades()
        {          return Grades;
        }
        public void SetSchedule(Guid courseID, Guid professorID,DateTime datetime)
        {
        }


    }
}
