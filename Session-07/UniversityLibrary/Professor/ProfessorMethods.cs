using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class ProfessorMethods:Professor
    {

        public ProfessorMethods()
        {

        }

        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {




        }


        public string GetName()
        {
            return ("Dr." + Name);
        }
    }
}
