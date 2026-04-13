using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TodoAppLayered.Data;

/* This is used if database provider does't define
 * ITodoAppLayeredDbSchemaMigrator implementation.
 */
public class NullTodoAppLayeredDbSchemaMigrator : ITodoAppLayeredDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
