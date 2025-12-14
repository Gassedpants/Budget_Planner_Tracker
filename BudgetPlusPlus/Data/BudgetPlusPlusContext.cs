using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BudgetPlusPlus.Data;

namespace BudgetPlusPlus.Data
{
    public class BudgetPlusPlusContext(DbContextOptions<BudgetPlusPlusContext> options) : IdentityDbContext<BudgetPlusPlusUser>(options)
    {
    }
}
