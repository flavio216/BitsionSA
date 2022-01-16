using Bitsion.Business;
using Microsoft.AspNetCore.Mvc;

namespace Bitsion.WebApi.Controllers
{
    public class DocumentTypeController : Controller
    {
        private readonly DocumentTypeBusiness _DocumentTypeBusiness;

        public DocumentTypeController(DocumentTypeBusiness documentTypeBusiness)
        {
            this._DocumentTypeBusiness = documentTypeBusiness;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetTypeController()
        {
            return Ok(_DocumentTypeBusiness.DocumentTypeList());
        }
    }
}
