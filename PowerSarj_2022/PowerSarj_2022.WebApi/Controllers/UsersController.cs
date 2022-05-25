using Microsoft.AspNetCore.Mvc;
using PowerSarj_2022.Business.Concrete.DTO;
using PowerSarj_2022.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete.Dtos;

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

         


        [HttpGet] // Complete
        public IActionResult GetAllUsers()
        {

            var model = _userService.GetAllUsers();

            if (model != null)
            {
                 return Ok(model);
            }
            else
            {
                return NotFound("Sistemde Kayıtlı herhangi bir kullanıcı bulunamadı ");
            }

        }

        [HttpGet("{_id}")]  // Complete
        public IActionResult GetAllUsersWithId(string _id)
        {

            var model = _userService.GetAllUsers(x=> x.userid== _id);

            if (model != null)
            {
                return Ok(model);
            }
            else
            {
                return NotFound("Sistemde Kayıtlı herhangi bir kullanıcı bulunamadı ");
            }

        }

        [HttpGet("bysite/{sitename}")] // Complete
        public IActionResult GetAllUserWithSiteParameter(string sitename)
        {
            var model = _userService.GetAllUsers(x => x.site == sitename);

            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }


        [HttpPost]  // Complete 
        public IActionResult SaveUser(UserSaveDto userdto)
        {
            _userService.SaveUser(userdto); 
            return Ok(userdto);
        }


        [HttpPost("addoperation")]  // Complete
        public IActionResult AddOperationFromUser(AddOperationFromUser userdto)
        {
            if (userdto != null)
            {
                _userService.UpdatedUserModel(filter: x=> x.userid ==  userdto.userid ,addoperationfromuser: userdto);
                return Ok(userdto);

            }
            else
            {
                return BadRequest();
            }

        }

       
        
        [HttpPost("login")]  // Bitmedi buna JWT eklenecek // burada userlarin login olma isteklerini düşündüm projede anladıgım kadarı ile burası admin için kullanılmış.
        public IActionResult Loginevent(UserLoginDto userlogindto)
        {
            if (userlogindto.Password != "" && userlogindto.UserId != "")
            {
                var model = _userService.UserLogin(userlogindto);
                if (model != null)
                {
                    return Ok(model);
                }
                else
                {
                    return NotFound();
                }
            }

            return BadRequest("Lütfen Geçerli Bir şifre ve kullanıcıbilgisi giriniz ");
        }



        [HttpDelete("{id}")]   // Complete // verilen user id ye göre user in bilgilerinin silinmesi
        public IActionResult DeleteUser(string id)
        {
            if (id != null && id!= "" )
            {
                var model = _userService.DeleteUserWithUserId(id);
                if (model != null)
                {
                    return Ok(model);
                }
                else
                {
                    return NotFound();
                }
            }

            return BadRequest("Lütfen Geçerli Bir şifre ve kullanıcıbilgisi giriniz ");
        }

        [HttpPut("{id}")]  // Complete 
        public IActionResult UpdateUserİnformation(UserUpdateDTO userdto)
        {

            if (userdto.userid!=null)
            {
                _userService.UpdatedUserModel(userdto);
            return Ok(userdto);

            }
            else
            {
                return NotFound("Bu şekilde bir user sistemde kayıtlı değildir. Bu sebepten ötürü güncelleme gerçekleşmemiştir.");
            }
        }

        
        #region Eski Kodlar 

        //[HttpPost]  // fils ve operation kaydedemiyor tek problemi o onun üzerinde yogunlaşacagız ..
        //public IActionResult SaveUSer([FromBody] User user)
        //{
        //    if (user != null)
        //    {
        //        _userService.Add(user);


        //        return Ok(user);
        //    }

        //    return BadRequest("İşlem tamamlanamadı bir problem meydana geldi ");


        //}


        //[HttpGet("aaa")]
        //public IActionResult Index()
        //{
        //    // https://www.c-sharpcorner.com/blogs/eager-loading-in-repository-pattern-entity-framework-core

        //    //var model = _userService.GetAllUserİnformation(
        //    //    filter: x => x.userid == "" && x.balance != 0  ,  ;



        //    //if (model != null)
        //    //{
        //    //    return Ok(model);

        //    //}
        //    //else
        //    //{
        //    //    return NotFound(model);
        //    //}


        //    return Ok();

        //}
        #endregion

    }
}
