using Volo.Abp.Modularity;

namespace TodoAppLayered;

[DependsOn(
    typeof(TodoAppLayeredApplicationModule),
    typeof(TodoAppLayeredDomainTestModule)
)]
public class TodoAppLayeredApplicationTestModule : AbpModule
{

}
