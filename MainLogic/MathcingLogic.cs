using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic
{
    public class MathcingLogic
    {
        public static int HammingDistance(List<int> list1, List<int> list2)
        {
            int distance = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                distance += Math.Abs(list1[i] - list2[i]);
            }
            return distance;
        }

    }
}
