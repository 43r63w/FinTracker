namespace FinTracker.Domain.Models;

public sealed class Transaction
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }  
    public DateTime CreatedAt { get; set; }    
    public string Description { get; set; } 
    public Guid CategoryId { get; set; }  
    public Category Category { get; set; }
    public Guid UserId { get; set; }   
    public User User { get; set; }
}
