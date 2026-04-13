using System.Threading.Tasks;

namespace TodoAppLayered.Data;

public interface ITodoAppLayeredDbSchemaMigrator
{
    Task MigrateAsync();
}
