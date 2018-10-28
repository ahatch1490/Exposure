using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;
using SqlKata.Execution;

namespace ExposureAPI.Models
{
    public class Site
    {
        public int SiteId { get; set; }
        public Guid  UUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}