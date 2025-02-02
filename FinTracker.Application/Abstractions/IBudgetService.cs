

namespace FinTracker.Application.Abstractions;
public interface IBudgetService
{
    Task<Guid> CreateBudgetAsync();
}
