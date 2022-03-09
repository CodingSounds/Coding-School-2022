using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperation
    {
        public string TwoNumbers;
        public MathOperation(string twonumbers)
        {
            TwoNumbers = twonumbers;
            

        }
        private bool _firstnumber = true;
        public string number1 = string.Empty;
        public decimal numberA;
        public decimal numberB;
        public decimal result;
        public string number2 = string.Empty;
        private string temp = string.Empty;
        public char oper;

        public string Result()
        {
            for (int i = 0; i < TwoNumbers.Length; i++)
            {

                if (TwoNumbers[i] == '+')
                {
                    oper = '+';
                    temp = string.Empty;
                    _firstnumber = false;
                }
                else if (TwoNumbers[i] == '-')
                {
                    oper = '-';
                    temp = string.Empty;
                    _firstnumber = false;
                }
                else if (TwoNumbers[i] == 'x')
                {
                    oper = 'x';
                    temp = string.Empty;
                    _firstnumber = false;
                }
                else if (TwoNumbers[i] == ':')
                {
                    oper = ':';
                    temp = string.Empty;
                    _firstnumber = false;
                }
                else if (TwoNumbers[i] == '^')
                {
                    oper = '^';
                    temp = string.Empty;
                    _firstnumber = false;
                }
                else if (TwoNumbers[i] == '=')
                {
                    try
                    {
                        numberA = Convert.ToDecimal(number1);
                        numberB = Convert.ToDecimal(number2);
                        var finalresult = new DecidingOperaton(oper);

                        return Convert.ToString(finalresult.MathOperato(numberA, numberB));



                    }
                    catch (Exception x)
                    {
                                            }
                }
                else
                {
                    temp += TwoNumbers[i];
                }

                if (_firstnumber)
                {
                    number1 = temp;
                }
                else
                {
                    number2 = temp;
                }







            }




            
            return null;
        }
    }


}


