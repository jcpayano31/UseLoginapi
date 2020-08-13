using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserLoginService.Models
{
    public class UserLogin
    {
        public int Userid { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
