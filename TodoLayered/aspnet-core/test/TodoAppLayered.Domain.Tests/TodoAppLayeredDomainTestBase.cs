using Volo.Abp.Modularity;

namespace TodoAppLayered;

/* Inherit from this class for your domain layer tests. */
public abstract class TodoAppLayeredDomainTestBase<TStartupModule> : TodoAppLayeredTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
