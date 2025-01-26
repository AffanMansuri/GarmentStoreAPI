using GarmentStoreAPI.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GarmentStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarmentsController : ControllerBase
    {
        private readonly IGarmentsService service;
        public GarmentsController(IGarmentsService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult GetGarments()
        {
            return Ok(service.GetGarments().Data);
        }
    }
}
