namespace FinTracker.Domain.Models;
public sealed class FinancialReport
{
    public Guid Id { get; set; }
    public decimal TotalIncome { get; set; }
    public decimal TotalExpenses { get; set; }
    public decimal NetWorth { get; set; }
    public DateTime ReportDate { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}
