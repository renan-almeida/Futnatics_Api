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
    public class PartidasController : ControllerBase
    {
         private static List<Partida> Partida = new List<Partida>()

        {
            new Partida() {Id = 1, Data = DateTime.Parse("04/11/2024 20:00"), Estadio = "Neo Quimica Arena", TimeCasa =  "Corinthians", TimeFora = "Palmeiras"},
                new Partida() {Id = 2, Data =  DateTime.Parse("09/11/2024 16:30"), Estadio = "Barradão", TimeCasa = "Vitoria", TimeFora = "Corinthians"},
                new Partida(){Id = 3, Data = DateTime.Parse("20/11/2024 11:00"), Estadio = "Neo Quimica Arena", TimeCasa = "Corinthians", TimeFora = "Cruzeiro"},
                new Partida(){Id = 4, Data = DateTime.Parse("20/11/2024 16:30"), Estadio = "Nabi Abi Chedid", TimeCasa = "Bragantino", TimeFora = "São Paulo"}
        };
        

        [HttpGet("TodasPartidas")]
        public IActionResult ExibirTodasPartidas()
        {
            return Ok(Partida);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarporId(int id)
        {
            return Ok(Partida.FirstOrDefault(pe => pe.Id == id));
        }

       /* [HttpPost("AdicionarPartida")]
    public ActionResult<Cliente> AdicionarCliente([FromBody] Partida novaPartida)
    {
        if (novaPartida == null)
        {
            return BadRequest("Dados da partida são inválidos.");
        }

        // Adicione o cliente à lista (ou ao banco de dados, em um cenário real)
        novaPartida.Id = novaPartida.Count + 1; // Definindo um Id temporário
        Partida.Add(novaPartida);
    }*/

     [HttpGet("hoje")]
    public IActionResult ObterPartidasDeHoje()
    {
        var hoje = DateTime.Now.Date;
        var partidasHoje = Partida.Where(p => p.Data.Date == hoje).ToList();

        if (!partidasHoje.Any())
            return NotFound("Nenhuma partida encontrada para hoje.");

        return Ok(partidasHoje);
    }
}
}

    
