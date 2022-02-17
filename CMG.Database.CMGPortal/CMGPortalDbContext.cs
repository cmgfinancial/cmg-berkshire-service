using CMG.Database.CMGPortal.Models;
using System.Data.Entity;
namespace CMG.Database.CMGPortal
{
    public class CMGPortalDbContext : DbContext
    {
       
        public CMGPortalDbContext()
            : base("name=CMGPortalDbContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public  DbSet<MySite> MySites { get; set; }

        public  DbSet<Channel> Channels { get; set; }

        public DbSet<Company> Companies { get; set; }

        public  DbSet<Member> Members { get; set; }

        public DbSet<MemberTeam> MemberTeams { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<MemberSubscriptions> MemberSubscriptions { get; set; }



    }
}