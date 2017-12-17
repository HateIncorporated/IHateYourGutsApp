using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryV1
{
    public class User
    {
        public int UserId { get; set; }

        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Answers { get; set; }

        [InverseProperty("SenderUser")]
        public virtual ICollection<Message> SenderMessage { get; set; }

        [InverseProperty("RecieverUser")]
        public virtual ICollection<Message> RecieverMessage { get; set; }
    }
}
