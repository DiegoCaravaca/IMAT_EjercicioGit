namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userId = "202411577";
            int firstDigit = int.Parse(userId[0].ToString());
            int lastDigit = int.Parse(userId[^1].ToString());
            Console.WriteLine($"id: {userId} -> {firstDigit} + {lastDigit} = {firstDigit +lastDigit}");
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}