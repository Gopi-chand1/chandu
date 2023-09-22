﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVCApplication.Helpers
{
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options)
            :base(userManager, roleManager, options)
        {

        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("UserFullName", user.FullName ?? ""));
            return identity;
        }
    }
}
