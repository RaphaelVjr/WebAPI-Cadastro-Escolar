using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroEscolar_WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CadastroEscolar_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {

        public AlunoController(IRepository repo) 
        {

        }




         [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

        }
    }
}