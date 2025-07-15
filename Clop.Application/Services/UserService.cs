using Clop.Domain.Dto.User;
using Clop.Domain.Entity;
using Clop.Domain.Interfaces.Repositories;
using Clop.Domain.Interfaces.Services;
using Clop.Domain.Result;

namespace Clop.Application.Services;

public class UserService : IUserService
{
    private readonly IBaseRepository<User> _userRepository;
    
    public UserService(IBaseRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }
    
    public Task<BaseResult<UserDto>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }
}