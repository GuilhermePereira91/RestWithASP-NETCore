using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUserRepository
    {
        User ValidadeCredentials(UserVO user);
        User ValidadeCredentials(string username);
        User RefreshUserInfo(User user);
    }
}
