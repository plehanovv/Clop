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
        var user = _userRepository.GetAll().FirstOrDefaultAsync();
        
        var userWithInclude = _userRepository.GetAll()
            .Include(user => user.Profile)
            .FirstOrDefaultAsync();

        throw new NotImplementedException();
    }
}