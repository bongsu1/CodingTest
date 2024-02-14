using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class MakingHamburgers
    {
        public static int Solution(int[] ingredient)
        {
            int answer = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ingredient.Length; i++)
            {
                sb.Append(ingredient[i]);
            }
            string ham = sb.ToString();
            while (ham.Contains("1231"))
            {
                ham = ham.Replace("1231", " ");
                foreach (char c in ham)
                {
                    if (c == ' ')
                        answer++;
                }
                ham = ham.Replace(" ", "");
            }
            return answer;
        }
    }
}
