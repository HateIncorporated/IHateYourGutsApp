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

        public List<int> GetList()
        {
            List<int> answers = new List<int>();
            char[] s = { ';' };
            foreach (var number in Answers.Split(s).ToList())
            {
                answers.Add(int.Parse(number));
            }
            return answers;
        }

        [InverseProperty("SenderUser")]
        public virtual ICollection<Message> SenderMessage { get; set; }

        [InverseProperty("RecieverUser")]
        public virtual ICollection<Message> RecieverMessage { get; set; }
    }
}
