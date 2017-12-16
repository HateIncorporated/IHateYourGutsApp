using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LibraryV1
{
    public class IHateYourGutsDBInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            List<User> defaultUsers = new List<User>();
            
            defaultUsers.Add(new User() { Name = "Chernakov Egor", Login = "nagibator", Password = "1234", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Korneev Grisha", Login = "natsuki_lover", Password = "iLoveProgramming", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Churilov Arseniy", Login = "", Password = "insert_your_password", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Some Guy 1", Login = "guy1", Password = "imGuyNumberOne", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Some Guy 2", Login = "guy2", Password = "imGuyNumberTwo", Answers = GenerateAnswers() });

            foreach (var user in defaultUsers)
                context.Users.Add(user);

            base.Seed(context);
        }

        private List<int> GenerateAnswers()
        {
            Random random = new Random();
            List<int> answers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                answers.Add(random.Next(0, 100));
            }
            return answers;
        }
    }
}
