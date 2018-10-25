using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IntelliTect.Coalesce;
using Newtonsoft.Json;

namespace Coalesce.Domain.Services
{
    [Coalesce]
    [Service]
    public interface IWeatherService
    {
        WeatherData GetWeather(AppDbContext parameterDbContext, Location location, DateTimeOffset? dateTime);

        Task<WeatherData> GetWeatherAsync(AppDbContext parameterDbContext, Location location, DateTimeOffset? dateTime);
    }

    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;
        private readonly IInternalConfig _config;

        public WeatherService(IInternalConfig config,  IHttpClientFactory factory)
        {
            _config = config;
            if (string.IsNullOrWhiteSpace(_config.OpenWeatherServiceToken))
            {
                throw new ArgumentNullException(nameof(IInternalConfig.OpenWeatherServiceToken));
            }

            _client = factory.CreateClient();
            _client.BaseAddress = new Uri("http://api.openweathermap.org");
        }


        public WeatherData GetWeather(AppDbContext parameterDbContext, Location location, DateTimeOffset? dateTime)
        {
            Task<WeatherData> task =
                Task.Run(async () => await GetWeatherAsync(parameterDbContext, location, dateTime));
            return task.Result;
        }

        public async Task<WeatherData> GetWeatherAsync(AppDbContext parameterDbContext, Location location,
            DateTimeOffset? dateTime)
        {
            string requestUrl;
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            if (false == string.IsNullOrWhiteSpace(location.Zip))
            {
                requestUrl = $"/data/2.5/weather?zip={location.Zip}&units=imperial&APPID={_config.OpenWeatherServiceToken}";
            }
            else if (false == string.IsNullOrWhiteSpace(location.City))
            {
                requestUrl = $"/data/2.5/weather?q={location.City}&units=imperial&APPID={_config.OpenWeatherServiceToken}";
            }
            else
            {
                throw new ArgumentNullException(nameof(location),
                    "The location doesn't have either a Zip or City value.");
            }


            HttpResponseMessage response = await _client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();

            string stringResult = await response.Content.ReadAsStringAsync();
            var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);

            return new WeatherData
                {Humidity = rawWeather.Main.Humidity, Location = location, TempFahrenheit = rawWeather.Main.Temp};
        }
    }

    public class Location
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class WeatherData
    {
        public double TempFahrenheit { get; set; }

        public double Humidity { get; set; }

        public Location Location { get; set; }
    }

    internal class OpenWeatherResponse
    {
        public string Name { get; set; }

        public IEnumerable<WeatherDescription> Weather { get; set; }

        public Main Main { get; set; }
    }

    internal class WeatherDescription
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }

    internal class Main
    {
        public double Temp { get; set; }
        public double Humidity { get; set; }
    }
}