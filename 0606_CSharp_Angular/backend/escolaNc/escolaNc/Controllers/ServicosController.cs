using escolaNc.Interfaces;
using escolaNc.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escolaNc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicosController : Controller
    {
        private readonly IServicosService _servicosService;
        public ServicosController(IServicosService servicosService)
        {
            _servicosService = servicosService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_servicosService.RetornaServicos());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost, Route("inserir")]
        public IActionResult InserirServico([FromBody] Servico servico)
        {
            try
            {
                return Ok(_servicosService.InsereServico(servico));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost, Route("atualizar")]
        public IActionResult AtualizarServico([FromBody] Servico servico)
        {
            try
            {
                return Ok(_servicosService.AtualizaServico(servico));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveUsusario(int id)
        {
            try
            {
                return Ok(_servicosService.RemoveServico(id));
            }
            catch (Exception e)
            { 
                return BadRequest(e.Message);
            }
        }
    }
}