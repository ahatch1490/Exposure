using Microsoft.AspNetCore.Razor.Language;

namespace ExposureAPI.Resources.Client
{
    public class Response<T>
    {
        public T Item { get; set; } 
    }
}