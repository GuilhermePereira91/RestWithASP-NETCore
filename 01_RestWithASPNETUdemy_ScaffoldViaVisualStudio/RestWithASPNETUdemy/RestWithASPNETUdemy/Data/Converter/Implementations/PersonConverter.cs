using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null)
                return null;

            return new Person
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Gender = origin.Gender,
                Address = origin.Address,
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null)
                return null;

            return new PersonVO
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Gender = origin.Gender,
                Address = origin.Address,
            };
        }

        public List<Person> Parse(List<PersonVO> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item => Parse(item)).ToList();
            
        }

        public List<PersonVO> Parse(List<Person> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
