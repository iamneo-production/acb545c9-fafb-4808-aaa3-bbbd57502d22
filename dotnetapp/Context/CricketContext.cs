using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Context
{
    public class CricketContext : DbContext
    {
        public CricketContext(DbContextOptions<CricketContext> options) : base(options) 
        { }
        public DbSet<AdminModel> adminModels { get; set; }
        public DbSet<UserModel> userModels { get; set; }
        public DbSet<LoginModel> loginModels { get; set; }

    }
}
