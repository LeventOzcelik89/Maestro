using Maestro.Application.Repository.City;
using Maestro.Application.Repository.User;
using Maestro.Persistence.Repositories.User;
using Microsoft.AspNetCore.Mvc;

namespace Maestro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {

        readonly ICityWriteRepository _cityWriteRepository;
        readonly ICityReadRepository _cityReadRepository;
        public CityController(ICityReadRepository cityReadRepository, ICityWriteRepository cityWriteRepository)
        {
            _cityReadRepository = cityReadRepository;
            _cityWriteRepository = cityWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = _cityReadRepository.GetAll();
            return Ok(res);
        }
    }

}
