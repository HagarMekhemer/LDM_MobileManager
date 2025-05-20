using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService.Data;
using LDM_Mobile_Manager.DSL;
using LDM_Mobile_Manager.Interfaces.Repositories;
using LDM_Mobile_Manager.Interfaces.Services;
using LDM_Mobile_Manager.LDM_Mobile_Manager.Helper;
using LDM_Mobile_Manager.Repo.Data;
using LDM_MobileManager.Interfaces.Repositories;
using LDM_MobileManager.Interfaces.Services;
using Microsoft.AspNetCore.Builder;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<INewsDataService, NewsDataService>();
//builder.Services.AddScoped<INewsDataRepository, NewsDataRepository>();

//builder.Services.AddScoped<IPromotionService, PromotionService>();
//builder.Services.AddScoped<IPromotionRepository, PromotionRepository>();

//builder.Services.AddScoped<IBrochureRepository, BrochureRepository>();
//builder.Services.AddScoped<IBrochureService, BrochureService>();

//builder.Services.AddScoped<IPressRepository, PressRepository>();
//builder.Services.AddScoped<IPressService, PressService>();

builder.Services.AddScoped<IBaseRepo<GetNewsDataResponseDTO>,NewsDataRepo>();
builder.Services.AddScoped<IBaseRepo<GetPromotionResponseDTO>, PromotionRepo>();
builder.Services.AddScoped<IBaseRepo<GetBrochuresResponseDTO>, BrochureRepo>();
builder.Services.AddScoped<IBaseRepo<GetPressResponseDTO>, PressRepo>();
builder.Services.AddScoped<IBaseRepo<GetBranchesResponseDTO>, BranchRepo>();
builder.Services.AddScoped<IBaseRepo<GetFeedbackMailResponseDTO>, FeedbackMailRepo>();
builder.Services.AddScoped<IBaseRepo<GetLabServicesResponseDTO>, LabServicesRepo>();
builder.Services.AddScoped<IBaseRepo<GetAboutLabDetailsResponseDTO>, AboutLabDetailsRepo>();

builder.Services.AddScoped(typeof(IBaseDSL<>), typeof(BaseDSL<>));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject custom services
builder.Services.AddSingleton<TokenManager>();
builder.Services.AddScoped<TokenDSL>();

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

app.MapControllers();

app.Run();
/*
void RegisterAssemblies(WebApplicationBuilder builder)
{
    var assemblyNames = new[]
    {
        "LDM_Mobile_Manager.DataService",
        "LDM_Mobile_Manager.Repo",
        "LDM_Mobile_Manager.DataAccess",
        "LDM_Mobile_Manager.Interfaces"
    };

    var assemblies = assemblyNames.Select(Assembly.Load).ToList();
    var allTypes = assemblies.SelectMany(a => a.GetTypes()).ToList();

    var serviceTypes = allTypes
        .Where(t => (t.Name.EndsWith("Repo") || t.Name.EndsWith("DAL") || t.Name.EndsWith("DSL"))
                    && !t.IsInterface && !t.IsAbstract)
        .ToList();

    foreach (var serviceType in serviceTypes)
    {
        builder.Services.AddScoped(serviceType); 
    }

    builder.Services.AddScoped(typeof(IBaseDSL<>), typeof(BaseDSL<>));

    foreach (var repoType in serviceTypes.Where(t => t.Name.EndsWith("Repo")))
    {
        var baseType = repoType.BaseType;

        if (baseType == null || !baseType.IsGenericType)
            continue;

        var dtoType = baseType.GetGenericArguments().FirstOrDefault();
        if (dtoType == null)
            continue;

        var repoInterface = typeof(IBaseRepo<>).MakeGenericType(dtoType);

        builder.Services.AddScoped(repoInterface, repoType);
    }
}*/
