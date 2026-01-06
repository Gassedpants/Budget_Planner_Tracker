using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BudgetPlusPlus.Data;
using BudgetPlusPlus.Domain;
using BudgetPlusPlus.Configurations.Entities; // Needed for the seeding files

namespace BudgetPlusPlus.Data
{
    public class BudgetPlusPlusContext(DbContextOptions<BudgetPlusPlusContext> options) : IdentityDbContext<BudgetPlusPlusUser>(options)
    {
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<BudgetGoal> BudgetGoals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // --- FIX FOR DECIMAL WARNING ---
            // This tells the DB to allow 18 digits total, with 2 decimal places (e.g., 12345.67)

            builder.Entity<Transactions>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18, 2)");

            builder.Entity<BudgetGoal>()
                .Property(p => p.TargetAmount)
                .HasColumnType("decimal(18, 2)");

            builder.Entity<BudgetGoal>()
                .Property(p => p.CurrentAmount)
                .HasColumnType("decimal(18, 2)");

            // --- SEEDING CONFIGURATION (From your previous steps) ---
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}