namespace condominium_backend;

public class WeatherForecast
{
    public DateTime? Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF { get; set; }

    public string Summary { get; set; }

    //public WeatherForecast()
    //{
    //    this.TemperatureF = 32+ (int)(TemperatureC / 0.5556);
    //    var s = Summary;
    //    Summary = "xxxx"; 
    //}

    public WeatherForecast(DateTime date)
    {
            this.Date = date;
    }
}
