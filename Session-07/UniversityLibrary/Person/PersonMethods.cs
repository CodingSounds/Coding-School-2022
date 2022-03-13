using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    internal class PersonMethods:Person
    {
        public PersonMethods()
        {

        }
        public void SetName(string name)
        {
            Name = name;

        }
        //private string _name;

        public string GetName()
        {
            return Name;
        }

    }
}
