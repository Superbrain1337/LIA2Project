using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LIA2Project.Models
{
    public class User : IdentityUser
    {

        public Users Users { get; set; }
    }
}
