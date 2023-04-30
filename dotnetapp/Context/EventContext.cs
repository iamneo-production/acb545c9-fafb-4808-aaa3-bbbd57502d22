using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Context
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> Options) : base(Options) 
        {

        }
        public DbSet<EventModel> EventTable { get; set; }
    }
}
