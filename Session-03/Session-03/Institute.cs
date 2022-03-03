using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute

    {

     public Guid ID { get; }
     public string Name { get; set; }

     public int YearsInServvice { get; set; }
    



     public void SetName(string name)
        {
            Name = name;

        }
        public Institute(string name, int yearsofservice)
        {
            ID = Guid.NewGuid();
            Name = name;
            YearsInServvice = yearsofservice;
        }




        public string GetName()
        {
            return Name;
        }

    }
}
