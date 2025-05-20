using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
    [ApiController]
    [Route("NT/Data")]
    public class GalleryController : ControllerBase
    {
        private readonly GalleryDSL _galleryDSL;

        public GalleryController(GalleryDSL galleryDSL)
        {
            _galleryDSL = galleryDSL;
        }

        [HttpGet("GetGalleryImages")]
        public async Task<ActionResult<ResponseDTO<List<GetGalleryImageResponseDTO>>>> GetGalleryImages()
        {
            var data = await _galleryDSL.GetGalleryImages();
            return Ok(new ResponseDTO<List<GetGalleryImageResponseDTO>>(true, "Request Processed Successfully", data));
        }
    }
}
