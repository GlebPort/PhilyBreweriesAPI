using AutoMapper;
using BreweryAPI.DTOs;
using BreweryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BreweryAPI.Controllers
{
    [ApiController]
    [Route("api/breweries")]
    public class BreweriesController : Controller
    {
        private IBreweryRepository _repository;
        private IMapper _mapper;
        public BreweriesController(IBreweryRepository repository, IMapper mapper )
        {
            _mapper = mapper ??  throw new ArgumentNullException( nameof( mapper ) );
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BreweryDto>>> GetBreweries()
        {
            var breweries = await _repository.GetBreweriesAsync();

            return Ok(_mapper.Map<IEnumerable<BreweryDto>>(breweries));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BreweryDto>> GetBrewery(string id)
        {
            var brewery = await _repository.GetBreweryAsync(id);
            if (brewery == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<BreweryDto>(brewery));
        }
    }
}
