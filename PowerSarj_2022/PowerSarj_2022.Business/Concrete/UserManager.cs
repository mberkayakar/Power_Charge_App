using AutoMapper;
using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Core.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete;
using PowerSarj_2022.Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PowerSarj_2022.DataAccess.Abstract
{

    public class UserManager : GenericManager<User>, IUserService
    {

        private readonly IUserRepository _userService;

        public UserManager(IUserRepository genericRepository) : base(genericRepository)
        {

            _userService = genericRepository;

        }

        public IEnumerable<User> GetAllUserİnformation(Expression<Func<User, bool>> filter, params Expression<Func<User, object>>[] children )
        {
            return _userService.GetAllUserİnformation(filter,children);
        }

        public void SaveUser(UserSaveDto usermodule)
        {
            var model = usermodule;


            // Action delegate alıyor ve 
            var configuration = new MapperConfiguration(opt =>
            {
                opt.CreateMap<UserSaveDto, User>().ForMember(x=> x.userid , dto => dto.MapFrom(x=> x.UserId));
                opt.CreateMap<UserSaveDto, User>().ForMember(x => x.date, dto => dto.MapFrom(x => x.date));

                //opt.CreateMap<User, UserSaveDto>(); // Tersten mapleme için gerçerlidir. 

            });
            // yukarıdaki kod üzerinden hangi nesneleri birbirlerine 
            // dönebileceğinin analizi yapılmakyadır .

            var mapper = configuration.CreateMapper(); // IMApper şeklinde bir
            // nesne dönmektedir. 

            var model2 = mapper.Map<User>(usermodule);


            Console.WriteLine("Deneme 1 ,2 ,3 ");


        }
    }
}
