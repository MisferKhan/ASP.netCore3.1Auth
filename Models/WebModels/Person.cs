using System.Collections.Generic;

namespace Models.WebModels
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonTelephone { get; set; }
        public string PersonAddress { get; set; }
        public string LocationName { get; set; }
        public List<Person> Persons { get; set; }
    }
}
