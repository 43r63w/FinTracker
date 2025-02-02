
using FinTracker.Application.Abstractions;
using FinTracker.Domain.Abstractions;

namespace FinTracker.Application.Services;
public sealed class BudgetService : IBudgetService
{
    private readonly IBudgetRepository  _budgetRepository;
    private readonly IUnitOfWork _unitOfWork;

    public BudgetService(
        IBudgetRepository budgetRepository, 
        IUnitOfWork unitOfWork)
    {
        _budgetRepository = budgetRepository;
        _unitOfWork = unitOfWork;
    }

    public Task<Guid> CreateBudgetAsync()
    {
        throw new NotImplementedException();
    }
}
