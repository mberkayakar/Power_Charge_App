using PowerSarj_2022.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSarj_2022.Entities.Concrete.Dtos
{
    public class UserListDto : IDto
    {
        public decimal balance { get; set; }
        public string cardid { get; set; }
        public DateTime date { get; set; }

        //public List<string> devices { get; set; }
        public List<OperationDto> operations { get; set; }
        public string password { get; set; }
        public string site { get; set; }
        public string UserId { get; set; }
        public string username { get; set; }


    }

    public class OperationDto
    {
     

        public string operation { get; set; }
        public double energy { get; set; }
        public decimal amount { get; set; }
        public int duration { get; set; }
        public DateTime date { get; set; }



    }
}
