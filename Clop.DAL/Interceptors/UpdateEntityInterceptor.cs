using Clop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Clop.DAL.Interceptors;

public class UpdateEntityInterceptor : SaveChangesInterceptor
{
    public override ValueTask<int> SavedChangesAsync(SaveChangesCompletedEventData eventData, int result,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var dbContext = eventData.Context;
        if (dbContext == null)
        {
            return base.SavedChangesAsync(eventData, result, cancellationToken);
        }
        
        var entries = dbContext.ChangeTracker.Entries<IAuditable>()
            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
            .ToList();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Property(x => x.CreatedAt).CurrentValue = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Property(x => x.UpdatedAt).CurrentValue = DateTime.UtcNow;
            }
        }
        
        return base.SavedChangesAsync(eventData, result, cancellationToken);
        
    }
}