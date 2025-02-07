using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string F_name { get; set; }
        public string L_name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string Role { get; set; }   //admin user doctor 
        public int? Age { get; set; }

        public int PhoneNumber { get; set; }
        public bool isDeleted { get; set; }

        public List<Pets> Adoptedpets { get; set; } = new List<Pets>();


    }
}
