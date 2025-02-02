

using FinTracker.Domain.Abstractions;
using FinTracker.Domain.Models;
using FinTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FinTracker.Infrastructure.Repositories;
public sealed class BudgetRepository : IBudgetRepository
{
    private readonly FinTrackerDbContext _finTrackerDbContext;

    public BudgetRepository(FinTrackerDbContext finTrackerDbContext)
    {
        _finTrackerDbContext = finTrackerDbContext;
    }

    public void Delete(Guid id)
    {
        _finTrackerDbContext.Budgets
            .Where(_ => _.Id == id)
            .ExecuteDelete();
    }

    public async Task<IReadOnlyCollection<Budget>> GetAllAsync()
    {
        return await _finTrackerDbContext.Budgets.ToListAsync();
    }

    public async Task<Budget> GetAsync(Guid id)
    {
        return await _finTrackerDbContext.Budgets.FirstOrDefaultAsync(e => e.Id == id);
    }

    public void Insert(Budget budget)
    {
        _finTrackerDbContext.Budgets.Add(budget);
    }

    public void Update(Budget budget)
    {
        _finTrackerDbContext.Budgets
            .Where(e => e.Id == budget.Id)
            .ExecuteUpdate(b => b
            .SetProperty(_ => _.Amount, budget.Amount)
            .SetProperty(_ => _.Category, budget.Category)
            .SetProperty(_ => _.StartDate, budget.StartDate)
            .SetProperty(_ => _.EndDate, budget.EndDate)
            );
    }
}
