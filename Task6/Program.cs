using Task6;

var tours = new List<TourBooking>
{
    new TourBooking { CustomerName="Ram", Destination="Dubai", Price=25000, DurationInDay=5, IsInternational=true },
    new TourBooking { CustomerName="Sita", Destination="Pokhara", Price=8000, DurationInDay=3, IsInternational=false },
    new TourBooking { CustomerName="Hari", Destination="Thailand", Price=18000, DurationInDay=6, IsInternational=true },
    new TourBooking { CustomerName="Gita", Destination="Chitwan", Price=12000, DurationInDay=5, IsInternational=false }
};

// Filters
var filtered = tours
    .Where(t => t.Price > 10000 && t.DurationInDay > 4);

// Transform (Projection)
var projected = filtered.Select(t => new
{
    t.CustomerName,
    t.Destination,
    Category = t.IsInternational ? "International" : "Domestic",
    t.Price
});

// Sort: Domestic first then International (then sort by Price)
var sorted = projected
    .OrderBy(t => t.Category)
    .ThenBy(t => t.Price);

// Display
foreach (var t in sorted)
{
    Console.WriteLine($"Name: {t.CustomerName}, Destination: {t.Destination}, " +
                      $"Category: {t.Category}, Price: {t.Price}");
}
