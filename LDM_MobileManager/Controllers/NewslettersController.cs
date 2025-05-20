using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
    [ApiController]
    [Route("NT/Data")]
    public class NewslettersController : ControllerBase
    {
        private readonly NewslettersDSL _dsl;

        public NewslettersController(NewslettersDSL dsl)
        {
            _dsl = dsl;
        }

        [HttpGet("GetNewsletters")]
        public async Task<ActionResult<ResponseDTO<List<GetNewsletterResponseDTO>>>> GetNewsletters()
        {
            var data = await _dsl.GetNewsletters();
            return Ok(new ResponseDTO<List<GetNewsletterResponseDTO>>(true, "Request Processed Successfully", data));
        }
    }
}
