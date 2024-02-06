using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class Fruiterer
    {
        public static int Solution(int k, int m, int[] score)
        {
            int answer = 0;
            int apple = score.Length;
            Array.Sort(score);
            Array.Reverse(score);
            for (int i = 0; i < apple; i++)
            {
                if (i != 0 && (i + 1) % m == 0)
                {
                    answer += m * score[i];
                }
            }
            return answer;
        }
    }
}
