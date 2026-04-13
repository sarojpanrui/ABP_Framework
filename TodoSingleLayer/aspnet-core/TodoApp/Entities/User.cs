using Volo.Abp.Domain.Entities;

namespace TodoApp.Entities;

public class User : BasicAggregateRoot<Guid>
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}