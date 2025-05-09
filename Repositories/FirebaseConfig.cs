using Firebase.Database;

namespace api.pixelboom.Repositories
{
    public class FirebaseConfig
    {
        private readonly FirebaseClient _client;
        public FirebaseConfig() {
            _client = new FirebaseClient("https://pixelboom-885ba-default-rtdb.firebaseio.com/");
        }

        public FirebaseClient Client => _client;
    }
}
