using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Division
    {

        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public Division(decimal number1, decimal number2)
        {
            Number1 = number1;
            Number2 = number2;

        }
        public decimal Div()
        {
            return Number1 / Number2;

        }


    }
}
