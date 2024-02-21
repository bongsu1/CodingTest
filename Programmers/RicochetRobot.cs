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

            Point startPoint = new Point();
            Point endPoint = new Point();

            char[,] graph = new char[ySize, xSize];

            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < xSize; j++)
                {
                    graph[i, j] = board[i][j];
                    if (board[i][j] == 'R')
                    {
                        startPoint.y = i;
                        startPoint.x = j;
                    }
                    else if (board[i][j] == 'G')
                    {
                        endPoint.y = i;
                        endPoint.x = j;
                    }
                }
            }

            return Road(graph, startPoint, endPoint);
        }

        static int Road(char[,] graph, Point startPoint, Point endPoint)
        {
            List<Point> road = new List<Point>();
            
            // endPoint 주변에 벽이 있나 확인
            for (int i = 0; i < Direction.Length; i++)
            {
                int prevYPoint = endPoint.y + Direction[i].y;
                int prevXPoint = endPoint.x + Direction[i].x;

                // 맵 밖인경우
                if ((prevXPoint < 0 || prevXPoint < graph.GetLength(1)) &&
                    prevYPoint < 0 || prevYPoint > graph.GetLength(0))
                {
                    
                }
                // 'D'(벽)인 경우
                else if (graph[prevYPoint, prevXPoint] == 'D')
                {

                }
                // 벽이 없는 경우
                else // if (graph[prevYPoint, prevXPoint] == '.')
                {
                    return -1;
                }
            }

            return road.Count;
        }

        struct Point
        {
            public int y;
            public int x;

            public Point(int y, int x)
            {
                this.y = y;
                this.x = x;
            }
        }

        static Point[] Direction =
        {
            new Point(1, 0),
            new Point(-1, 0),
            new Point(0, 1),
            new Point(0, -1),
        };
    }
}
