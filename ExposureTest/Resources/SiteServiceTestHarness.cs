
using System.IO;
using System.Linq;
using ExposureAPI.Models;
using ExposureTest.Resources.Client;
using Npgsql;
using SqlKata.Compilers;
using SqlKata.Execution;
using Xunit;
using Microsoft.Extensions.Configuration;

namespace ExposureTest.Resources
{
    
    public class SiteServiceTestHarness
    {
        [Fact]
        public void ShouldHitDB()
        {
            var Configuration = StubConfiguration.GetTestAppsettings(); 

            var str = Configuration["ConnectionString"]; 
            var connection = new NpgsqlConnection(
                  
                str //"Host=localhost;Port=5432;Username=ahatch1490;Database=exposure;"
            );

            var compiler = new PostgresCompiler();

            var q  = new QueryFactory(connection,compiler);
            var sites = q.Query("sites").Limit(10).Get<Site>();
            Assert.True(sites.Count() == 1);
            
        }
        
    }
}