using Volo.Abp.Modularity;

namespace TodoAppLayered;

[DependsOn(
    typeof(TodoAppLayeredDomainModule),
    typeof(TodoAppLayeredTestBaseModule)
)]
public class TodoAppLayeredDomainTestModule : AbpModule
{

}
