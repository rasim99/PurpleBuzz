using Microsoft.EntityFrameworkCore;
using PB401PurpleBuzz.Entities;

namespace PB401PurpleBuzz.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {
            
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<AboutService> AboutServices { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }
        public DbSet<Plan> Plans { get; set; }
    }
}
