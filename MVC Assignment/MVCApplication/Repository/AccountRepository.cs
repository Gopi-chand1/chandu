using MVCApplication.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
/*        private readonly RoleManager<IdentityRole> _roleManager;*/

        public AccountRepository(UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager)/*, 
           , RoleManager<IdentityRole> roleManager*/
        {
            _userManager = userManager;
            _signInManager = signInManager;
/*            _roleManager = roleManager;*/

        }


        public async Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel)
        {
            /*_userManager.AddToRoleAsync();*/

            var user = new ApplicationUser()
            {
                FullName = userModel.FullName,
                Email = userModel.Email,
                UserName = userModel.Email

            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;

        }

        public async Task<SignInResult> PasswordSignInAsync(SignInUserModel signInModel) //Login
        {
            return await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, signInModel.RememberMe, true);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
