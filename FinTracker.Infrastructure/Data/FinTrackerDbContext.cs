
using FinTracker.Domain.Abstractions;
using FinTracker.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTracker.Infrastructure.Data;
public sealed class FinTrackerDbContext : DbContext, IUnitOfWork
{
    public FinTrackerDbContext(DbContextOptions<FinTrackerDbContext> options) : base(options)
    {
    }

    internal DbSet<User> Users { get; set; }

    internal DbSet<Transaction> Transactions { get; set; }

    internal DbSet<Budget> Budgets { get; set; }

    internal DbSet<Subscription> Subscriptions { get; set; }

    internal DbSet<FinancialReport> FinancialReports { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Budget>().HasData(
            [
                new Budget
                {
                    Id = Guid.NewGuid(),
                    Amount = 1000.00m,
                    StartDate = new DateTime(2025, 01, 01),
                    EndDate = new DateTime(2025, 12, 31),
                    CategoryId = Guid.NewGuid(),
                    UserId = Guid.NewGuid()
                },
                new Budget
                {
                    Id = Guid.NewGuid(),
                    Amount = 1500.00m,
                    StartDate = new DateTime(2025, 02, 01),
                    EndDate = new DateTime(2025, 11, 30),
                    CategoryId = Guid.NewGuid(),
                    UserId = Guid.NewGuid()
                }
            ]
        );

    }

}
