using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService.Data;
using LDM_Mobile_Manager.Interfaces.Services;
using LDM_MobileManager.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
    [Route("NT/Data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        //private readonly INewsDataService _newsDataService;
        //private readonly IPromotionService _promotionService;
        //private readonly IBrochureService _brochureService;
        //private readonly IPressService _pressService;
        private readonly IBaseService<GetNewsDataResponseDTO> _newsDataService;
        private readonly IBaseService<GetPromotionResponseDTO> _promotionService;
        private readonly IBaseService<GetBrochuresResponseDTO> _brochureService;
        private readonly IBaseService<GetPressResponseDTO> _pressService;
        public DataController(IBaseService<GetNewsDataResponseDTO> newsDataService,
                              IBaseService<GetPromotionResponseDTO> promotionService,
                              IBaseService<GetBrochuresResponseDTO> brochureService,
                              IBaseService<GetPressResponseDTO> pressService)
        {
            _newsDataService = newsDataService;
            _promotionService = promotionService;
            _brochureService = brochureService;
            _pressService = pressService;
        }

        [HttpGet("GetNewsData")]
        public async Task<IActionResult> GetNewsData()
        {
            var response = await _newsDataService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetPromotions")]
        public async Task<IActionResult> GetPromotions()
        {
            var response = await _promotionService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetBrochures")]
        public async Task<IActionResult> GetBrochures()
        {
            var response = await _brochureService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetPress")]
        public async Task<IActionResult> GetPress()
        {
            var response = await _pressService.GetAllAsync();
            return Ok(response);
        }


    }
}
