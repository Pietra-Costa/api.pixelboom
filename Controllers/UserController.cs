using System.Net;
using System.Threading.Tasks;
using api.pixelboom.Models;
using api.pixelboom.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.pixelboom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        [HttpGet(Name = "GetList")]
        public async Task<List<User>> GetList()
        {
            var userRepository = new UserRepository(new FirebaseConfig());
            var userList = await userRepository.ListAllUsers();
            return userList;
        }

        [HttpPost(Name = "CreateUser")]
        public HttpStatusCode CreateUser(User user)
        {
            var userRepository = new UserRepository(new FirebaseConfig());
            userRepository.AddUser(user);
            return HttpStatusCode.OK;
        }

        [HttpPatch(Name = "EditUser")]
        public HttpStatusCode EditUser(User user)
        {
            var userRepository = new UserRepository(new FirebaseConfig());
            userRepository.EditUser(user);
            return HttpStatusCode.OK;
        }
    }
}