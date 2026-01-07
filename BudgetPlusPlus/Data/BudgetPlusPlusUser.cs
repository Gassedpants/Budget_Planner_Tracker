using Microsoft.AspNetCore.Identity;

namespace BudgetPlusPlus.Data
{
    public class BudgetPlusPlusUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
    }
}
