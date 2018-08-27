using System.Collections.Generic;
using ExposureAPI.Resources.GoodReads;
using Microsoft.AspNetCore.Mvc;

namespace ExposureAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class GoodreadsController: ControllerBase
    {

        private readonly IGoodReadsService _service;  
        public GoodreadsController(IGoodReadsService service)
        {
            _service = service;  
        }

        [HttpGet("{Id}")]

        public ICollection<Review> Get(string Id)
        {
            var response = _service.GetReviews(Id);
            return response.Item.Reviews; 
        }
    }
}