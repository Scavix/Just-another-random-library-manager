using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library
{
    public class UserManager
    {
        private const string FilePath = "users.json";
        public List<User> Users = new();
        public UserManager()
        {
            LoadUsers();
        }
        public void LoadUsers()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            else
            {
                Users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(FilePath)) ?? new List<User>();
            }
        }
        public void SaveUsers()
        {
            File.WriteAllText(FilePath, JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true }));
        }
        public void Register(User user)
        {
            Users.Add(new User(user.Id, user.Username, user.Password, user.Email, user.FirstName, user.LastName, user.Country, user.Role));
            SaveUsers();
        }
        public void DeRegister(User user)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Id == user.Id)
                {
                    Users.RemoveAt(i);
                    break;
                }
            }
            SaveUsers();
        }
        public bool UpdatePassword(string username, string email, string oldPassword, string newPassword)
        {
            bool sentinel = false;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Username == username && Users[i].Email == email && Users[i].Password == oldPassword)
                {
                    Users[i].Password = newPassword;
                    sentinel = true;
                    break;
                }
            }
            SaveUsers();
            return sentinel;
        }
        public User? GetUserById(string id)
        {
            return Users.Find(u => u.Id == id);
        }
    }
}
