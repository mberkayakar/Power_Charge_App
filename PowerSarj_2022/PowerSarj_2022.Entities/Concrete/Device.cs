using PowerSarj_2022.Core.Entities;
using System;
using System.Collections.Generic;
 
namespace PowerSarj_2022.Entities.Concrete
{
    public class Device : IEntity
    {
        int Id;
        public string DeviceName { get; set; }

        // konum bilgisi  
        public string location { get; set; }


        // AC - DC olma durumu 
        public string Type { get; set; }

        public List<Operation> operations { get; set; }

    }
}
