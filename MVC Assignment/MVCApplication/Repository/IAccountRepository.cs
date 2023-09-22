using MVCApplication.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace MVCApplication.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInUserModel signInModel);
        Task SignOutAsync();
    }
}