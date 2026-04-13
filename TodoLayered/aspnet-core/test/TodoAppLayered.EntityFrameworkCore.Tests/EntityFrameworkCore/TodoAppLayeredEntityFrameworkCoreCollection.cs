using Xunit;

namespace TodoAppLayered.EntityFrameworkCore;

[CollectionDefinition(TodoAppLayeredTestConsts.CollectionDefinitionName)]
public class TodoAppLayeredEntityFrameworkCoreCollection : ICollectionFixture<TodoAppLayeredEntityFrameworkCoreFixture>
{

}
