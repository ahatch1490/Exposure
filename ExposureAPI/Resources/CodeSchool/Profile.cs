using System;
using Newtonsoft.Json; 
namespace ExposureAPI.Resources.CodeSchool
{
    public class Profile
    {
        public Profile()
        {
        }

        [JsonProperty("user")]
        public User User {get;set;} 
        [JsonProperty("courses")]
        public Courses Courses { get; set; }
    }
}
