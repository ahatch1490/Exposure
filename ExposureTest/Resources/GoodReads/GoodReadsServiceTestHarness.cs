using ExposureAPI.Resources.Client;
using ExposureAPI.Resources.GoodReads;
using ExposureTest.Resources.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Rest.TransientFaultHandling;
using StackExchange.Redis;
using Xunit;
using static ExposureTest.Resources.Client.StubDataLoader; 
using static ExposureTest.Resources.Client.StubConfiguration;

namespace ExposureTest.Resources.GoodReads
{
    public class GoodReadsServiceTestHarness
    {
        [Fact]
        public void ShouldParseGoodreadsReviewResponse()
        {
            var context = new TestClientContext(LoadTestFile("goodreads.xml"));
            var xmlCient = new XMLClient(context); 
            var service = new GoodReadsService(new GoodReadsSettings(GetTestAppsettings()),xmlCient );
            var result = service.GetReviews("1234567");
            Assert.IsType<Response<GoodreadsResponse>>(result); 
        }
    }
}