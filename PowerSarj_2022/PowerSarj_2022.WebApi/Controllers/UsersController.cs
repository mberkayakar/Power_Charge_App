using Microsoft.AspNetCore.Mvc;
using PowerSarj_2022.DataAccess.Abstract;

namespace PowerSarj_2022.WebApi.Controllers
{


    [ApiController]
    [Route("[Controller]")]
    public class UsersController : ControllerBase
    {


        private readonly IUserService _userService;
        public UsersController(IUserService userservice)
        {
            _userService = userservice;
        }





        [HttpGet("users")]
        public IActionResult Index()
        {
            var model = _userService.GetAll();



            return Ok(model);
        }
    }
}
