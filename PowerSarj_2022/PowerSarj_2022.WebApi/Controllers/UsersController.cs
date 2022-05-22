using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.DataAccess.Abstract;
using PowerSarj_2022.DataAccess.Concrete.Context.EfContext;
using PowerSarj_2022.Entities.Concrete;
using System.Linq;

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




        [HttpGet("aaa")]
        public IActionResult Index()
        {
            // https://www.c-sharpcorner.com/blogs/eager-loading-in-repository-pattern-entity-framework-core

            //var model = _userService.GetAllUserİnformation(
            //    filter: x => x.userid == "" && x.balance != 0  ,  ;



            //if (model != null)
            //{
            //    return Ok(model);

            //}
            //else
            //{
            //    return NotFound(model);
            //}


            return Ok();

        }



        [HttpGet]
        public IActionResult Index2()
        {



            //var model = _userService.GetAll();


            //var model = db.Users.Include(x => x.operations).ToList() ;

            //if (model!= null)
            //{
                return Ok();

       


        }

        [HttpPost]  // fils ve operation kaydedemiyor tek problemi o onun üzerinde yogunlaşacagız ..
        public IActionResult SaveUSer([FromBody] User user)
        {
            if (user != null)
            {
                _userService.Add(user);


                return Ok(user);
            }

            return BadRequest("İşlem tamamlanamadı bir problem meydana geldi ");
            

        }
    }
}
