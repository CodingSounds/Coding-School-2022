using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ActionResponse:ActionID
    {
        public Guid ResponsiveID { get; }
        public string Output { get; set; }

        public ActionResponse()
        {
            ResponsiveID = Guid.NewGuid();

        }


    }
}
