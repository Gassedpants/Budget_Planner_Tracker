using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore; 
using BudgetPlusPlus.Data; 
using BudgetPlusPlus.Configurations.Entities; 

namespace BudgetPlusPlus.Data
{
    public class BudgetPlusPlusContext(DbContextOptions<BudgetPlusPlusContext> options) : IdentityDbContext<BudgetPlusPlusUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new RoleSeed());
        }
    }
}
