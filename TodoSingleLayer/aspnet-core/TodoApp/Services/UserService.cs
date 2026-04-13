using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Entities;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TodoApp.Services;

public class UserService : ApplicationService
{
    private readonly IRepository<User, Guid> _userRepository;
    

    public UserService(IRepository<User, Guid> userRepository)
    {
        _userRepository = userRepository;
    }

   

    public async Task<List<User>> GetListAsync()
    {
        return await _userRepository.GetListAsync();
    }

    public async Task<User> CreateAsync(User input)
    {
        var user = new User
        {
            Name = input.Name,
            Age = input.Age
        };

        await _userRepository.InsertAsync(user);

        return user;
    }

    public async Task DeleteAsync(Guid id)
    {
        await _userRepository.DeleteAsync(id);
    }
}