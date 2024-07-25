using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Base;

namespace RestWithASPNETUdemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T T);
        T FindById(long id);
        T Update(T item);
        void Delete(long id);
        List<T> FindAll();
        bool Exists(long id);
        List<T> FindWithPagedSearch(string query);
        int  GetCount(string query);

    }
}
