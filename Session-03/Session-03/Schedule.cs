using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Schedule
    {

        public Guid ID { get; }

        public Guid CourseID { get; }

        public Guid ProfessorID { get; }

        public DateTime Callendar { get; set; }
    public Schedule(Guid courseID, Guid professorID,DateTime callender )
        {
            ID = Guid.NewGuid();
            CourseID = courseID;
            ProfessorID = professorID;
            Callendar = callender;
  
        }

    }
}
