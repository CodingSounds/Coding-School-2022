using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DecidingOperaton
    {

        private char _operator { get; set; }

        public DecidingOperaton(char oper)
        {
            _operator = oper;


        }
        public decimal MathOperato(decimal number1, decimal number2)
        {
            if (_operator == '+')
            {
                var x = new Sum(number1, number2);
                return x.Addition();


            }
            else if (_operator == '-')
            {
                var x = new Subtraction(number1, number2);
                return x.Sub();


            }
            else if (_operator == 'x')
            {
                var x = new Multiplication(number1, number2);
                return x.Multi();

            }
            else if (_operator == ':')
            {
                var x = new Division(number1, number2);
                return x.Div();



            }
            else if (_operator == '^')
            {
                var x = new Power(number1, number2);
                return x.PowerOp();


            }
            else if (_operator == '√')
            {
                var x = new Root(number1, number2);
                return x.Sqr();

            }

                

                return 0;
        }








    }
}