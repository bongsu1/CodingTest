namespace Programmers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] map =
            {
                {1,0,1,1,1},
                {1,0,1,0,1},
                {1,0,1,1,1},
                {1,1,1,0,1},
                {0,0,0,0,1}
            };
            int path = GameMapShortestDistance.MapShortest(map);
            Console.WriteLine(path);
        }
    }
}
