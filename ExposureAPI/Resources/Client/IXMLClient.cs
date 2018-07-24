using System.Threading.Tasks;
namespace ExposureAPI.Resources.Client
{
    public interface IXMLClient
    {
        Response<T> GetAsync<T>(string url);
    }
}