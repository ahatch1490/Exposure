using System.IO;
using Microsoft.Extensions.Configuration;

namespace ExposureTest
{
    public class Config
    {
        public static IConfiguration GetTestAppsettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            return  builder.Build();        
        }
    }
}