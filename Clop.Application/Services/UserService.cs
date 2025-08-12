using Clop.Domain.Dto.User;
using Clop.Domain.Entity;
using Clop.Domain.Interfaces.Repositories;
using Clop.Domain.Interfaces.Services;
using Clop.Domain.Result;
using Microsoft.EntityFrameworkCore;

namespace Clop.Application.Services;

public class UserService : IUserService
{
    private readonly IBaseRepository<User> _userRepository;
    
    public UserService(IBaseRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<BaseResult<UserDto>> GetUsersAsync()
    {
        var user = await _userRepository.GetAll().FirstOrDefaultAsync();

        var profiles = user.Profiles;

        throw new NotImplementedException();
    }
}