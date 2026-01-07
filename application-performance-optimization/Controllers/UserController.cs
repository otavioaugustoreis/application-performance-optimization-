using application_performance_optimization.Services;
using Microsoft.AspNetCore.Mvc;

namespace application_performance_optimization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;


        [HttpPost]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var usersResult = await _userService.GetAllUsersAsync();

            return Ok(usersResult);
        }
    }
}
