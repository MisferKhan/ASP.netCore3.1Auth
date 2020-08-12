using Models.Domain_Models;

namespace Mappers.ModelMappers
{
    public static class PersonMapper
    {
        public static Person ConverToDomainModel(this Models.WebModels.Person source)
        {
            return new Person
            {
                PersonId = source.PersonId,
                PersonName = source.PersonName,
                PersonAddress = source.PersonAddress,
                PersonTelephone = source.PersonTelephone
            };
        }

        public static Models.WebModels.Person ConverToWebModel(this Person source)
        {
            var names = source.PersonName.Split(' ');
            return new Models.WebModels.Person
            {
                PersonId = source.PersonId,
                PersonName = source.PersonName,
                PersonTelephone = source.PersonTelephone,
                PersonAddress = source.PersonAddress,
            };
        }
    }
}