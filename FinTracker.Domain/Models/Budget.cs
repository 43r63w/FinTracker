using FinTracker.Domain.Models;

namespace FinTracker.Domain.Models;

public sealed class Budget
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}
