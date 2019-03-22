using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.Db
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Town { get; set; }
        public string TownNumber { get; set; }
        public string TownStreet { get; set; }

        public bool IsAnonymous { get; set; }
        public bool AgreeTransaction { get; set; }
        public bool AgreeRegistration { get; set; }

        public bool IsAdmin { get; set; }

        public DateTime Created { get; set; }

    }
}