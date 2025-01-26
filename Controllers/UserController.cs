using GarmentStoreAPI.IService;
using GarmentStoreAPI.UserModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GarmentStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult Login(LoginDTO loginDTO)
        {
            var result = service.Login(loginDTO);
            if(result.StatusCode == 200)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
