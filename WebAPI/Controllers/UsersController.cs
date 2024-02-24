using Business.Abstract;
using Business.Requests.User;
using Business.Responses.User;
using Core.Utilities.Security;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        public AccessToken Login([FromBody] LoginRequest request)
        {
            return _userService.Login(request);
        }

    }
}
