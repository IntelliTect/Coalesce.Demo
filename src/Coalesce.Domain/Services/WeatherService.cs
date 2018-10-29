using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IntelliTect.Coalesce;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace Coalesce.Domain.Services
{
    [Coalesce]
    [Service]
    public interface IWeatherService
    {
        WeatherData GetWeather(AppDbContext parameterDbContext, Location location);

        Task<WeatherData> GetWeatherAsync(AppDbContext parameterDbContext, Location location);
    }

    public class WeatherService : IWeatherService
    {
        private const double CacheLifetime = 60;
        private readonly HttpClient _client;
        private readonly IInternalConfig _config;
        private readonly IMemoryCache _cache;

        public WeatherService(IInternalConfig config,  IHttpClientFactory factory, IMemoryCache cache)
        {
            _config = config;
            if (string.IsNullOrWhiteSpace(_config.OpenWeatherServiceToken))
            {
                throw new ArgumentNullException(nameof(IInternalConfig.OpenWeatherServiceToken));
            }

            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri("http://api.openweathermap.org");
        }


        public WeatherData GetWeather(AppDbContext parameterDbContext, Location location)
        {
            Task<WeatherData> task =
                Task.Run(async () => await GetWeatherAsync(parameterDbContext, location));
            return task.Result;
        }

        public async Task<WeatherData> GetWeatherAsync(AppDbContext parameterDbContext, Location location)
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

            if (_cache.TryGetValue(requestUrl, out WeatherData weatherData))
            {
                return weatherData;
            }

            string stringResult = await _client.GetStringAsync(requestUrl);
            var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);

            weatherData = new WeatherData
                {Humidity = rawWeather.Main.Humidity, Location = location, TempFahrenheit = rawWeather.Main.Temp};

            _cache.Set(requestUrl, weatherData, TimeSpan.FromMinutes(CacheLifetime));

            return weatherData;

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