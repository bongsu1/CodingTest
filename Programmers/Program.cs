namespace Programmers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] board = { "...D..R", ".D.G...", "....D.D", "D....D.", "..D...." };
            int shortest = RicochetRobot.Solution(board);
            Console.WriteLine(shortest);
        }
    }
}
