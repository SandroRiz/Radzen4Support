namespace Radzen4Support.Models;

public class WeatherStation
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Altitude { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public int StationCategoryId { get; set; }

    public string StationTypeId { get; set; } = null!;

    public bool IsOfficial { get; set; }

    public bool IsOnline { get; set; }

    public int? CivisId { get; set; }
}
