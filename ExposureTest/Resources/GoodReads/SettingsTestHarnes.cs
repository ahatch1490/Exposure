using System.IO;
using Microsoft.Extensions.Configuration;
using Xunit;
using ExposureAPI.Resources.GoodReads;
using Xunit.Sdk;


namespace ExposureTest.Resources.GoodReads
{
    public class SettingsTestHarnes
    {
    

        [Fact]
        public void ShouldHaveGoodReadsKey()
        {
            var settings = new GoodReadsSettings(GetTestAppsettings());
            var expected = "foo";
            Assert.Equal(expected,settings.key);
        }
        
        
        private static IConfiguration GetTestAppsettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("TestData/appsettings.json");

            return  builder.Build();        
        }
    }
    
    
}