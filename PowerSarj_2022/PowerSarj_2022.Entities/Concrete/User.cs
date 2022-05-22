using PowerSarj_2022.Core.Entities;
using System;
using System.Collections.Generic;


namespace PowerSarj_2022.Entities.Concrete
{
    public class User : IEntity
    {

        // Sistemdeki userlar (otomatları kullanan kullanıcılar yani )
        public int _id { get; set; }  // PK 
        public string userid { get; set; }
        public string cardid { get; set; }
        public string username { get; set; }
        public string site { get; set; }  // bilmiyorum 
        public string password { get; set; }
        List<Device> devices { get; set; }  // sadece string olarak isim geliyo oda device id nin kendi ismi // yüksek ihtimal dto kullanabilirm 
        List<Operation> operations { get; set; }  // Operasyon listesi 
        List<Fill> fills { get; set; } // 1 user in  birden çok fill i olabilir 

        public DateTime date { get; set; }
        public int __v { get; set; }
        public decimal balance { get; set; }
        public string chargingdevice { get; set; }
        public DateTime? updatedAt { get; set; }

    }
}
