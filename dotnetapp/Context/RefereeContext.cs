using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Context
{
    public class RefereeContext : DbContext
    {
        public RefereeContext(DbContextOptions<RefereeContext>options) : base (options)
        {

        }
         public DbSet<RefereeModels> refereemodel { get; set; }

        
        //public object Refereetable { get; internal set; }
    }
}
