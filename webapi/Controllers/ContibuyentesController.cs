using DGIIService.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContribuyentesController : ControllerBase
    {
        IContribuyenteService _contribuyenteService;
        private readonly ILogger<ContribuyentesController> _logger;

        public ContribuyentesController(IContribuyenteService contribuyenteService,
            ILogger<ContribuyentesController> logger)
        {
            _contribuyenteService = contribuyenteService;
            _logger = logger;
        }

        [HttpGet]
        public object Get()
        {
            return _contribuyenteService.Get();
        }

        [HttpPost]
        public object Get([FromBody] int id)
        {
            try
            {
                return _contribuyenteService.GetContribuyenteNCFList(id);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Ocurrió un error");
            }

            return null;
        }
    }
}
