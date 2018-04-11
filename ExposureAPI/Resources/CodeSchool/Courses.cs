using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace ExposureAPI.Resources.CodeSchool
{
    public class Courses
    {
        [JsonProperty("completed")]
        public List<Course> Completed { get; set; }
        [JsonProperty("in_progress")]
        public List<Course> InProgress { get; set; }
        public Courses()
        {
            
        }
    }
}
