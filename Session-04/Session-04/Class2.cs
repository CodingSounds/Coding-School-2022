using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class2
    {
        
        public Class2()
        {
            
        }

        public ulong Sum(ulong n)
        {// Optimal solution n*n+1/2
            ulong sum = 0;
            for (uint i = 1; i < n+1; i++)
            {
                sum += i;

            }
            return sum;

        }

        public  ulong Product(ulong n)
        {
            ulong product = 1;
            for (uint i = 1; i < n+1; i++)
            {
                product *= i;


            }



            return product;
        }

        public ulong SumYesOrProduct(bool sumOrProduct,int n)
        {
            ulong z = 0;
            z=Convert.ToUInt64(n);

            if (sumOrProduct)
            {
                return Sum(z);
            }
            else
            {
                return Product(z);

            }


        }



    }
}
