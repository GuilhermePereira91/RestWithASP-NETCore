using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindById(long id);
        Book Update(Book book);
        void Delete(long id);
        List<Book> FindAll();
    }
}
