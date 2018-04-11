using System;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExposureAPI.Resources.CodeSchool 
{
    public class Service
    {
        public  Service()
        {

                
        }

        public async Task<Profile> GetCodeSchoolProfile()
        {
            HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Add("Accept", "application/vnd.moxi-platform+json;version=1");

            var result = await client.GetAsync("https://www.codeschool.com/users/ahatch1490.json");
            var content = result.Content;
      
            var json = await content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<Profile>(json, new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include
            });

        }
    }
}
