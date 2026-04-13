using Volo.Abp.Modularity;

namespace TodoAppLayered;

public abstract class TodoAppLayeredApplicationTestBase<TStartupModule> : TodoAppLayeredTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
