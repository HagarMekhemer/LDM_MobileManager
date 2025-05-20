using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
    [ApiController]
    [Route("NT/Data")]
    public class ClientDataVersionController : ControllerBase
    {
        private readonly ClientDataVersionDSL _dsl;

        public ClientDataVersionController(ClientDataVersionDSL dsl)
        {
            _dsl = dsl;
        }

        [HttpGet("GetClientDataVersion")]
        public async Task<ActionResult<ResponseDTO<List<GetClientDataVersionResponseDTO>>>> GetClientDataVersion()
        {
            var data = await _dsl.GetClientDataVersions();
            return Ok(new ResponseDTO<List<GetClientDataVersionResponseDTO>>(true, "Request Processed Successfully", data));
        }
    }
}
