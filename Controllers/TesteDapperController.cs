using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using teste_dapper.Infra.Data;

namespace teste_dapper.Controllers
{
    [ApiController]
    [Route("api")]
    public class TesteDapperController : ControllerBase
    {
        private readonly Context _context;

        public TesteDapperController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ObterCidades()
        {
            return Ok(_context.Cidades.Include(x => x.Estado).ToList());
        }
        
    }
}