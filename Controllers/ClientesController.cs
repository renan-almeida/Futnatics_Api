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
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> Clientes = new List<Cliente>()
        {
             new Cliente() { Id = 1, Nome = "Renan", Cpf = 546812798, Email = "Renanalmeidadantas2007@gmail.com" , Endereco = "Rua Jonas Cardoso N: 16B " , Rg = 1241454213},
                new Cliente { Id = 2, Nome = "Danillo", Cpf = 124345325, Email = "DanilloLacerdad470@gmail.com" ,Endereco = "Rua Serra Do Apodi", Rg = 235252436},
                new Cliente { Id = 3, Nome = "Felipe", Cpf = 21345235, Email = "FelipeSilva@gmail.com", Endereco = "Rua Elisa do Apodi", Rg = 123542253}
        };

         [HttpGet("GetAll")]
        public IActionResult ExibirTodosClientes()
        {
            return Ok(Clientes);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarporId(int id)
        {
            return Ok(Clientes.FirstOrDefault(pe => pe.Id == id));
        }
    }
}