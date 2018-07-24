using System;
using System.Collections.Immutable;
using Xunit;
using System.Configuration;
using UriBuilder = ExposureAPI.Resources.Client.UriBuilder;


namespace ExposureTest.Resources.Client
{
    public class URlBuilderFixture
    {
        [Fact]
        public void ShouldReturnDefaultUrl()
        {
            var builder = new UriBuilder("https://foo.bar.com","/api"); 
            Assert.Equal("https://foo.bar.com/api",builder.GetUrl());
        }

        [Fact]
        public void ShouldHandleTimeStamps()
        {
            var builder = new UriBuilder("https://foo.bar.com", "/api");
            builder.AddQueryParameterAsTimeStamp("since_epoc", Convert.ToDateTime("2018-01-01"));
            Assert.Equal("https://foo.bar.com/api?since_epoc=1514793600",builder.GetUrl());
        }

    }
    
}