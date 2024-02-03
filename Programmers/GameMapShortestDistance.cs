using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class GameMapShortestDistance
    {
        const int CostStraight = 1;
        const int INF = 99999;

        public int MapShortest(int[,] maps)
        {
            int ySize = maps.GetLength(0);
            int xSize = maps.GetLength(1);

            Point start = new Point(0, 0);
            Point end = new Point(ySize - 1, xSize - 1);

            Node[,] nodes = new Node[ySize, xSize];
            List<Point> path = new List<Point>();
            bool[,] visited = new bool[ySize, xSize];

            Node startNode = new Node(start, new Point(), 0, Heruistic(start, end));
            nodes[start.y, start.x] = startNode;
            Node nextNode = null;
            for (int i = 0; i < nodes.Length; i++)
            {
                int minDistance = INF;
                for (int j = 0; j < ySize; j++)
                {
                    for (int k = 0; k < xSize; k++)
                    {

                        if (nodes[j, k] != null &&        // 계산한적이 있는지
                            !visited[j, k] &&             // 방문한적이 있는지
                            maps[j, k] == 1 &&            // 갈 수 있는지
                            minDistance > nodes[j, k].f)  // f가 제일 작은것
                        {
                            minDistance = nodes[j, k].f;
                            nextNode = nodes[j, k];
                        }
                    }
                }
                if (nextNode == null)
                    break;

                visited[nextNode.pos.y, nextNode.pos.x] = true;

                if (nextNode.pos.y == end.y && nextNode.pos.x == end.x)
                {
                    Point point = end;
                    while (!(nextNode.pos.y == start.y && nextNode.pos.x == start.x))
                    {
                        path.Add(point);
                        point = nodes[point.y, point.x].parent;
                    }
                    path.Add(start);
                    return path.Count;
                }

                for (int j = 0; j < Direction.Length; j++)
                {
                    int y = nextNode.pos.y + Direction[j].y;
                    int x = nextNode.pos.x + Direction[j].x;

                    if (y < 0 || y >= ySize || x < 0 || x >= xSize) // 맵 범위를 넘었을 경우
                        continue;
                    else if (maps[y, x] == 0)                       // 이동불가 지역인 경우
                        continue;
                    else if (visited[y, x])                         // 방문한적이 있는 경우
                        continue;

                    int g = nextNode.g + CostStraight;
                    int h = Heruistic(new Point(y, x), end);
                    Node newNode = new Node(new Point(y, x), nextNode.pos, g, h);

                    if (nodes[y, x] == null ||     // 점수가 계산되지 않은 지역이거나
                        nodes[y, x].f > newNode.f) // f가 원래 보다 작은 경우
                    {
                        nodes[y, x] = newNode;
                    }
                }

            }
            return -1;
        }

        static Point[] Direction =
        {
            new Point (1,0),
            new Point (-1,0),
            new Point (0,1),
            new Point (0,-1),
        };

        static int Heruistic(Point start, Point end)
        {
            int xSize = start.x > end.x ? start.x - end.x : end.x - start.x;
            int ySize = start.y > end.y ? start.y - end.y : end.y - start.y;

            return CostStraight * (xSize + ySize);
        }

        public class Node
        {
            public Point pos;
            public Point parent;

            public int f;
            public int g;
            public int h;

            public Node(Point pos, Point parent, int g, int h)
            {
                this.pos = pos;
                this.parent = parent;
                this.f = g + h;
                this.g = g;
                this.h = h;
            }
        }
    }

    public struct Point
    {
        public int y;
        public int x;

        public Point(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
    }
}
