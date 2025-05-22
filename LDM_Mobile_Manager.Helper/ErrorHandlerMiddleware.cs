using LDM_Mobile_Manager.Common.Entities.Exceptions;
using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ErrorHandlerMiddleware> _logger;
    private readonly IHostEnvironment _env;

    public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger, IHostEnvironment env)
    {
        _next = next;
        _logger = logger;
        _env = env;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred");
            await HandleExceptionAsync(context, ex, _env);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception ex, IHostEnvironment env)
    {
        context.Response.ContentType = "application/json";

        HttpStatusCode statusCode;
        string message;

        switch (ex)
        {
            case UnauthorizedException:
                statusCode = HttpStatusCode.Unauthorized;
                message = ex.Message;
                break;

            case NoContentException:
                statusCode = HttpStatusCode.NoContent;
                message = ex.Message;
                break;

            case CustomResponseValidationException:
                statusCode = HttpStatusCode.BadRequest;
                message = ex.Message;
                break;

            default:
                statusCode = HttpStatusCode.InternalServerError;
                message = "Please re-try again, if the error persists please contact Administrator";
                break;
        }

        if (env.IsDevelopment())
        {
            message += $" | Exception: {ex.Message} | StackTrace: {ex.StackTrace}";
        }

        context.Response.StatusCode = (int)statusCode;

        var response = new ResponseDTO<object>(
            false,
            message,
            null
        );

        var result = JsonSerializer.Serialize(response);
        return context.Response.WriteAsync(result);
    }
}
