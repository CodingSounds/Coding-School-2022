using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ActionID
    {
        public Guid RequestedID { get; set; }
        public ActionID()
        {
            RequestedID = Guid.NewGuid();

        }
    }
}
