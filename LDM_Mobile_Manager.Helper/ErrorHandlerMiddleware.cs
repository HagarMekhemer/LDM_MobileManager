using LDM_Mobile_Manager.Common.Entities.Exceptions;
using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LDM_Mobile_Manager.Helper
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true
        };

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context); // Go to next middleware/controller
            }
            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                string message;
                int statusCode;

                switch (ex)
                {
                    case UnauthorizedException:
                        statusCode = (int)HttpStatusCode.Unauthorized;
                        message = ex.Message;
                        break;

                    case CustomValidationException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        message = ex.Message;
                        break;

                    case CustomResponseValidationException:
                        statusCode = (int)HttpStatusCode.InternalServerError;
                        message = ex.Message;
                        break;

                    case NoContentException:
                        statusCode = (int)HttpStatusCode.NoContent;
                        message = ex.Message;
                        break;

                    default:
                        statusCode = (int)HttpStatusCode.InternalServerError;
                        message = "An unexpected error occurred. Please try again later.";
                        break;
                }

                response.StatusCode = statusCode;

                if (statusCode != (int)HttpStatusCode.NoContent)
                {
                    var result = JsonSerializer.Serialize(new ResponseDTO<string>(false, message, null), _jsonOptions);
                    await response.WriteAsync(result);
                }
            }
        }
    }
}