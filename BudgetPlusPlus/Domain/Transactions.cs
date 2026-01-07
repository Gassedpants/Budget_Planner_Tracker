namespace BudgetPlusPlus.Domain
{
    public class Transactions
    {
        public int Id { get; set; }
        public string? UserId { get; set; }

        public TransactionsType Type { get; set; }
        public string? Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }


    }
        public enum TransactionsType
        {
            Income,
            Expense,
        }   
    
}
