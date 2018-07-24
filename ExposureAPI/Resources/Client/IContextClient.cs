using System.Threading.Tasks;
namespace ExposureAPI.Resources.Client
{


        /// <summary>
        ///  Wrapper around the Client to allow stubbing of client interactions.
        /// </summary>
        public interface IContextClient

        {
                Task<string> GetRequestAsync(string url);
//            Task<string> PostRequestAsync<T>(string url, T obj);
//            Task<string> PutRequestAsync<T>(string url, T obj);
//            Task<string> DeleteRequestAsync(string url);
        }
}
