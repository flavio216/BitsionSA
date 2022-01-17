using Bitsion.Business;
using Microsoft.AspNetCore.Mvc;

namespace Bitsion.WebApi.Controllers
{
    [Route("api/gender")]
    public class GenderController : Controller
    {
        public readonly GenderBusiness _GenderBusiness;

        public GenderController(GenderBusiness genderBusiness)
        {
            this._GenderBusiness = genderBusiness;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetGenders()
        {
            return Ok(_GenderBusiness.GenderList());
        }
    }
}
