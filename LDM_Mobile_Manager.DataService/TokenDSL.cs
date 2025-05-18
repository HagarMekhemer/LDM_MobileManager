using LDM_Mobile_Manager.Common.Entities.RequestDTOs;
using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.LDM_Mobile_Manager.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LDM_Mobile_Manager.DSL
{
    public class TokenDSL
    {
        private readonly TokenManager _tokenManager;

        public TokenDSL(TokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }

        public GenerateTokenResponseDTO GenerateToken(TokenCredentialsRequestDTO request)
        {
            return _tokenManager.GetToken(request);
        }
    }
}