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
        
        public virtual Account SenderAccount { get; set; }
        public virtual Account RecieverAccount { get; set; }
    }

    public class Account
    {
        public int AccountId { get; set; }

        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        [InverseProperty("SenderAccount")]
        public virtual ICollection<Message> SenderMessage { get; set; }

        [InverseProperty("RecieverAccount")]
        public virtual ICollection<Message> RecieverMessage { get; set; }
    }

}
