using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService;
using LDM_Mobile_Manager.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Controllers
{
    [ApiController]
    [Route("NT/Data")]
    public class HealthTipsController : ControllerBase
    {
        private readonly HealthTipsDSL _healthTipsDSL;

        public HealthTipsController(HealthTipsDSL healthTipsDSL)
        {
            _healthTipsDSL = healthTipsDSL;
        }

        [HttpGet("HealthTips")]
        public async Task<ActionResult<ResponseDTO<List<GetHealthTipResponseDTO>>>> GetHealthTips()
        {
            var healthTips = await _healthTipsDSL.GetHealthTips();
            return Ok(new ResponseDTO<List<GetHealthTipResponseDTO>>(true, "Request Processed Successfully", healthTips));
        }
    }
}

