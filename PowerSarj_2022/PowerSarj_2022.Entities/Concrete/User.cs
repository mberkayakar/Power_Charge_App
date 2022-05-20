using PowerSarj_2022.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSarj_2022.Entities.Concrete
{
    public class User : IEntity
    {
        public int _id { get; set; }
        public string userid { get; set; }
        public string cardid { get; set; }
        public string username { get; set; }
        public string site { get; set; }
        public string password { get; set; }

        List<Device> devices { get; set; }

        List<Operation> operations { get; set; }
        public DateTime date { get; set; }
        public int __v { get; set; }
        public decimal balance { get; set; }
        

        "chargingdevice": "",
        "updatedAt": "2022-05-16T19:25:30.296Z"



    }
}
