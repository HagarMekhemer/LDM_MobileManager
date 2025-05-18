using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using LDM_Mobile_Manager.Helper;
using System.Security.Claims;
using System.Text;
using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.Common.Entities.RequestDTOs;

namespace LDM_Mobile_Manager.LDM_Mobile_Manager.Helper
{
    public class TokenManager
    {
        private readonly ConfigManager _authSettings;
        private readonly string _jwtSecret;

        public TokenManager(IConfiguration configuration)
        {
            _jwtSecret = configuration["Jwt:SecretKey"];
            _authSettings = new ConfigManager
            {
                ClientCode = configuration["AuthSettings:ClientCode"],
                Username = configuration["AuthSettings:Username"],
                Password = configuration["AuthSettings:Password"]
            };
        }

        public GenerateTokenResponseDTO GetToken(TokenCredentialsRequestDTO user)
        {
            ValidateUserCredentials(user);
            return CreateToken(user);
        }

        private void ValidateUserCredentials(TokenCredentialsRequestDTO user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password) || string.IsNullOrWhiteSpace(user.ClientCode))
                throw new Exception("All fields are required.");

            if (user.Username != _authSettings.Username || user.Password != _authSettings.Password || user.ClientCode != _authSettings.ClientCode)
                throw new Exception("Invalid credentials.");
        }

        private GenerateTokenResponseDTO CreateToken(TokenCredentialsRequestDTO user)
        {
            var key = Encoding.ASCII.GetBytes(_jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var handler = new JwtSecurityTokenHandler();
            var token = handler.CreateToken(tokenDescriptor);
            return new GenerateTokenResponseDTO(handler.WriteToken(token), tokenDescriptor.Expires.Value, DateTime.UtcNow);
        }

        public bool Validate(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSecret);

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out _);

                return true;
            }
            catch
            {
                throw new Exception("Unauthorized token");
            }
        }
    }
}