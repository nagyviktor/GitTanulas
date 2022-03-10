using Microsoft.AspNetCore.Mvc;
using Tanulas.BLL.Interfaces;
using Tanulas.DAL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tanulas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmberController : ControllerBase
    {
        private readonly IEmberService _emberService;

        public EmberController(IEmberService emberService)
        {
            _emberService = emberService;
        }

        [HttpGet]
        public IEnumerable<Ember> Get()
        {
            return _emberService.GetEmberek();
        }
    }
}
