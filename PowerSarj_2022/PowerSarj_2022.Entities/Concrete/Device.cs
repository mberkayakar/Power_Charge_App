using PowerSarj_2022.Core.Entities;
using System.Collections.Generic;

namespace PowerSarj_2022.Entities.Concrete
{
    public class Device : IEntity
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }

        // konum bilgisi  
        public string location { get; set; }


        // AC - DC olma durumu 
        public string Type { get; set; }

        public List<Operation> operations { get; set; }

    }
}
