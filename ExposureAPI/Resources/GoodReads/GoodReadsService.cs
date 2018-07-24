using System.Threading.Tasks;
using ExposureAPI.Resources.Client;

namespace ExposureAPI.Resources.GoodReads
{

    public class GoodReadsService : IGoodReadsService
    {
        private readonly IGoodReadsSettings _settings;
        private readonly IXMLClient _xmlClient;  
        public GoodReadsService(IGoodReadsSettings settings, IXMLClient xmlClient)
        {
            _xmlClient = xmlClient; 
            _settings = settings; 
        }
        
        public Response<GoodreadsResponse> GetReviews(string userId)
        {
          //  https://www.goodreads.com/review/list/1604160.xml?key=XjRNur6c74UDbjqHsZ5Iw&v=2
            var builder = new UriBuilder($"{_settings.Host}/review/list/{userId}.xml").AddQueryParameter("v", "2")
                .AddQueryParameter("key", _settings.key)
                .AddQueryParameter("shelf","programming");
        
            return  _xmlClient.GetAsync<GoodreadsResponse>(builder.GetUrl()); 
        }
    }
}