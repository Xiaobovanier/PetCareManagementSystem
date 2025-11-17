using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystemV2.Models
{
    public class UserAccount
    {
        public int UserId { get; set; }
        public string Username { get; set; } = "";
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
        public byte[] Salt { get; set; } = Array.Empty<byte>();
        public string Role { get; set; } = "Owner"; // Owner / VetStaff / Admin
    }
}
