namespace Programmers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 1, 2, 3, 1, 2, 3, 1 };
            int sell = Fruiterer.Solution(3, 4, score);
            Console.WriteLine(sell);
        }
    }
}
