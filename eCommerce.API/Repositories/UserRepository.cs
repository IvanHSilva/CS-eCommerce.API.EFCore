using eCommerce.Models;

namespace eCommerce.API.Repositories {
    public class UserRepository : IUserRepository {

        // User list
        public static List<User> _db = new List<User>();

        public List<User> GetUsers() {
            return _db;
        }

        public User GetUser(int id) {
            return _db.FirstOrDefault(x => x.Id == id)!;
        }

        public void InsertUser(User user) {
            _db.Add(user);
        }
        
        public void UpdateUser(User user) {
            _db.Remove(GetUser(user.Id));
            _db.Add(user);
        }

        public void DeleteUser(int id) {
            _db.Remove(GetUser(id));
        }
    }
}
