using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Models;
using Models.Domain_Models;

namespace Implementation
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public List<Person> GetAll()
        {
            return personRepository.GetAll().ToList();
        }


        public Person GetPersonById(int personId)
        {
            var person = personRepository.Find(personId);
            return person;
        }

        public bool Add(Person person)
        {
            personRepository.Add(person);
            personRepository.SaveChanges();
            return true;
        }

        public bool Update(Person person)
        {
            personRepository.Update(person);
            personRepository.SaveChanges();
            return true;
        }
    }
}
