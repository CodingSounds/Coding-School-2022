using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class Message
    {

        
        public string Mes_sag { get; set; }
        public Guid ID { get; }
        public TimeSpan TimeStamp { get;}
        public Message()
        {
            Guid ID= Guid.NewGuid();
            DateTime TimeStamp= DateTime.Now;

        }
    }
}
