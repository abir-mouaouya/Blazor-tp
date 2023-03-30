
using BlazorApp3.Models;
using System.Net.Http.Json;

namespace BlazorApp3.Data
{
    public class weatherForecastService
    {
        HttpClient Http;
        public weatherForecastService() { }
        public weatherForecastService(HttpClient http) {
           Http = http;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            return forecasts;
        }
    }
}
