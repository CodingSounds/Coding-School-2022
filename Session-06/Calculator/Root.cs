using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Root
    {
        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public Root(decimal number1, decimal number2)
        {
            Number1 = number1;
            Number2 = number2;

        }

        public decimal Sqr()
        {

            return (decimal)Math.Sqrt((double)Number1);
        }









    }
}