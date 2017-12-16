using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryV1
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        
        public virtual User SenderUser { get; set; }
        public virtual User RecieverUser { get; set; }
    }

}
