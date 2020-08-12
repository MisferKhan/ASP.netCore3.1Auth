using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Models.Domain_Models;

namespace Interfaces
{
    public interface IPersonService
    {
        public List<Person> GetAll();
        public Person GetPersonById(int personId);
        public bool Add(Person person);
        public bool Update(Person person);
    }
}
