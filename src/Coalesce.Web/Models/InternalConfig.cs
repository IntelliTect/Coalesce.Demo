using Coalesce.Domain.Services;

namespace Coalesce.Web.Models
{
    public class InternalConfig : IInternalConfig
    {
        public string OpenWeatherServiceToken { get; set; }
    }
}