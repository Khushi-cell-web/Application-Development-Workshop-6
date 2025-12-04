using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class NumberProcessor
    {
        public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
            {
                if (condition(n))
                    Console.WriteLine(n);
            }
        }
    }

}
