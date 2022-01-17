using Bitsion.Business;
using Bitsion.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

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
        [AllowAnonymous]
        [HttpGet]
        [Route("list")]
        public IActionResult GetClients()
        {
            return Ok(_ClientBusiness.ClientList());
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("addClient")]
        public IActionResult AddClient([FromBody] Client client)
        {
            _ClientBusiness.CreateClient(client);
            return Ok(true);
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("updateClient")]
        public IActionResult UpdateClient([FromBody] Client client)
        {
            _ClientBusiness.UpdateClient(client);
            return Ok(true);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("searchClient/{id}")]
        public IActionResult SearchById(int id)
        {
            return Ok(_ClientBusiness.ClientById(id));
        }
    }
}
