using System;
using System.Collections.Generic;
using System.Linq;
using SqlKata.Execution;
namespace ExposureAPI.Models
{
    public class ContentSectionService
    {
        private readonly QueryFactory _factory; 
        
        public ContentSectionService(QueryFactory qf)
        {
            _factory = qf;  
        }
        public IEnumerable<ContentSection> GetSiteContentSections(int siteid)
        {
            return _factory.Query("content_sections").Where("siteid", siteid).Get<ContentSection>(); 
        }

        public ContentSection InsertContentSection(ContentSection section)
        {
            var uuid = Guid.NewGuid();
            _factory.Query("content_sections").Insert(new
            {
                siteid = section.SiteId,   
                content = section.Content,
                uuid = uuid
            });
            return GetContentSection(uuid);
        }

        public ContentSection GetContentSection(Guid uuid)
        {
            return _factory.Query("content_sections").Where("uuid", uuid).Get<ContentSection>().First(); 
        }

        public ContentSection GetContentSection(int contentSectionId)
        {
            return _factory.Query("content_sections").Where("content_section_id",contentSectionId).Get<ContentSection>().First(); 
        }
        
        
    }
}