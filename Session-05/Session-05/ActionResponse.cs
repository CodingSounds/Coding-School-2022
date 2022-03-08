using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResponse:ActionID
    {
        Guid ResponsiveID { get; }
        string Output { get; set; }

        public ActionResponse()
        {
            ResponsiveID = Guid.NewGuid();

        }


    }
}
