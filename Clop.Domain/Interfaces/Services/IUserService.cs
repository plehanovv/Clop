using Clop.Domain.Dto.User;
using Clop.Domain.Result;

namespace Clop.Domain.Interfaces.Services;

public interface IUserService
{
    Task<BaseResult<UserDto>> GetUsersAsync();
}