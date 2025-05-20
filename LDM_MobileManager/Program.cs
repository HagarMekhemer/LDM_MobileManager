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
builder.Services.AddScoped<IBaseRepository<GetNewsDataResponseDTO>,NewsDataRepository>();
builder.Services.AddScoped<IBaseService<GetNewsDataResponseDTO>, BaseService<GetNewsDataResponseDTO>>();

builder.Services.AddScoped<IBaseRepository<GetPromotionResponseDTO>, PromotionRepository>();
builder.Services.AddScoped<IBaseService<GetPromotionResponseDTO>, BaseService<GetPromotionResponseDTO>>();

builder.Services.AddScoped<IBaseRepository<GetBrochuresResponseDTO>, BrochureRepository>();
builder.Services.AddScoped<IBaseService<GetBrochuresResponseDTO>, BaseService<GetBrochuresResponseDTO>>();

builder.Services.AddScoped<IBaseRepository<GetPressResponseDTO>, PressRepository>();
builder.Services.AddScoped<IBaseService<GetPressResponseDTO>, BaseService<GetPressResponseDTO>>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject custom services
builder.Services.AddSingleton<TokenManager>();
builder.Services.AddScoped<TokenDSL>();

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
