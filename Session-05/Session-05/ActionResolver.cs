using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }


        public ActionResolver()
        {
            Logger = new MessageLogger();
        }
        public string Execute(ActionEnum action )
        {
            switch (action)
            {
                case ActionEnum.Convert:
                    break;
                case ActionEnum.UpperCase:
                    break;
                case ActionEnum.Reverse:
                    break;
                default:
                    break;
            }




            return "0";
        }

        

        //public string Execute(ActionRequest)
        //{
         //   return "df";
        //}
       // public int Execute(ActionRequest)
       // {
       //     return 0;
       // }
    }
}
