using System.Data;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userId = "202411570";
            int firstDigit = int.Parse(userId[0].ToString());
            int lastDigit = int.Parse(userId[^1].ToString());

            Console.WriteLine($"id: {userId} -> {firstDigit} / {lastDigit} = {Divide(firstDigit, lastDigit)}");

            Console.WriteLine($"id: {userId} -> {firstDigit} - {lastDigit} = {Subtract(firstDigit, lastDigit)}");
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Multiply(int x, int y) => x * y;
        static int? Divide(int x, int y)
        {
           if (y == 0)
            {
                Console.WriteLine("No se puede dividir por 0");
                return null;
            }
            else
            {
                return x / y;
            }
        }
        static int Subtract(int x, int y) => x - y;
    }
}