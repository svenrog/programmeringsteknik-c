using System.Globalization;

namespace months
{
    public class SettingsFactory
    {
        //private string IConfiguration _configuration;

        static SettingsFactory()
        {
            
        }

        public static CultureInfo GetCulture()
        {
            string cultureSetting = /*_configuration["culture"] ?? */"sv-SE";

            return new CultureInfo(cultureSetting);
        }
    }
}