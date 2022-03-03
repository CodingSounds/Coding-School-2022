using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person

    {
     

     public string Rank { get; set; }

     public Course[] Courses { get; set; }


       
    public void Teach(Course course, DateTime dateTime)
        {


        }
    public void SetGrade( Guid studentID,Guid courseID,int grade)
        {

           


        }
        public Professor(string name, ushort age,string rank,Course[] courses ) : base(name, age)
        {
            Rank = rank;
            Courses = courses;


        }

        public  string GetName()
        {
            return ("Dr." + Name);
        }
    }
}
