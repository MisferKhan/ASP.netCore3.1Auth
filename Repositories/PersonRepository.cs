using Interfaces;
using Models.Domain_Models;
using Repositories.Models;

namespace Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(PropertyContext context) : base(context)
        {
        }
    }
}
