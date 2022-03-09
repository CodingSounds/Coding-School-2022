using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringNumber
    {

        public string Numb { get; set; }
        public StringNumber(string numb)
        {
            Numb = numb;
        }
        public decimal Number()
        {
            decimal temp=new decimal();
            try
            {
                temp = Convert.ToDecimal(Numb);

            }
            catch (Exception)
            {
                //logger

                
            }
            return temp;
        }


    }
}
