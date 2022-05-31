using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerSarj_2022.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete.Dtos;

namespace PowerSarj_2022.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminsController:ControllerBase
    {
        private readonly Logger<AdminsController> _logger;
        private readonly IAdminService _service;
        public AdminsController(Logger<AdminsController> logger, IAdminService service )
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public IActionResult GetAdmin(AdminLoginDto adminLoginDto)
        {
            if (adminLoginDto.AdminId!= null && adminLoginDto.adminpassword !="")
            {
                

            }
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult GetAdmin()
        {
            return Ok();
        }
    }
}
