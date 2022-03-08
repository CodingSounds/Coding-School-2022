using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ReverseResolver : AbstractResolver
    {
        
      
        public override string Execute(string word, MessageLogger logger)
        {
            string reversedString = string.Empty;

            for (int i = word.Length - 1; i > -1; i--)
                reversedString += word[i];

            return reversedString;
        }
    }
}
