using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortlandProgrammingProject.Data;

namespace PortlandProgrammingProject.DbContext
{
    public class UsersDbContext : IdentityDbContext<IdentityUser>
    {
        public UsersDbContext(DbContextOptions options): base(options) { }

        public DbSet<User> Profiles { get; set; }
    }
}
