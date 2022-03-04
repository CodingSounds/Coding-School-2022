using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class4
    {

        private  int[] array1;
        private int[] array2 = new int[] { 1, 3, 7, 10 };
        int[] multMatrix = new int[16];
        public Class4()
        {
         array1=new int[]{ 2, 4, 9, 12 };

        }     
        

        public void MultMatrix()
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)

                {
                    multMatrix[count] = array1[i] * array2[j];
                    Console.Write(multMatrix[(count)]+" ");
                    count++; 

                }

            }


            
        }

       
    }
}
