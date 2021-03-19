using BirraNet.Application.Service;
using BirraNet.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BirraNet.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CervejasController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<CervejaViewModel> BuscarTodas([FromServices]ICervejaAppService cervejaAppService)
        {
            return cervejaAppService.BuscarTodas();
        }
    }
}
