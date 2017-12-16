using System;
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
        public int HammingDistance(List<int> list1, List<int> list2)
        {
            int distance = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                distance += Math.Abs(list1[i] - list2[i]);
            }
            return distance;
        }

        public string FindMatch(int userid, Context context)
        {

        }
    }
}
