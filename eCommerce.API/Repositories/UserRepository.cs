using eCommerce.API.Database;
using eCommerce.Models;

namespace eCommerce.API.Repositories {
    public class UserRepository : IUserRepository {

        private readonly eCommerceContext _db;

        // Contructor
        public UserRepository(eCommerceContext db) {
            _db = db;
        }

        // Queries
        public List<User> GetUsers() {
            return _db.Users.OrderBy(u => u.Id).ToList();
        }

        public User GetUser(int id) {
            return _db.Users.Find(id)!;
        }

        // Unit of Works
        public void InsertUser(User user) {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        
        public void UpdateUser(User user) {
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public void DeleteUser(int id) {
            _db.Users.Remove(GetUser(id));
            _db.SaveChanges();
        }
    }
}
