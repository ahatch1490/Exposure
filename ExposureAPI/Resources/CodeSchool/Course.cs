using System;
using Newtonsoft.Json;
namespace ExposureAPI.Resources.CodeSchool
{
    public class Course
    {
        [JsonProperty("name")]
        public string Name {get; set; } 
        [JsonProperty("course_url")]
        public string URL { get; set; }
        [JsonProperty("badge")]
        public string Badge { get; set; }
        public Course()
        {
        }
    }
}
