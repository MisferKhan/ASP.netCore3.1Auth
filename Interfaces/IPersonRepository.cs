using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Models.Domain_Models;

namespace Interfaces
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
    }
}
