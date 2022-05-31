using PowerSarj_2022.Core.Entities;

namespace PowerSarj_2022.Entities.Concrete
{
    public class Admin :IEntity
    {
        public string _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string  Email { get; set; }

    }
}
