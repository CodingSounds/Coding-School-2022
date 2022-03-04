using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class5
    {

        public Class5()
        {

        }

        private int[] _array1 = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

       public void SortMatrix()
        {
            int temp=0;
            for (int i = 0; i < _array1.Length; i++)
            {
                for (int j = 0; j < i; j++)

                {
                    if (_array1[i] < _array1[j])
                    {
                        temp = _array1[i];
                        _array1[i] = _array1[j];
                        _array1[j] = temp;
                    }

                }

            }
            foreach (int i in _array1)
            {
                Console.Write("{0} ", i);
            }
                
        }
        

    }
}
