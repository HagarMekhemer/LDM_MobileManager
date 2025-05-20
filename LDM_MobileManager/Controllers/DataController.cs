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
        private readonly IBaseDSL<GetNewsDataResponseDTO> _newsDataService;
        private readonly IBaseDSL<GetPromotionResponseDTO> _promotionService;
        private readonly IBaseDSL<GetBrochuresResponseDTO> _brochureService;
        private readonly IBaseDSL<GetPressResponseDTO> _pressService;
        private readonly IBaseDSL<GetBranchesResponseDTO> _branchService;
        private readonly IBaseDSL<GetFeedbackMailResponseDTO> _feedbackMailService;
        private readonly IBaseDSL<GetLabServicesResponseDTO> _labServicesService;
        private readonly IBaseDSL<GetAboutLabDetailsResponseDTO> _aboutLabDetailsService;


        public DataController(IBaseDSL<GetNewsDataResponseDTO> newsDataService,
                              IBaseDSL<GetPromotionResponseDTO> promotionService,
                              IBaseDSL<GetBrochuresResponseDTO> brochureService,
                              IBaseDSL<GetPressResponseDTO> pressService,
                              IBaseDSL<GetBranchesResponseDTO> branchService,
                              IBaseDSL<GetFeedbackMailResponseDTO> feedbackMailService,
                              IBaseDSL<GetLabServicesResponseDTO> labServicesService,
                              IBaseDSL<GetAboutLabDetailsResponseDTO> aboutLabDetailsService)
        {
            _newsDataService = newsDataService;
            _promotionService = promotionService;
            _brochureService = brochureService;
            _pressService = pressService;
            _branchService = branchService;
            _feedbackMailService = feedbackMailService;
            _labServicesService = labServicesService;
            _aboutLabDetailsService = aboutLabDetailsService;

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

        [HttpGet("GetBranches")]
        public async Task<IActionResult> GetBranches()
        {
            var response = await _branchService.GetAllAsync();       
            return Ok(response);
        }

        [HttpGet("GetFeedbackMail")]
        public async Task<IActionResult> GetFeedbackMail()
        {
            var response = await _feedbackMailService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetLabServices")]
        public async Task<IActionResult> GetLabServices()
        {
            var response = await _labServicesService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetAboutLabDetails")]
        public async Task<IActionResult> GetAboutLabDetails()
        {
            var response = await _aboutLabDetailsService.GetAllAsync();
            return Ok(response);
        }
    }

}

