using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class UniversityMethods:University
    {
        public UniversityMethods()
        {

        }

        public List<Course> GetCourses()
        {
            return Courses;
        }
        public List<Student> GetStudents()
        {
            return Students;
        }

        public List<Grade> GetGrades()
        {
            return Grades;
        }
        public void SetSchedule()
        {
        }

    }
}
