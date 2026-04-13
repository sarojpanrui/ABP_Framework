using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using TodoAppLayered.Dtos;


namespace TodoAppLayered.TodoInterfaces
{
    public interface ITodoServices: IApplicationService
    {
       Task<List<TodoItemDto>> GetListAsync();
        Task<TodoItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    }
}
