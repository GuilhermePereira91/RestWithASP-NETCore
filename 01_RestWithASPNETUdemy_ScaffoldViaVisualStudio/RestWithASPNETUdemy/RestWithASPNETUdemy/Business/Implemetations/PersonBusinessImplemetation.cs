using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;

namespace RestWithASPNETUdemy.Business.Implemetations
{
    public class PersonBusinessImplemetation : IPersonBusiness
    {
        private volatile int count;

        private readonly IRepository<Person> _repository;

        public PersonBusinessImplemetation(IRepository<Person> repository)
        { 
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }        

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }        
    }
}
