namespace FluentTesting
{
    public static class Resources
    {
        // List of cities
        public static List<City> Cities = new List<City>
        {
            new City { Name = "Seattle", Code = "98101" },
            new City { Name = "Redmond", Code = "98052" },
            new City { Name = "Bellevue", Code = "98004" },
            new City { Name = "Kirkland", Code = "98033" },
            new City { Name = "Issaquah", Code = "98029" },
            new City { Name = "Sammamish", Code = "98074" },
            new City { Name = "Renton", Code = "98055" },
            new City { Name = "Kent", Code = "98030" },
            new City { Name = "Auburn", Code = "98002" },
            new City { Name = "Federal Way", Code = "98003" }
        };
    }
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public IEnumerable<City> Cities { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
