using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Institute

    {

     public Guid ID { get; }
     public string Name { get; set; }

     public int YearsInServvice { get; set; }
    



     
        public Institute()
        {
            ID = Guid.NewGuid();
            
        }



    }
}
