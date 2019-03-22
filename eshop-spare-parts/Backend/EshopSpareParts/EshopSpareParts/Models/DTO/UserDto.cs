using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.DTO
{
    public class UserDto
    {
        public int id { get; set; }

        public string email { get; set; }
        public string phoneNumber { get; set; }
        
        public string password { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string town { get; set; }

        public string townNumber { get; set; }

        public string townStreet { get; set; }

        public bool isAnonymous { get; set; }

        public bool isAdmin { get; set; }

        public bool agreeTransaction { get; set; }

        public bool agreeRegistration { get; set; }

        public string token { get; set; }
    }
}