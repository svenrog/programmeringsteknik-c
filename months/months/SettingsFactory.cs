using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace months
{
    public static class SettingsFactory
    {
        public static IConfiguration _configuration;

        public static SettingsFactory()
        {
            var builder = new ConfigurationBuilder();

           _configuration = builder.AddJsonFile("appsettings.json", true, false).Build();

            return;
        }

        public static CultureInfo GetCulture()
        {
            string cultureSetting = _configuration.["culture"] ?? "sv-SE";

            return new CultureInfo(cultureSetting);

        }
    }
}
