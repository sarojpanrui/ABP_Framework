using TodoAppLayered.Samples;
using Xunit;

namespace TodoAppLayered.EntityFrameworkCore.Domains;

[Collection(TodoAppLayeredTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TodoAppLayeredEntityFrameworkCoreTestModule>
{

}
