using BudgetPlusPlus.Configurations.Entities; 
using BudgetPlusPlus.Data; 
using BudgetPlusPlus.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore; 

namespace BudgetPlusPlus.Data
{
    public class BudgetPlusPlusContext(DbContextOptions<BudgetPlusPlusContext> options) : IdentityDbContext<BudgetPlusPlusUser>(options)
    {
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<SavingsGoal> Categories { get; set; }
        public DbSet<SavingsGoal> SavingsGoals { get; set; }
        public DbSet<SavingsGoal> CurrentAmount { get; set; }
        public DbSet<SavingsGoal> GoalName { get; set; }


        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new RoleSeed());
        }
    }
}
