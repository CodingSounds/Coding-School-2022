using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    // class
    public class Person
    {

        // property

        public Guid ID { get; }
        public string Name { get; set; }

        public int Age { get; set; }








        // constructor
        public Person()
        {
            ID = Guid.NewGuid();
            Name = string.Empty;
            

        }





    }
}
