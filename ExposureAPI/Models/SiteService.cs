using System;
using System.Collections.Generic;
using System.Linq;
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

        public Site InserSite(Site site)
        {
            site.UUID = Guid.NewGuid(); 
            _factory.Query("sites").Insert(new
            {
                title = site.Title    , 
                description = site.Description,
                uuid = site.UUID
                
            });
            return GetSite(site.UUID);


        }

        public Site GetSite(int siteId)
        {
            return _factory.Query("sites").Where("siteid", siteId).Get<Site>().First();
        }

        public Site GetSite(Guid uuid)
        {
            return _factory.Query("sites").Where("uuid", uuid).Get<Site>().First();

        }

        public Site Update(Site site)
        {
            int id = _factory.Query("sites").Where("siteid", site.SiteId).Update( new
            {
                siteid = site.SiteId,
                title = site.Title,
                description = site.Description
            });
            return GetSite(id);
        }
    }
}