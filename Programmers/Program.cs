namespace Programmers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ingredient = { 2, 1, 1, 2, 3, 1, 2, 3, 1 };
            int hamberger = MakingHamburgers.Solution(ingredient);
            Console.WriteLine(hamberger);
        }
    }
}
