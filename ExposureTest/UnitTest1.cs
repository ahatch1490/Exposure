using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ExposureAPI.Resources.Client;
using Xunit;
using Xunit.Abstractions;
using ExposureAPI.Resources.GoodReads;
using ExposureTest.Resources.Client;
using ExposureTest.Resources.GoodReads;


namespace ExposureTest
{
    public class UnitTest1
    {
        private ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
//            var client = new GoodReadsService(Settings,); //GoodReadsClient(new Settings(Config.GetTestAppsettings()));
//            var actual = client.GetReviews("1604160");
//            Assert.IsType<GoodreadsResponse>(actual);
//            Assert.NotNull(actual.Reviews);
//            Assert.True(actual.Reviews.Count > 0); 
//            
        }

        [Fact]
        public void Test2()
        {            
            var data = StubDataLoader.LoadTestFile("foo.xml");
            var xmlClient = new XMLClient(new TestClientContext(data));
            var response = xmlClient.GetAsync<GoodreadsResponse>("");
            var value = response.Item; 
            Assert.IsType<GoodreadsResponse>(value);
            Assert.True(value.Reviews.Count  > 0 );
        }
    }

    [XmlRoot("foo"), XmlType("foo")]
    public class Foo
    {
        [XmlElement("bars")]
        public string Bar { get; set; }
        
    }
    
   
    public class Bar
    {
        
    }
}
