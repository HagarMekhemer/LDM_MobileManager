using LDM_Mobile_Manager.Common.Entities.ResponseDTOs;
using LDM_Mobile_Manager.DataService.Data;
using LDM_Mobile_Manager.DSL;
using LDM_Mobile_Manager.Interfaces.Repositories;
using LDM_Mobile_Manager.Interfaces.Services;
using LDM_Mobile_Manager.LDM_Mobile_Manager.Helper;
using LDM_Mobile_Manager.Repo;
using LDM_Mobile_Manager.Repo.Data;
using Microsoft.AspNetCore.Builder;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IBaseRepo<GetNewsDataResponseDTO>,NewsDataRepo>();
builder.Services.AddScoped<IBaseRepo<GetPromotionResponseDTO>, PromotionRepo>();
builder.Services.AddScoped<IBaseRepo<GetBrochuresResponseDTO>, BrochureRepo>();
builder.Services.AddScoped<IBaseRepo<GetPressResponseDTO>, PressRepo>();
builder.Services.AddScoped<IBaseRepo<GetBranchesResponseDTO>, BranchRepo>();
builder.Services.AddScoped<IBaseRepo<GetFeedbackMailResponseDTO>, FeedbackMailRepo>();
builder.Services.AddScoped<IBaseRepo<GetLabServicesResponseDTO>, LabServicesRepo>();
builder.Services.AddScoped<IBaseRepo<GetAboutLabDetailsResponseDTO>, AboutLabDetailsRepo>();
builder.Services.AddScoped<IBaseRepo<GetBookResponseDTO>, BooksRepo>();
builder.Services.AddScoped<IBaseRepo<GetClientDataVersionResponseDTO>, ClientDataVersionRepo>();
builder.Services.AddScoped<IBaseRepo<GetContactDetailsResponseDTO>, ContactDetailsRepo>();
builder.Services.AddScoped<IBaseRepo<GetGalleryImageResponseDTO>, GalleryRepo>();
builder.Services.AddScoped<IBaseRepo<GetHealthTipResponseDTO>, HealthTipsRepo>();
builder.Services.AddScoped<IBaseRepo<GetNewsletterResponseDTO>, NewslettersRepo>();
builder.Services.AddScoped<IBaseRepo<GetScientificNewsResponseDTO>, ScientificNewsRepo>();


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
