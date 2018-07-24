using System.Threading.Tasks;
using ExposureAPI.Resources.Client;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ExposureTest.Resources.GoodReads
{
    public class TestClientContext : IContextClient
    {
        private string Data { get; }

        public TestClientContext(string data)
        {
            Data = data; 
        }

        public async Task<string> GetRequestAsync(string url)
        {
            var mockTask = new Task<FooBar>(() => new FooBar(Data));
            mockTask.Start();

            return  mockTask.Result.GetTestData();
        }
    }

    internal class FooBar
    {
        private readonly string Data;

        public FooBar(string data)
        {
            Data = data; 
        }
        public string GetTestData()
        {
            return Data;
        }
    }
}