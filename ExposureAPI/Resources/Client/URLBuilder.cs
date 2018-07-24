
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
namespace ExposureAPI.Resources.Client
{

    /// <summary>
    /// used internaly to generate urls to the moxiworks api
    /// </summary>
    public class UriBuilder
    {


        private  string Host { get; }
        private Uri Url { get; }

        public UriBuilder(string host, string path = "")
        {
            Url = new Uri(host + path); 
            Host = host;
           
        }

        public Dictionary<string, string> QueryParameters { get; } =  new Dictionary<string, string>(); 


       
        public string GetUrl()
        {
            return Url + BuildQueryString();
        }

        public string BuildQueryString()
        {
            if (QueryParameters.Count <= 0)
            return string.Empty;
                
            return "?" + string.Join("&", QueryParameters.Select(q => $"{  HttpUtility.UrlEncode(q.Key)}={HttpUtility.UrlEncode(q.Value)}"));
        }

        public UriBuilder AddQueryParameter(string key, string value)
        {
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
            {
                return this; 
            }
            
            QueryParameters.Add(key,value);

            return this;
        }

        public UriBuilder AddQueryParameter(string key, int? value)
        {
            if (string.IsNullOrWhiteSpace(key) || ! value.HasValue)
            {
                return this; 
            }
            
            QueryParameters.Add(key,value.Value.ToString());
            return this;
        }
        
        public UriBuilder AddQueryParameterAsDateString(string key, DateTime? value)
        {
            if (string.IsNullOrWhiteSpace(key) || !value.HasValue)
            {
                return this; 
            }

            QueryParameters.Add(key, value.Value.ToShortTimeString());
            return this; 
        }

        public UriBuilder AddQueryParameterAsTimeStamp(string key, DateTime? value)
        {
            if (string.IsNullOrWhiteSpace(key) || !value.HasValue)
            {
                return this; 
            }

            QueryParameters.Add(key, GetTimeStamp(value.Value).ToString());
            return this; 
        }



        private int GetTimeStamp(DateTime value)
        {
            return (int)Math.Truncate(value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        }
        
       

    }
}
