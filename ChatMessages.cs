using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_stack
{
    public class ChatMessages
    {
        public int Messageid {get; set;}
        public string Content {get; set;} = null!;
        public DateTime Timestamp {get;set;}

        public int SourceId {get;set;}

        public ChatMessages()
        {
            
        }
        public ChatMessages(int messageid, string content, DateTime timestamp, int sourceid )
        {
            this.Messageid= messageid;
            this.Content=content;
            this.Timestamp=timestamp;
            this.SourceId=sourceid;
        }
    }
}