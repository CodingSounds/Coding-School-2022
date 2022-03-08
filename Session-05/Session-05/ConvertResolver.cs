using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ConvertResolver : AbstractResolver
    {
        public ConvertResolver()
        {
        }

        public override string Execute(string content, MessageLogger logger)
        {
            
            int result;
            if (!int.TryParse(content, out result))
            {
                logger.Write("Your input isn't an integer");
                return null;
            }

            return Convert.ToString(result, 2);
        }
    }
}
