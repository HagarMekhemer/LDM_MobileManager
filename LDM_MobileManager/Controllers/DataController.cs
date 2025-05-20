using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService.Data;
using LDM_Mobile_Manager.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LDM_MobileManager.Controllers
{
    [Route("NT/Data")]
    [ApiController]
    public class DataController : ControllerBase
    {

        private readonly IBaseDSL<GetNewsDataResponseDTO> _newsDataService;
        private readonly IBaseDSL<GetPromotionResponseDTO> _promotionService;
        private readonly IBaseDSL<GetBrochuresResponseDTO> _brochureService;
        private readonly IBaseDSL<GetPressResponseDTO> _pressService;
        private readonly IBaseDSL<GetBranchesResponseDTO> _branchService;
        private readonly IBaseDSL<GetFeedbackMailResponseDTO> _feedbackMailService;
        private readonly IBaseDSL<GetLabServicesResponseDTO> _labServicesService;
        private readonly IBaseDSL<GetAboutLabDetailsResponseDTO> _aboutLabDetailsService;
        private readonly IBaseDSL<GetBookResponseDTO> _booksService;
        private readonly IBaseDSL<GetClientDataVersionResponseDTO> _clientDataVersionService;
        private readonly IBaseDSL<GetContactDetailsResponseDTO> _contactDetailsService;
        private readonly IBaseDSL<GetGalleryImageResponseDTO> _galleryImageService;
        private readonly IBaseDSL<GetHealthTipResponseDTO> _healthTipService;
        private readonly IBaseDSL<GetMobileUserProfileResponseDTO> _mobileUserProfileService;
        private readonly IBaseDSL<GetNewsletterResponseDTO> _newsletterService;
        private readonly IBaseDSL<GetScientificNewsResponseDTO> _scientificNewsService;




        public DataController(IBaseDSL<GetNewsDataResponseDTO> newsDataService,
                              IBaseDSL<GetPromotionResponseDTO> promotionService,
                              IBaseDSL<GetBrochuresResponseDTO> brochureService,
                              IBaseDSL<GetPressResponseDTO> pressService,
                              IBaseDSL<GetBranchesResponseDTO> branchService,
                              IBaseDSL<GetFeedbackMailResponseDTO> feedbackMailService,
                              IBaseDSL<GetLabServicesResponseDTO> labServicesService,
                              IBaseDSL<GetAboutLabDetailsResponseDTO> aboutLabDetailsService,
                              IBaseDSL<GetBookResponseDTO> booksService,
                              IBaseDSL<GetClientDataVersionResponseDTO> clientDataVersionService,
                              IBaseDSL<GetContactDetailsResponseDTO> contactDetailsService,
                              IBaseDSL<GetGalleryImageResponseDTO> galleryImageService,
                              IBaseDSL<GetHealthTipResponseDTO> healthTipService,
                              IBaseDSL<GetMobileUserProfileResponseDTO> mobileUserProfileService,
                              IBaseDSL<GetNewsletterResponseDTO> newsletterService,
                              IBaseDSL<GetScientificNewsResponseDTO> scientificNewsService)
        {
            _newsDataService = newsDataService;
            _promotionService = promotionService;
            _brochureService = brochureService;
            _pressService = pressService;
            _branchService = branchService;
            _feedbackMailService = feedbackMailService;
            _labServicesService = labServicesService;
            _aboutLabDetailsService = aboutLabDetailsService;
            _booksService = booksService;
            _clientDataVersionService = clientDataVersionService;
            _contactDetailsService = contactDetailsService;
            _galleryImageService = galleryImageService;
            _healthTipService = healthTipService;
            _mobileUserProfileService = mobileUserProfileService;
            _newsletterService = newsletterService;
            _scientificNewsService = scientificNewsService;

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

        [HttpGet("GetBooks")]
        public async Task<ActionResult> GetBooks()
        {
            var response = await _booksService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetClientDataVersion")]
        public async Task<ActionResult> GetClientDataVersion()
        {
            var response = await _clientDataVersionService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetContactDetails")]
        public async Task<ActionResult> GetContactDetails()
        {
            var response = await _contactDetailsService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetGalleryImage")]
        public async Task<ActionResult> GetGalleryImage()
        {
            var response = await _galleryImageService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetHealthTip")]
        public async Task<ActionResult> GetHealthTip()
        {
            var response = await _healthTipService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetMobileUserProfile")]
        public async Task<ActionResult> GetMobileUserProfile()
        {
            var response = await _mobileUserProfileService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetNewsletter")]
        public async Task<ActionResult> GetNewsletter()
        {
            var response = await _newsletterService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetScientificNews")]
        public async Task<ActionResult> GetScientificNews()
        {
            var response = await _scientificNewsService.GetAllAsync();
            return Ok(response);
        }

    }

}

