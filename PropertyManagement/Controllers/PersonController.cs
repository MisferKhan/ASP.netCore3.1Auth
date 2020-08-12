using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Mappers.ModelMappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Models.WebModels;
using PropertyManagement.Models;

namespace PropertyManagement.Controllers
{
    public class PersonController : Controller
    {
        public IPersonService personService;

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        public async Task<ActionResult<Person>> Index()
        {
            var persons = new Person {Persons = personService.GetAll().Select(x=>x.ConverToWebModel()).ToList()};

            return await Task.FromResult(result: View("Index", persons));
        }

        [HttpGet]
        public async Task<ActionResult<Person>> Create(int? id)
        {
            Person person;
            person = id != null ? personService.GetPersonById(id.Value).ConverToWebModel() : new Person();

            return await Task.FromResult(result: View("Create", person));
        }

        [HttpPost]
        public async Task<ActionResult<Person>> AddOrUpdate(Person person)
        {
            var personToSave = person.ConverToDomainModel();
            if (person.PersonId > 0)
            {
                personService.Update(personToSave);
            }
            else
            {
                personService.Add(personToSave);
            }

            return await Task.FromResult(result: View("Create", person));
        }
    }
}
