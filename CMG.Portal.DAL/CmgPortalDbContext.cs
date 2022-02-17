using System.Data.Entity;

namespace CMG.Portal.DAL
{
    public partial class CmgPortalDbContext : DbContext
    {
        public CmgPortalDbContext()
            : base("name=CmgPortalDbContext")
        {
        }

        public virtual DbSet<AccessType> AccessTypes { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchType> BranchTypes { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<MemberBranch> MemberBranches { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberSubscriptionLog> MemberSubscriptionLogs { get; set; }
        public virtual DbSet<MemberSubscription> MemberSubscriptions { get; set; }
        public virtual DbSet<MemberTeam> MemberTeams { get; set; }
        public virtual DbSet<MemberType> MemberTypes { get; set; }
        public virtual DbSet<MySite> MySites { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<TargetType> TargetTypes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TestimonialTreeData> TestimonialTreeDatas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VanityURL> VanityURLs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
