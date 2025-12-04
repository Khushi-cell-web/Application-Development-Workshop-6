using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate int Calculate(int a, int b);
    public delegate double DiscountStrategy(double price);

    public class DiscountService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;

        public double FestivalDiscount(double price) => price * 0.8;
        public double SeasonalDiscount(double price) => price * 0.9;
        public double NoDiscount(double price) => price;
    }

}
