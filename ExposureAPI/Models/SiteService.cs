using System.Collections.Generic;
using System.Spatial;
using SqlKata;
using SqlKata.Execution;

namespace ExposureAPI.Models
{
    public class SiteService
    {
        private readonly QueryFactory _factory; 
        
        public SiteService(QueryFactory qf)
        {
            _factory = qf;  
        }

        public IEnumerable<Site> GetSites()
        {
            return _factory.Query("sites").Get<Site>(); 
        }
    }
}