using Task2;

var service = new DiscountService();
var calc = new PriceCalculator();

// Delegate for Add & Subtract
Calculate c1 = service.Add;
Calculate c2 = service.Subtract;

Console.WriteLine("Add: " + c1(10, 5));
Console.WriteLine("Subtract: " + c2(10, 5));

// Discount Strategy delegate
Console.WriteLine(calc.CalculateFinalPrice(1000, service.FestivalDiscount));
Console.WriteLine(calc.CalculateFinalPrice(1000, service.SeasonalDiscount));
Console.WriteLine(calc.CalculateFinalPrice(1000, service.NoDiscount));

// Lambda discount (30% off)
Console.WriteLine(calc.CalculateFinalPrice(1000, p => p * 0.70));
