using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futnatics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Futnatics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimesController : ControllerBase
    {
        private static List<Time> Times = new List<Time>()
        {
            new Time() {Id = 1,
             Nome = "Corinthians",
              Sigla = "Sccp",
               FundadoEm = new DateTime(1910 ,10, 01),
             Cidade = "São Paulo",
              Estado = "SP",
               Pais = "Brasil",
                Estadio = "Neo Quimica Arena",
                 MaiorRival = "Palmeiras",
                  Mascote = "Mosqueteiro",
                   Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ"},

              new Time
        {
            Id = 2,
            Nome = "São Paulo",
            Sigla = "SPFC",
            FundadoEm = new DateTime(1930, 12, 25),
            Cidade = "São Paulo",
            Estado = "SP",
            Pais = "Brasil",
            Estadio = "Morumbi",
            MaiorRival = "Corinthians",
            Mascote = "Santo Paulo",
            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI"
        },
         new Time
        {
            Id = 3,
            Nome = "Cruzeiro",
            Sigla = "Cru",
            FundadoEm = new DateTime(1921, 01, 02),
            Cidade = "Belo Horizonte",
            Estado = "BH",
            Pais = "Brasil",
            Estadio = "Mineirão",
            MaiorRival = "Atlético Mg",
            Mascote = "Raposa",
            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI"
        },

        new Time
        {
            Id = 4,
            Nome =  "Bragantino",
            Sigla =  "Bra",
            FundadoEm =  new DateTime(1928, 01, 28),
            Cidade =  "Bragança Paulista",
            Estado =  "SP",
            Pais =  "Brasil",
            Estadio =  "Nabi Abi Chedid",
            MaiorRival =  "Corinthians",
            Mascote =  "Touro",
            Logo =  "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ"
        }
};
        [HttpGet]
    public IActionResult GetTimes()
    {
        return Ok (Times);
    }

    // GET api/times/1
    [HttpGet("{id}")]
    public IActionResult GetTime(int id)
    {
        var time = Times.FirstOrDefault(t => t.Id == id);
        if (time == null)
            return NotFound("Time não encontrado.");
        
        return Ok(time);
    }

    // POST api/times
    [HttpPost]
    public IActionResult AdicionarTime([FromBody] Time novoTime)
    {
        if (novoTime == null)
            return BadRequest("Dados inválidos.");

        novoTime.Id = Times.Max(t => t.Id) + 1; // Atribui um ID único
        Times.Add(novoTime);
        
        return CreatedAtAction(nameof(GetTime), new { id = novoTime.Id }, novoTime);
    }
     [HttpDelete("{id}")]
    public IActionResult DeletarTime(int id)
    {
        var time = Times.FirstOrDefault(t => t.Id == id);
        if (time == null)
            return NotFound("Time não encontrado.");

        Times.Remove(time);
        return NoContent();
    }

    // GET api/times/nome/{nome}
[HttpGet("nome/{nome}")]
public IActionResult GetTimeByName(string nome)
{
    var time = Times.FirstOrDefault(t => t.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

    if (time == null)
        return NotFound("Time não encontrado.");

    return Ok(time);
}





    
}
}
  /* public int Id {get; set; }
          public string Nome {get; set; }
         public string Sigla { get; set; }
    public DateTime FundadoEm { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    public string Estadio { get; set; }
     public string MaiorRival { get; set; }

     public string Mascote {get; set; }
      public string Logo { get; set; }*/