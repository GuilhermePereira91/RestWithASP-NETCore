using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implemetations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        Person Update(Person person);
        void Delete(long id);
        List<Person> FindAll();
    }
}
