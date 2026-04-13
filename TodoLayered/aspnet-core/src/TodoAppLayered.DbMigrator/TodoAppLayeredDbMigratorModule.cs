using TodoAppLayered.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TodoAppLayered.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TodoAppLayeredEntityFrameworkCoreModule),
    typeof(TodoAppLayeredApplicationContractsModule)
    )]
public class TodoAppLayeredDbMigratorModule : AbpModule
{
}
