using PowerSarj_2022.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSarj_2022.Entities.Concrete
{
    public class Device : IEntity
    {
        int Id;
        public string DeviceName { get; set; }

        // konum bilgisi 
        //public double latfirst { get; set; }
        //public double latsecond { get; set; }
        public string location { get; set; }


        // AC - DC olma durumu 
        public string Type { get; set; }

        public List<Operation> operations { get; set; }

    }
}
