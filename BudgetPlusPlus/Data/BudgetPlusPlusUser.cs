using Microsoft.AspNetCore.Identity;

namespace BudgetPlusPlus.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class BudgetPlusPlusUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
    }
}
