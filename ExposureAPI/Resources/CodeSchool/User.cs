using System;
using System.Collections.Generic;
using Newtonsoft.Json; 
using ExposureAPI.Resources.CodeSchool; 
namespace ExposureAPI.Resources
{
    public class User
    {
        public User()
        {
        }
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("member_since")]
        public string MemberSince { get; set; }
        [JsonProperty("total_score")]
        public int TotalScore { get; set; }
        [JsonProperty("gravitar")]
        public string Gravitar { get; set; }
 

    }
      
}
