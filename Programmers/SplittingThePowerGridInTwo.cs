using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    // 전력망을 둘로 나누기
    internal class SplittingThePowerGridInTwo
    {
        public static int Solution(int n, int[,] wires)
        {
            bool[,] graph = new bool[n, n];
            for (int i = 0; i < n - 1; i++)
            {
                graph[wires[i, 0] - 1, wires[i, 1] - 1] = true;
                graph[wires[i, 1] - 1, wires[i, 0] - 1] = true;
            }

            int balance = 9999;
            int distance = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (graph[i, j] == true)
                    {
                        graph[i, j] = false;
                        int one = BFS(graph, i);
                        distance = Math.Abs(n - one * 2);
                        if (balance > distance)
                            balance = distance;
                        graph[i, j] = true;
                    }
                }
            }
            return balance;
        }

        static int BFS(bool[,] graph, int start)
        {
            int size = graph.GetLength(0);
            bool[] visited = new bool[size];
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
            }

            Queue<int> que = new Queue<int>();
            visited[start] = true;
            que.Enqueue(start);
            int count = 0;
            while (que.Count > 0)
            {
                int next = que.Dequeue();
                count++;
                for (int i = 0; i < size; i++)
                {
                    if (!visited[i] && graph[next, i])
                    {
                        visited[i] = true;
                        que.Enqueue(i);
                    }
                }
            }
            return count;
        }
    }
}
