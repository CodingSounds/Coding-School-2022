using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class InstituteMethods:Institute
    {
        public InstituteMethods()
        {

        }

        public void SetName(string name)
        {
            Name = name;

        }

        public string GetName()
        {
            return Name;
        }

    }
}
