using SQLite;

namespace UserManager
{
    public class UserRepository
    {
        private readonly SQLiteConnection _connection;
        public UserRepository()
        {
            string databasePath =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserData.db");
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<UserModel>();
        }
        public bool Add(string username, string password, string email)
        {
             UserModel userModel = new UserModel
            {
                UserName = username,
                Password = password,
                Email = email
            };

            _connection.Insert(userModel);
            return true;
     
        }
        public List<UserModel> GetAll()
        {
            return _connection.Table<UserModel>().ToList();
        }
    }
}
