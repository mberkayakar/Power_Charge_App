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

        public IEnumerable<User> GetAllUserİnformation(Expression<Func<User, bool>> filter, params Expression<Func<User, object>>[] children )
        {
            return _userService.GetAllUserİnformation(filter,children);
        }

        public void SaveUser(UserSaveDto usermodule)
        { 

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new UserToUserSaveMapping() );
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
    }
}
