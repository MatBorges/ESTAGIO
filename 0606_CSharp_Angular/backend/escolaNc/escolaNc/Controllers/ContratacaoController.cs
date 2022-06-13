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
    public class ContratacaoController : ControllerBase
    {
        private readonly IContratacaoService _contratacaoService;

        public ContratacaoController(IContratacaoService contratacaoService)
        {
            _contratacaoService = contratacaoService;
        }

        [HttpGet, Route("contratados")]
        public IActionResult RetornaContratados()
        {
            try
            {
                return Ok(_contratacaoService.RetornaContratados());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{cpf}")]
        public IActionResult ContratadosCpf(string cpf)
        {
            try
            {
                return Ok(_contratacaoService.ContratadosCpf(cpf));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet, Route("servicos")]
        public IActionResult RetornaServicos()
        {
            try
            {
                return Ok(_contratacaoService.RetornaServicos());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}