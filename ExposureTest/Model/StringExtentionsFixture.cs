using ExposureAPI.Models;
using Xunit;

namespace ExposureAPITest
{
    public class StringExtentionsFixture
    {
        [Fact]
        public void CanTitlize()
        {
            Assert.Equal("Foo","foo".Titlize()); 
        }
        
     
    }
}