using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class RicochetRobot
    {
        public static int Solution(string[] board)
        {
            int xSize = board[0].Length;
            int ySize = board.Length;
            int answer = -1;
            char[,] graph = new char[ySize, xSize];
            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < xSize; j++)
                {
                    graph[i, j] = board[i][j];
                    if (board[i][j] == 'R')
                    {

                    }
                }
            }


            return answer;
        }

        
    }
}
