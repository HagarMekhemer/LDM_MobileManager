using LDM_Mobile_Manager.Common.Entities.Exceptions;
using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
namespace LDM_Mobile_Manager.Helper
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlerMiddleware> _logger;
        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = { new JsonStringEnumConverter() }
        };

        public ErrorHandlerMiddleware(
            RequestDelegate next,
            ILogger<ErrorHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            // Remove try-catch and let exceptions propagate
            await _next(context);
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception error)
        {
            _logger.LogError(error, "An unhandled exception occurred");

            var response = context.Response;
            response.ContentType = "application/json";

            HttpStatusCode statusCode;
            string message;

            switch (error)
            {
                case UnauthorizedException:
                    statusCode = HttpStatusCode.Unauthorized;
                    message = "Not Authorized";
                    break;

                case CustomValidationException validationException:
                    statusCode = HttpStatusCode.BadRequest;
                    message = validationException.Message;
                    break;

                case CustomResponseValidationException responseValidationException:
                    statusCode = HttpStatusCode.InternalServerError;
                    message = responseValidationException.Message;
                    break;

                default:
                    statusCode = HttpStatusCode.InternalServerError;
                    message = "Please re-try again, if the error persists please contact Administrator";
                    break;
            }

            response.StatusCode = (int)statusCode;

            var result = JsonSerializer.Serialize(new ResponseDTO<string>(false, message), _jsonOptions);

            await response.WriteAsync(result);
        }
    }
}

