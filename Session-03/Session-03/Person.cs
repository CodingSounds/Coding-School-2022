using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    // class
    public class Person
    {

        // property

        public Guid ID { get; }
        public string Name { get; set; }

        public ushort Age { get; set; }








        // constructor
        public Person(string name, ushort age)
        {
            ID = Guid.NewGuid();
            Name = name;
            Age = age;

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
