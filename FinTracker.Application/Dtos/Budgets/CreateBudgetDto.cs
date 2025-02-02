

namespace FinTracker.Application.Dtos.Budgets;
public sealed record CreateBudgetDto(
    decimal Amount,
    DateTime StartDate,
    DateTime EndDate,
    Guid CategoryId,
    Guid UserId);

