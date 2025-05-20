using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
        [ApiController]
        [Route("NT/Data")]
        public class MobileUserProfileController : ControllerBase
        {
            private readonly MobileUserProfileDSL _dsl;

            public MobileUserProfileController(MobileUserProfileDSL dsl)
            {
                _dsl = dsl;
            }

            [HttpGet("GetMobileUserProfile")]
            public async Task<ActionResult<ResponseDTO<List<GetMobileUserProfileResponseDTO>>>> GetMobileUserProfile()
            {
                var data = await _dsl.GetMobileUserProfile();
                return Ok(new ResponseDTO<List<GetMobileUserProfileResponseDTO>>(true, "Request Processed Successfully", data));
            }
        }
}
