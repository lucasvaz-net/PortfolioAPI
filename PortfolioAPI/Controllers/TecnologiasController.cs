using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Entities;
using PortfolioAPI.Repositories;

namespace PortfolioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TecnologiasController : ControllerBase
    {
        private readonly TecnologiaRepository _Repository;

        public TecnologiasController(TecnologiaRepository Repository)
        {
            _Repository = Repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tecnologia>>> Get()
        {
            var data = await _Repository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tecnologia>> Get(string id)
        {
            var data = await _Repository.GetByIdAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}
