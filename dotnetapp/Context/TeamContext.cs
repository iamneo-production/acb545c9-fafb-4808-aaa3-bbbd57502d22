using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Context
{
    public class TeamContext:DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options)
        {

        }
        public DbSet<TeamModel> teamModels { get; set; }
    }
}
