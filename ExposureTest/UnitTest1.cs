using System;
using Xunit;
using Xunit.Abstractions;
using ExposureAPI.Resources; 

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
            var service = new ExposureAPI.Resources.CodeSchool.Service();   
            var profile = service.GetCodeSchoolProfile().Result;

            Assert.Equal("ahatch1490", profile.User.UserName);

           
        }
    }
}
