using BirraNet.Application.Service;
using BirraNet.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BirraNet.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerguntasController : ControllerBase
    {   
        // GET: api/<PerguntasController>
        [HttpGet()]        
        public IEnumerable<PerguntaViewModel> BuscarTodos([FromServices] IPerguntaAppService _perguntaAppService)
        {
            return _perguntaAppService.BuscarTodos();
        }

        // GET api/<PerguntasController>/5
        [HttpGet("{id}")]        
        public PerguntaViewModel Buscar(int id,
            [FromServices] IPerguntaAppService _perguntaAppService)
        {
            return _perguntaAppService.BuscarPorId(id);
        }

        [HttpGet()]
        [Route("BuscarProximaPergunta/{idRespostaPai}/{respostaPai}")]
        public PerguntaViewModel BuscarProximaPergunta(
            [FromServices] IPerguntaAppService _perguntaAppService,
             int idRespostaPai,
             string respostaPai)
        {
            return _perguntaAppService.BuscarProximaPergunta(idRespostaPai, respostaPai);
        }
    }
}
