﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; }
        
   
    }
}
