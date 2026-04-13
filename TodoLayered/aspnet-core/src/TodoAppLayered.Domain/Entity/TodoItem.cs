using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace TodoAppLayered.Entity
{
   public class TodoItem: BasicAggregateRoot<Guid>
    {
        public string Text { get; set; } = string.Empty;

    }
}
