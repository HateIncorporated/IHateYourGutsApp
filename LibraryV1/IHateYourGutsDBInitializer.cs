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
            List<Question> defaultQuestions = new List<Question>();
            
            defaultUsers.Add(new User() { Name = "Chernakov Egor", Login = "nagibator", Password = "1234", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Korneev Gosha", Login = "natsuki_lover", Password = "iLoveProgramming", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Churilov Arseniy", Login = "", Password = "insert_your_password", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Some Guy 1", Login = "guy1", Password = "imGuyNumberOne", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Some Guy 2", Login = "guy2", Password = "imGuyNumberTwo", Answers = GenerateAnswers() });

            foreach (var user in defaultUsers)
                context.Users.Add(user);

            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I  prefer action films to calm ones" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I'd better go to bed earlier so as to get up earlier" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Pizza with pineapples is fantastic!" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Russian nowadays music is pretty good" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "One day I wnat to move to another country" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Coding on C# is the best thing in the world!" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I prefer staying at home rather than going somewhere" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Getting up in the morning is often a challenge for me" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I'd better order food rather than make it by myself" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Healthy lifestyle - that's about me" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I never do things at the last moment" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I can't live without music" });

            foreach (var question in defaultQuestions)
                context.Questions.Add(question);

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
