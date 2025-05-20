using LDM_Mobile_Manager.DataService;
using LDM_Mobile_Manager.DSL;
using LDM_Mobile_Manager.LDM_Mobile_Manager.Helper;
using LDM_Mobile_Manager.Repo;
using Microsoft.AspNetCore.Builder;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject custom services
RegisterAssemblies();
builder.Services.AddSingleton<TokenManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void RegisterAssemblies()
{
    // Explicitly load all referenced assemblies first
    var assemblyNames = new[] {
        "LDM_Mobile_Manager.DataService",
        "LDM_Mobile_Manager.Repo",
        "LDM_Mobile_Manager.DataAccess"
    };

    // Load assemblies explicitly to ensure they're available
    var assemblies = assemblyNames
        .Select(Assembly.Load)
        .ToList();

    var serviceTypes = assemblies
      .SelectMany(a => a.GetTypes())
      .Where(t => (t.Name.EndsWith("Repo") || t.Name.EndsWith("DAL") || t.Name.EndsWith("DSL"))
                  && !t.IsInterface
                  && !t.IsAbstract);

    foreach (var servicetype in serviceTypes)
    {
        builder.Services.AddScoped(servicetype);
    }
}

