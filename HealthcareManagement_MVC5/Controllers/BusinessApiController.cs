using System.Web.Http;
using HealthcareManagement_MVC5.Services;

namespace HealthcareManagement_MVC5.Controllers
{
    [RoutePrefix("api/business")]
    public class BusinessApiController : ApiController
    {
        private readonly BusinessService _service = new BusinessService();

        [HttpGet, Route("dashboard")]
        public IHttpActionResult Dashboard()
        {
            return Ok(_service.GetDashboard());
        }

        [HttpPost, Route("create")]
        public IHttpActionResult Create(CreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Reference))
                return BadRequest("Reference is required.");

            return Ok(_service.Create(request.Reference));
        }
    }

    public class CreateRequest
    {
        public string Reference { get; set; }
    }
}
