using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class MessageLogger
    {
        public Message[] MessageList { get; set; }

        
        public MessageLogger()
        {
            MessageList = new Message[200];


        }


        public void ReadAll()
        {
            foreach ( Message _message in MessageList)
            {
                Console.WriteLine(_message.Mes_sag+" "+_message.ID+" "+_message.TimeStamp);
            }

        }

        public void Clear()
        {
            Array.Clear(MessageList, 0, MessageList.Length);


        }
        public void Write(string message)
        {
            for (int i = 0; i < MessageList.Length; i++)
            {
                if (MessageList[i].Mes_sag == null)
                    MessageList[i].Mes_sag = message;
            }

                

        }

    }
}

