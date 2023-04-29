using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Context
{
    public class VenueContext : DbContext
    {
        public VenueContext(DbContextOptions<VenueContext> options) : base(options)
        {

        }
        public DbSet<VenueModel> Venuetable { get; set; }
    }
    
    }
