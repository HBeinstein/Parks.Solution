using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using NationalParks.Services;
using NationalParks.Entities;

namespace NationalParks.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class NationalParksController : ControllerBase
  {
    private IUserService _userService;

    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    //api/authenticate
    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody]User userParam)
    {
      var user = _userService.Authenticate(userParam.UserName, userParam.Password);

      if (user == null)
      {
        return BadRequest(new { message = "Username or password is incorrect" });
      }

      return Ok(user);
    }

    // api/users
    [HttpGet]
    public IActionResult GetAll()
    {
      var users =  _userService.GetAll();
      return Ok(users);
    }
  }
}