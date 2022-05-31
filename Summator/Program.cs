namespace Summator
{


internal class Program
{
    static void Main(string[] args)
    {
            long result = Summator.Sum(new long[] { 1, 2, 3, 4, 5, 6 });
            if (result ==21)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

            long expected = Summator.Average(new long[] {5, 10, 15 });
            if (result == 10)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

        }
}
}
