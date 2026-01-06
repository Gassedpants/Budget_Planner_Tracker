namespace BudgetPlusPlus.Domain
{
    public class BudgetGoal: BaseDomainModel
    {
        public string? GoalName { get; set; }      // e.g. "Holiday Fund"
        public decimal TargetAmount { get; set; }  
        public decimal CurrentAmount { get; set; } 
        public DateTime? TargetDate { get; set; }  // When do you want to reach this goal?

        public string? UserId { get; set; }

    }
}
