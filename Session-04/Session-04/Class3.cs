using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class3
    {



        public Class3()
        {

        }

    public int[] PrimeNumbers(int n)
        {
            //Not  time efficient code
            int[] primeNumbers = new int[n+1];

            bool _notPrime=false;

            for (int i = 2; i < n+1; i++)
            {
            
                for (int j = 2; j < i-1; j++)
                {
                    if (i % j == 0)
                    {
                        _notPrime = true;
                        
                    }

                }
                if (_notPrime == false)
                {
                    primeNumbers[i] = i;
                }
                _notPrime = false;
           
            }
            return primeNumbers;

        }
    public void PrintPrimeNumbers(int n)
        {
            for (int i = 0; i < n+1; i++)

            {
                var listOfPrimes=PrimeNumbers(n);
                if (listOfPrimes[i] != 0)
                {
                    Console.Write(listOfPrimes[i]+" ");
                    

                }

            }
            
        }
    }
}
