namespace HakatonApp.Web.Data.Data
{
    using HakatonApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Quest> Quests { get; set; }

        public DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Voucher>()
                .HasOne<User>();
        }
    }
}
