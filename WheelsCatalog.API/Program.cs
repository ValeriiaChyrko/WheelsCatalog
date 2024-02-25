using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using WheelsCatalog.API;
using WheelsCatalog.API.Extensions;
using WheelsCatalog.Application;
using WheelsCatalog.Infrastructure;
using WheelsCatalog.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddPresentationServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyOrigin", p =>
    {
        p.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WheelsCatalog API v1", Version = "v1" });
    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    c.OperationFilter<SecurityRequirementsOperationFilter>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "WheelsCatalog API v1");
    c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();
app.UseErrorHandler();
app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");

app.Run();