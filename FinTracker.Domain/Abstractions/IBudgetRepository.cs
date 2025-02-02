


using FinTracker.Domain.Models;

namespace FinTracker.Domain.Abstractions;
public interface IBudgetRepository
{
    void Insert(Budget budget);

    void Update(Budget budget);

    void Delete(Guid id);

    Task<IReadOnlyCollection<Budget>> GetAllAsync();

    Task<Budget> GetAsync(Guid id);
}
