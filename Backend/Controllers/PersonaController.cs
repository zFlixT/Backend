using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet("all")]
        public List<PersonaDatos> GetPeronaDatos() => Repository.persona;

        [HttpGet("{id}")]
        public PersonaDatos GetPersonaDatos(int id) => Repository.persona.FirstOrDefault(p => p.id == id);

        [HttpGet("Search/{search}")]
        public List<PersonaDatos> Get(string search) => Repository.persona.Where(p => p.name.ToUpper().Contains(search.ToUpper())).ToList();
    }
}
