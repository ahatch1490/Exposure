using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ExposureAPI.Resources.GoodReads;
using Microsoft.WindowsAzure.Storage.Blob.Protocol;

namespace ExposureAPI.Resources.Client
{
    public class XMLClient :IXMLClient
    {

        private readonly IContextClient _client; 
        public XMLClient(IContextClient client)
        {
            _client = client; 
        }
        public  Response<T> GetAsync<T>(string url)
        {
            var result =  _client.GetRequestAsync(url); 

            var serializer = new XmlSerializer(typeof(T));
            
            using (TextReader reader = new StringReader(result.Result))
            {
                return new Response<T> {Item = (T) serializer.Deserialize(reader)};
            }
        }
        
    }
}