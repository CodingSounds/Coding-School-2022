using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;

namespace Session_07
{
    internal abstract class AbstractShowList
    {
        public FormEdit form { get; set; }

        public AbstractShowList()
        {
           

        }
        public abstract void  Showing();
        
                   

    }

}
