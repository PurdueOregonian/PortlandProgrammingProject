using PortlandProgrammingProject.Authentication;
using Microsoft.AspNetCore.Identity;

namespace PortlandProgrammingProject.Services
{
    public interface IAuthService
    {
        public Task<IdentityResult> RegisterUser(LoginInfo loginInfo);
        public Task<LoginResult> Login(LoginInfo loginInfo);
    }
}
