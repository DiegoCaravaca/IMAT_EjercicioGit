using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userId = "202411577";
            int firstDigit = int.Parse(userId[0].ToString());
            int lastDigit = int.Parse(userId[^1].ToString());
            Console.WriteLine($"id: {userId} -> {firstDigit} / {lastDigit} = {Divide(firstDigit, lastDigit)}");
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y) => x * y;

        static int Divide(int x, int y) => x / y;
    }
}