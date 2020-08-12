using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Mappers.ModelMappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.Api.Controllers
{
    [Route("api/PersonApi")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        #region Private

        private readonly IPersonService personService;

        #endregion

        #region Constructor

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        #endregion

        #region Public

        // GET: api/Person
        [HttpGet]
        public IActionResult Get()
        {
            var persons = personService.GetAll().Select(x=>x.ConverToWebModel());
            return Ok(persons);
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult  Get(int id)
        {
            var person = personService.GetPersonById(id).ConverToWebModel();
            return Ok(person);
        }

        #endregion
    }
}
