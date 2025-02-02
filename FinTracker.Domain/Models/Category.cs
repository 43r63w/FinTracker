using System.Transactions;

namespace FinTracker.Domain.Models;

public sealed class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }  
    public ICollection<Transaction> Transactions { get; set; } 
}
