using System;
using System.Collections.Generic;
using System.Text;

namespace API.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Excluido { get; set; }
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
        public string Profile { get; set; } = string.Empty;
        public ICollection<Registration> Registrations { get; set; }

    }

}