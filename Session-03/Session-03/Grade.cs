using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {

        public Guid ID { get; }
        public Guid StudentID { get; }

        public Guid CourseID { get; }

        public int Grade1 { get; set; }
    public Grade(Guid studentID, Guid courseID, int grade1) {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            Grade1 = grade1;
        }
    }
}
