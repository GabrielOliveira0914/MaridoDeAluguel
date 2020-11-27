using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Teste.Model;
using Teste.Service;
using Teste.Service.Interface;

namespace Teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaridoDeAluguelController : Controller
    {
        private readonly IMaridoDeAluguelService _MaridoDeAluguelService;

        public MaridoDeAluguelController(IMaridoDeAluguelService testeService)
        {
            _MaridoDeAluguelService = testeService;
        }

        [HttpPut]
        [Route("/imc")]
        public string GetIMC([FromBody]IndiceMC imc)
        {
            return _MaridoDeAluguelService.IMC(imc);
        }
    }
}
