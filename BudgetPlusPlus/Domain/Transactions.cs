namespace BudgetPlusPlus.Domain
{
    public class Transactions : BaseDomainModel
    {
        public string? Title { get; set; }       // e.g. "Salary", "Lunch"
        public string? Category { get; set; }    // e.g. "Food", "Transport"
        public decimal Amount { get; set; }     
        public string? Type { get; set; }        // "Income" or "Expense"
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        
        public string? UserId { get; set; }
    }
}
