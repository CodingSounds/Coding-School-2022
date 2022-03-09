using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Power
    {



        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public Power(decimal number1, decimal number2)
        {
            Number1 = number1;
            Number2 = number2;

        }
        public decimal PowerOp()
        {

            return (decimal)Math.Pow((double)Number1, (double)Number2);

        }
    }
}

