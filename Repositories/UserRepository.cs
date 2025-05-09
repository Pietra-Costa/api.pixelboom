using api.pixelboom.Models;
using Firebase.Database.Query;

namespace api.pixelboom.Repositories
{
    public class UserRepository
    {
        private readonly FirebaseConfig _firebaseConfig;
        public UserRepository(FirebaseConfig firebaseConfig) { 
            _firebaseConfig = firebaseConfig;
        }

        public async Task<List<User>> ListAllUsers() {
            return (await _firebaseConfig.Client.Child("Users").OnceAsync<User>()).Select(item => item.Object ).ToList();
           

        }

        public async Task AddUser(User user)
        {
           await _firebaseConfig.Client.Child("Users").Child(user.Id.ToString()).PutAsync(user);
        }

        public async Task EditUser (User user)
        {
            await _firebaseConfig.Client.Child("Users").PutAsync(user);
        }
    }
}
