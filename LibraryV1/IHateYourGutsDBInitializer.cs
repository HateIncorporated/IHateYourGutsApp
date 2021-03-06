﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LibraryV1
{
    public class IHateYourGutsDBInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        static Random random = new Random(DateTime.Now.Second);
        protected override void Seed(Context context)
        {
            List<User> defaultUsers = new List<User>();
            List<Question> defaultQuestions = new List<Question>();
            
            defaultUsers.Add(new User() { Name = "Chernakov Egor", Login = "egor", Password = "1234", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Korneev Gosha", Login = "natsuki_lover", Password = "iLoveProgramming", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Churilov Arseniy", Login = "helwy", Password = "izi10", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "Ivan Ivanov", Login = "IvanovIvanIvanovich", Password = "pass", Answers = GenerateAnswers() });
            defaultUsers.Add(new User() { Name = "John Doe", Login = "JDoeRealPersonNotSeeded", Password = "pass", Answers = GenerateAnswers() });

            foreach (var user in defaultUsers)
                context.Users.Add(user);

            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I love action movies more than any other kind" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I love doing sports of all kinds" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Pineapple pizza is fantastic!" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I hate being alone and love being around people" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "One day I want to move to another country" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Coding on C# is the best thing in the world!" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I prefer staying at home rather than going somewhere" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Getting up in the morning is often a challenge for me" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I'd rather order food online than cook it myself" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Healthy lifestyle - that's about me" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "I never ever do things at the last moment" });
            defaultQuestions.Add(new Question() { Answer = 50, QuestionText = "Hip-hop is so much better than rock music" });

            foreach (var question in defaultQuestions)
                context.Questions.Add(question);

            base.Seed(context);
        }

        public static String GenerateAnswers()
        {
            string strAnswers = "";
            List<int> answers = new List<int>();
            //Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                answers.Add(random.Next(0, 100));
            }
            strAnswers = string.Join(";", answers);
            return strAnswers;
        }
    }
}
