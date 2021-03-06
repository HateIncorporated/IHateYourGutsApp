﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryV1;

namespace Logic
{
    public class MatchingLogic
    {
        private static int HammingDistance(List<int> list1, List<int> list2)
        {
            int distance = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                distance += Math.Abs(list1[i] - list2[i]);
            }
            return distance;
        }

        public static List<int> GetListFromAnswers(string str)
        {
            List<int> answers = new List<int>();
            char[] s = {';'};
            foreach (var number in str.Split(s).ToList())
            {
                answers.Add(int.Parse(number));
            }
            return answers;
        }

        /*public static User FindMatch(List<int> userAnswers, UnitOfWork unitOfWork)
        {
            User matchedUser = new User() {Name="", UserId=0 };
            string name = "";
            int maxHammingDistance = 0;
            foreach(var user in unitOfWork.Users.GetList())
            {
                int distance = HammingDistance(userAnswers, user.GetList());
                if (distance > maxHammingDistance)
                {
                    name = user.Name;
                    maxHammingDistance = distance;
                    matchedUser.Name = user.Name;
                    matchedUser.UserId = user.UserId;
                }
            }
            Console.WriteLine(name);
            return matchedUser;
        }*/

        public static int FindMatch(List<int> userAnswers, UnitOfWork unitOfWork)
        {
            
                int matchedUserId = 0;
                int maxHammingDistance = 0;
                var users = unitOfWork.Users.GetList();
                if (users.Any()) {
                    matchedUserId = users[0].UserId;
                }
                foreach (var user in users)
                {
                    int distance = HammingDistance(userAnswers, user.GetList());
                    if (distance > maxHammingDistance)
                    {
                        maxHammingDistance = distance;
                        matchedUserId = user.UserId;
                    }
                }
                return matchedUserId;
            
        }
    }
}
