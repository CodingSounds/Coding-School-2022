using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Logger
    {
        public string[] NumberListLogger { get; set; }
        public Logger()
        {
            NumberListLogger = new string[30];
            

        }
        public void Insert(string digits)
        {
            
            for (int i = 0; i < NumberListLogger.Length; i++)
            {
                if (NumberListLogger[i] == null)
                {
                    NumberListLogger[i] = digits;
                    break;
                }
            }



        }

    }
}
