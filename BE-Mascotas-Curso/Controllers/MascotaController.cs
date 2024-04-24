using BE_Mascotas_Curso.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_Mascotas_Curso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public MascotaController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mascota>>> GetMascotas()
        {
            try
            {
                Thread.Sleep(2000);
                var mascotas = await _context.Mascotas.ToListAsync();
                return Ok(mascotas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"GET Mascota {id}");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("POST Mascota");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"PUT Mascota {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"DELETE Mascota {id}");
        }
    }
}
