using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService.Data;
using LDM_Mobile_Manager.DSL;
using LDM_Mobile_Manager.Helper;
using LDM_Mobile_Manager.Interfaces.Repositories;
using LDM_Mobile_Manager.Interfaces.Services;
using LDM_Mobile_Manager.LDM_Mobile_Manager.Helper;
using LDM_Mobile_Manager.Repo;
using LDM_Mobile_Manager.Repo.Data;
using Microsoft.AspNetCore.Builder;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject custom services
RegisterAssemblies();
builder.Services.AddSingleton<TokenManager>();
builder.Services.AddScoped<TokenDSL>();
builder.Services.AddScoped(typeof(IBaseDSL<>), typeof(BaseDSL<>));

// Call this early

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.MapControllers();


app.Run();

void RegisterAssemblies()
{
    // Load all relevant assemblies
    var assemblies = new[] {
        "LDM_Mobile_Manager.Repo"
    }.Select(Assembly.Load).ToList();

    // Register all IBaseRepo<T> implementations with their interface
    foreach (var type in assemblies.SelectMany(a => a.GetTypes()))
    {
        if (type.Name.EndsWith("Repo") && !type.IsInterface && !type.IsAbstract)
        {
            var repoInterface = type.GetInterfaces()
                .FirstOrDefault(i => i.IsGenericType &&
                    i.GetGenericTypeDefinition() == typeof(IBaseRepo<>));

            if (repoInterface != null)
            {
                builder.Services.AddScoped(repoInterface, type);
            }
        }
    }
}
