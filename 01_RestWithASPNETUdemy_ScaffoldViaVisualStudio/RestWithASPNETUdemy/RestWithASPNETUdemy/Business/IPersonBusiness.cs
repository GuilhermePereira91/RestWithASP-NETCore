using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);
        List<PersonVO> FindAll();
    }
}
