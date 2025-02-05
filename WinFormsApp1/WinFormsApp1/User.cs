using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class User
    {
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public Roles Role { get; set; } = Roles.User;
        public User(string id, string username, string password, string email, string firstName, string lastName, string country, Roles Role)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Country = country;
            this.Role = Role;
        }
        public User()
        {
        }
    }
}
