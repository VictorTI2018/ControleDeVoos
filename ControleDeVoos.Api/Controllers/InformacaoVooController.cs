using AutoMapper;
using ControleDeVoos.Domain.Core.Interfaces.Services;
using ControleDeVoos.Domain.Dtos.InformacaoVoo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVoos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformacaoVooController : ControllerBase
    {
        private readonly IServiceInformacaoVoo _serviceInformacaoVoo;
        private readonly IMapper _mapper;

        public InformacaoVooController(IServiceInformacaoVoo serviceInformacaoVoo, 
            IMapper mapper)
        {
            _serviceInformacaoVoo = serviceInformacaoVoo;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(InformacaoVooDadosDto informacaoVooDadosDto)
        {
            return Ok(await _serviceInformacaoVoo.Cadastrar(informacaoVooDadosDto));
        }
    }
}
