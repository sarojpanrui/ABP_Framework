using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoAppLayered.Dtos;
using TodoAppLayered.Entity;
using TodoAppLayered.TodoInterfaces;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq;

namespace TodoAppLayered.TodoServices
{
    public class TodoServices : ApplicationService, ITodoServices
    {
        private readonly IRepository<TodoItem, Guid> _todoServices;

        public TodoServices(IRepository<TodoItem , Guid> todoServices )
        {
           _todoServices = todoServices;
        }

        public Task<TodoItemDto> CreateAsync(string text)
        {
            var todoItem = new TodoItem
            {
                Text = text
            };
            return _todoServices.InsertAsync(todoItem).ContinueWith(t =>
            {
                var createdItem = t.Result;
                return new TodoItemDto
                {
                    Id = createdItem.Id,
                    Text = createdItem.Text
                };
            });
        }

        public async Task DeleteAsync(Guid id)
        {
            await _todoServices.DeleteAsync(id);
        }


        public async Task<List<TodoItemDto>> GetListAsync()
        {
            var items = await _todoServices.GetListAsync();
            return items
                .Select(item => new TodoItemDto
                {
                    Id = item.Id,
                    Text = item.Text
                }).ToList();
        }

    }
}
