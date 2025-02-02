


namespace FinTracker.Domain.Models;

public sealed class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string HashedPassword { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
    public ICollection<FinTracker.Domain.Models.Transaction> Transactions { get; set; }
    public ICollection<Budget> Budgets { get; set; }
    public ICollection<Category> Categories { get; set; }
}
