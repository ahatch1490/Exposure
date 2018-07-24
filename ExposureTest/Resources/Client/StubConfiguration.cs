using System.IO;
using Microsoft.Extensions.Configuration;

namespace ExposureTest.Resources.Client
{
    public class StubConfiguration
    {
        public static IConfiguration GetTestAppsettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("TestData/appsettings.json");

            return  builder.Build();        
        }
    }
}