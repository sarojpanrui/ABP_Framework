using TodoAppLayered.Samples;
using Xunit;

namespace TodoAppLayered.EntityFrameworkCore.Applications;

[Collection(TodoAppLayeredTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TodoAppLayeredEntityFrameworkCoreTestModule>
{

}
