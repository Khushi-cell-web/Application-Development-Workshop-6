using System.Drawing;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle { Length = 10, Width = 5 };
            Console.WriteLine($"Area = {rect.Area}");
            Console.WriteLine($"Perimeter = {rect.Perimeter}");

        }
    }
}
