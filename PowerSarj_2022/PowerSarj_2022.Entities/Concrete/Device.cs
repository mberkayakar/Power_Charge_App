﻿using PowerSarj_2022.Core.Entities;
using System;
using System.Collections.Generic;

namespace PowerSarj_2022.Entities.Concrete
{
    public class Device : IEntity
    {
        public int Id { get; set; }

        public string location { get; set; }


        // AC - DC olma durumu 
        public string Type { get; set; }

        public virtual List<Operation> operations { get; set; }
        public virtual List<AllowedSites> allowedSites { get; set; }
        public string site { get; set; }
        public string state { get; set; } // sanırım 0 1 gibi bişi 
        public decimal price { get; set; }
        public string charginguser { get; set; }
        public string mobilecharging { get; set; }
        public string  devicename { get; set; }
        public DateTime  date { get; set; }


       
        // Navigation Property
        public  User User { get; set; }
        public string UserId { get; set; }





    }
}
