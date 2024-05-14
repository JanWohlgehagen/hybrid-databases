
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorkflowModels.Models;

namespace Workflow.Context
{
    public class Context : DbContext
    {

        public DbSet<DamageReport> DamageReports { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Workshop> Workshops { get; set; }


        protected readonly IConfiguration Configuration;

        public Context(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("pgdb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<DamageReport>()
                .HasKey(dr => dr.Id);

            modelBuilder.Entity<DamageReport>()
                .HasOne(dr => dr.Customer);

            modelBuilder.Entity<Workshop>()
                .HasKey(ws => ws.Id);

            modelBuilder.Entity<Workshop>()
                .HasMany(ws => ws.DamageReports);
        }
    }
}
