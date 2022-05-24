using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Business.Concrete.DTO;
using PowerSarj_2022.Core.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete;
using PowerSarj_2022.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PowerSarj_2022.DataAccess.Abstract
{



    public class UserManager : GenericManager<User>, IUserService
    {

        private readonly IUserRepository _userService;
        private readonly DbContext _db;

        public UserManager(IUserRepository genericRepository , DbContext db) : base(genericRepository)
        {
            _db = db;
            _userService = genericRepository;

        }

        public IEnumerable<UserListDto> GetAllUsers(Expression<Func<User, bool>> filter = null)
        {
            dynamic model;

            if (filter != null)
            {
                model = _db.Set<User>().Include(x => x.fills).Include(x => x.operations).Include(y => y.devices).Where(filter).ToList();

            }
            else
            {
                model = _db.Set<User>().Include(x => x.fills).Include(x => x.operations).Include(y => y.devices).ToList();

            }


            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new UserListMapper());
            });

            var mapper = configuration.CreateMapper();

            var model2 = mapper.Map<List<UserListDto>>(model);

            #region Boş Kodlar 


            //List<string> suruculer = new List<string>();

            //List<Device> devices = new List<Device>();
            //List<Operation> opt = new List<Operation>();
            //List<Fill> fills = new List<Fill>();


            //foreach (var item in model)
            //{
            //    foreach (var item2 in item.devices)
            //    {
            //        suruculer.Add(item2.devicename);
            //    }

            //    var gecicimodel = model.FirstOrDefault(x => x.userid == item.userid);
            //    gecicimodel.devices
                


            //}





            #endregion


            return model2;
        }

        public IEnumerable<User> GetAllUserİnformation(Expression<Func<User, bool>> filter, params Expression<Func<User, object>>[] children)
        {
            throw new NotImplementedException();
        }
         
        public void SaveUser(UserSaveDto usermodule)
        {

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new UserToUserSaveMapping());
            });

            var mapper = configuration.CreateMapper();

            var model = mapper.Map<User>(usermodule);

            model.date = DateTime.Now;
            model.devices = new List<Device>();


            foreach (var item in usermodule.devices)
            {
                try
                {
                    dynamic singledevice = _db.Set<Device>().FirstOrDefault(x => x.devicename == item);
                    if (singledevice != null)
                    {
                        model.devices.Add(singledevice);
                    }

                }
                catch (ArgumentException ex)
                {
                }
            }

            _userService.Add(model);




        }

        public User UpdatedUserModel( AddOperationFromUser addoperationfromuser , Expression<Func<User, bool>> filter = null)
        {
            var model = _db.Set<User>().Where(filter).Include(x=> x.fills).FirstOrDefault();

            if (model != null)
            {
                if (model.fills == null)
                {
                    model.fills = new List<Fill>();
                }
                model.fills.AddRange(addoperationfromuser.fills);
            }
            else
            {
                return null; 
            }

            _userService.Update(model);

            return model;



        }

        public User UserLogin(UserLoginDto userlogindto)
        {


             dynamic model = _userService.GetAll(x=> x.userid == userlogindto.UserId && x.password == userlogindto.Password).FirstOrDefault();
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
