using LDM_Mobile_Manager.Common.Entities.RequestDTOs;
using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;

using LDM_Mobile_Manager.DSL;
using Microsoft.AspNetCore.Mvc;

namespace LDM_Mobile_Manager.Controllers
{
    [ApiController]
    [Route("NT/Authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly TokenDSL _tokenDSL;

        public AuthenticationController(TokenDSL tokenDSL)
        {
            _tokenDSL = tokenDSL;
        }

        [HttpPost("GenerateToken")]
        public ActionResult<ResponseDTO<GenerateTokenResponseDTO>> GenerateToken([FromBody] TokenCredentialsRequestDTO request)
        {
            var token = _tokenDSL.GenerateToken(request);
            return Ok(new ResponseDTO<GenerateTokenResponseDTO>(true, "Token generated successfully", token));
        }
    }
}
