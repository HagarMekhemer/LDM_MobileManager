using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Filters;
using LDM_Mobile_Manager.LDM_Mobile_Manager.Helper;
namespace LDM_Mobile_Manager.Helper
{
    public class TokenActionFilterAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var tokenManager = context.HttpContext.RequestServices.GetService<TokenManager>();
            var header = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();

            if (string.IsNullOrEmpty(header) || !header.StartsWith("Bearer "))
                throw new Exception("Authorization header missing or invalid.");

            var token = header.Substring("Bearer ".Length).Trim();
            tokenManager.Validate(token);
        }
    }
}