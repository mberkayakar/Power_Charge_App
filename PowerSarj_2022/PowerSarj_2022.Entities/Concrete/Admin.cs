using PowerSarj_2022.Core.Entities;

namespace PowerSarj_2022.Entities.Concrete
{
    public class Admin :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }



    }
}
