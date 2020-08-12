using System.Collections.Generic;

namespace Models.Domain_Models
{
    public partial class Person
    {
        public Person()
        {
            Location = new HashSet<Location>();
        }

        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonTelephone { get; set; }
        public string PersonAddress { get; set; }

        public virtual ICollection<Location> Location { get; set; }
    }
}
