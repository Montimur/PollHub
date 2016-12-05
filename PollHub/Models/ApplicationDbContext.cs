using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace PollHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Vote> Votes { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Ballot> Ballots { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}