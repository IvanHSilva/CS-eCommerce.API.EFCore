using eCommerce.Models;

namespace eCommerce.API.Repositories {
    public interface IUserRepository {

        List<User> GetUsers();
        User GetUser(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
