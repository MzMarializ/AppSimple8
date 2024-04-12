namespace BlazorApp.Data;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Congelante", "Refrescante", "Fresco", "Templado", "Suave", "C�lido", "Agradable", "Caluroso", "Sofocante", "Abrasador"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }
}
