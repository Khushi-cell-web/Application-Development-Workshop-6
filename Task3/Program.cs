namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var np = new NumberProcessor();
            int[] nums = { 2, 4, 7, 12, 18, 3 };

            np.ProcessNumbers(nums, n => n % 2 == 0);       // Even numbers
            np.ProcessNumbers(nums, n => n > 10);          // > 10

        }
    }
}
