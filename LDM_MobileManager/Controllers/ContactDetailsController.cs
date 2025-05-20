using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
    [ApiController]
    [Route("NT/Data")]
    public class ContactDetailsController : ControllerBase
    {
        private readonly ContactDetailsDSL _dsl;

        public ContactDetailsController(ContactDetailsDSL dsl)
        {
            _dsl = dsl;
        }

        [HttpGet("GetContactDetails")]
        public async Task<ActionResult<ResponseDTO<List<GetContactDetailsResponseDTO>>>> GetContactDetails()
        {
            var data = await _dsl.GetContactDetails();
            return Ok(new ResponseDTO<List<GetContactDetailsResponseDTO>>(true, "Request Processed Successfully", data));
        }
    }
}
