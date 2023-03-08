using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class User
    {
        public User()
        {
            RefreshTokens = new HashSet<RefreshToken>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
