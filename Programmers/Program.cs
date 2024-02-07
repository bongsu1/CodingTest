namespace Programmers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] wires = { { 1, 3 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, { 4, 6 }, { 4, 7 }, { 7, 8 }, { 7, 9 } };
            int split = SplittingThePowerGridInTwo.Solution(9, wires);
            Console.WriteLine(split);
        }
    }
}
