using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindById(long id);
        Book Update(Book book);
        void Delete(long id);
        List<Book> FindAll();
        bool Exists(long id);
    }
}
