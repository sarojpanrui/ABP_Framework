using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoAppLayered.Data;
using Volo.Abp.DependencyInjection;

namespace TodoAppLayered.EntityFrameworkCore;

public class EntityFrameworkCoreTodoAppLayeredDbSchemaMigrator
    : ITodoAppLayeredDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTodoAppLayeredDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TodoAppLayeredDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TodoAppLayeredDbContext>()
            .Database
            .MigrateAsync();
    }
}
