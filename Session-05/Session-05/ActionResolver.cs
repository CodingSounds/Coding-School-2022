using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get;  }


        public ActionResolver()
        {
            Logger = new MessageLogger();
        }
        public ActionResponse  Execute(ActionRequest request ,MessageLogger logger )
        {
            ActionResponse response = new ActionResponse();
            switch (request.Action)
            {
                case ActionEnum.Convert:
                    Logger.Write($"Using {nameof(ConvertResolver)}.");
                    var x = new ConvertResolver();

                    response.Output = x.Execute(request.Input, logger);
                    return response;

                case ActionEnum.UpperCase:
                    Logger.Write($"Using {nameof(UppercaseResolver)}.");
                    UppercaseResolver y= new UppercaseResolver();
                    
                    response.Output=y.Execute(request.Input,logger);
                    return response ;
                case ActionEnum.Reverse:

                    Logger.Write($"Using {nameof(ReverseResolver)}.");

                    var f=new ReverseResolver();


                    response.Output = f.Execute(request.Input, logger);
                    return response;
                    
                default:
                    Logger.Write($"Invalid action type {request.Action}.");
                    return null;
            }




            ;
        }

     
    }
}
