using Microsoft.EntityFrameworkCore;
using Purple_Buzz.Entities;

namespace Purple_Buzz.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Aim> Aims { get; set; }
        public DbSet<Works> Works { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
