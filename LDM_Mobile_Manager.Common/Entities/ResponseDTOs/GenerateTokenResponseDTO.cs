using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Common.Entities.ResponseDTOs
{
    public class GenerateTokenResponseDTO
    {
        public string Token { get; set; }
        public DateTime ExpiresIn { get; set; }
        public DateTime CreatedAt { get; set; }

        public GenerateTokenResponseDTO(string token, DateTime expiresIn, DateTime createdAt)
        {
            Token = token;
            ExpiresIn = expiresIn;
            CreatedAt = createdAt;
        }
    }
}
