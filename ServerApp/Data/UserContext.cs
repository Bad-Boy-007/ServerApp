using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Data
{
    public class UserContext:IdentityDbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
    }
}
