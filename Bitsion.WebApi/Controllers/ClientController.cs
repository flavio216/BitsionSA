using Bitsion.Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace Bitsion.WebApi.Controllers
{
    [Route("api/client")]
    public class ClientController : ControllerBase
    {
        private readonly ClientBusiness _ClientBusiness;

        public ClientController(ClientBusiness clientBusiness)
        {
            this._ClientBusiness = clientBusiness;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetClients()
        {
            return Ok(_ClientBusiness.ClientList());
        }
    }
}
