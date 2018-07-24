using Microsoft.Extensions.Configuration;

namespace ExposureAPI.Resources.GoodReads
{
    public interface IGoodReadsSettings
    {
        IConfiguration Configuration { get; set; }
        string key { get; }
        string Host { get; }
    }

    public class GoodReadsSettings : IGoodReadsSettings
    {
        public  IConfiguration Configuration { get; set; }
        

        private string _key;   
        public string key => _key ?? (_key = Configuration["goodreads:Key"]);

        private string _host;
        public string Host => _host ?? (_host = Configuration["goodreads:Host"]);  
        

        public GoodReadsSettings(IConfiguration config)
        {
            Configuration = config;
        }
    }
}