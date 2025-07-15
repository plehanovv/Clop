using Clop.Domain.Dto.User;
using Clop.Domain.Interfaces.Services;
using Clop.Domain.Result;
using Microsoft.AspNetCore.Mvc;

namespace Clop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("users")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BaseResult<UserDto>>> GetUsers()
    {
        var response = await _userService.GetUsersAsync();
        if (response.IsSuccess)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }
}