using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Entities;
using PortfolioAPI.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PortfolioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudoController : ControllerBase
    {
        private readonly EstudoRepository _Repository;

        public EstudoController(EstudoRepository Repository)
        {
            _Repository = Repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudo>>> Get()
        {
            var data = await _Repository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Estudo>> Get(string id)
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
