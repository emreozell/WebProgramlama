using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOdev.Models
{
    public class UserDetails:IdentityUser
    {

        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
