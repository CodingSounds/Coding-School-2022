using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {


        public Class1()
        {

        }
        public string InverseName(string name)
        {
            string reverseName = null;

            for (int i = 0; i < name.Length; i++)
            {
                reverseName+=name[name.Length-i-1];

            }


            return reverseName;
        }
    }
}
