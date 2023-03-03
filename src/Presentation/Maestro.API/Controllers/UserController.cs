using Maestro.Application.Repository.User;
using Microsoft.AspNetCore.Mvc;

namespace Maestro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        readonly IUserWriteRepository _userWriteRepository;
        readonly IUserReadRepository _userReadRepository;

        public UserController(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = _userReadRepository.GetAll();
            return Ok(res);
        }
    }
}
