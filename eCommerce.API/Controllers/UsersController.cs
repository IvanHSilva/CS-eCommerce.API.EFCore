using eCommerce.API.Repositories;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        // Dependency Injection
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository) {
            _repository = repository;
        }

        // Http Methods
        // Select All
        [HttpGet]
        public IActionResult GetUsers() {
            var users = _repository.GetUsers();
            return Ok(users);
        }

        // Select by id
        [HttpGet("{id}")]
        public IActionResult GetUser(int id) {
            var user = _repository.GetUser(id);
            if (user == null) return NotFound("Usuário não encontrado!");
            return Ok(user);
        }

        // Insert
        [HttpPost]
        public IActionResult InsertUser([FromBody] User user) {
            _repository.InsertUser(user);
            return Ok(user);
        }

        // Update
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromBody] User user, int id) {
            _repository.UpdateUser(user);
            return Ok(user);
        }

        // Delete
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id) {
            _repository.DeleteUser(id);
            return Ok();
        }
    }
}
