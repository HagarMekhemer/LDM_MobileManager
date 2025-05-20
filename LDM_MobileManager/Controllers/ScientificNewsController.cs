using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
    [ApiController]
    [Route("NT/Data")]
    public class ScientificNewsController : ControllerBase
    {
        private readonly ScientificNewsDSL _dsl;

        public ScientificNewsController(ScientificNewsDSL dsl)
        {
            _dsl = dsl;
        }

        [HttpGet("GetScientificNews")]
        public async Task<ActionResult<ResponseDTO<List<GetScientificNewsResponseDTO>>>> GetScientificNews()
        {
            var data = await _dsl.GetScientificNews();
            return Ok(new ResponseDTO<List<GetScientificNewsResponseDTO>>(true, "Request Processed Successfully", data));
        }
    }
}