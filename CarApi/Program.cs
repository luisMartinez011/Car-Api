using Amazon.CognitoIdentityProvider;
using CarApi.Data;
using CarApi.Data.Config;
using CarApi.Data.Repositories;
using CarApi.Shared;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;
using System.Net;
using System.IdentityModel.Tokens.Jwt;
using Amazon.Extensions.NETCore.Setup;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(o => {
        o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    })
    .AddFluentValidation(config =>
    {
        config.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }); 


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Verificacion V1",
        //Description = "A demo of a number of concepts for developing an API using ASP.NET Core and Entity Framework",
        
    });

    var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName));
});

var Configuration = builder.Configuration;
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsHistoryTable("_EfMigrations", Configuration.GetSection("Schema").GetSection("User").Value)));

builder.Services.AddHttpClient("httpClient");
builder.Services.AddSingleton<HttpClientRepository>();
builder.Services.AddSingleton<CarConfiguration>();
builder.Services.AddSingleton<CountryConfiguration>();
builder.Services.AddSingleton<BrandConfiguration>();
builder.Services.AddTransient<IAuthRepository, AuthRepository>();


// Aws configuration
//builder.Services.AddAWSService<IAmazonCognitoIdentityProvider>();
builder.Services.AddCognitoIdentity();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    //.AddCookie(cfg => cfg.SlidingExpiration = true)
.AddJwtBearer(options =>
{
    var PoolId = Configuration.GetValue<string>("AWS:UserPoolId");
    var ClientId = Configuration.GetValue<string>("AWS:UserPoolClientId");
    var Region = Configuration.GetValue<string>("AWS:Region");

    options.Authority = $"https://cognito-idp.{Region}.amazonaws.com/{PoolId}";
    options.TokenValidationParameters = new TokenValidationParameters
    {
       
        ValidateIssuer = true,
        ValidIssuer= $"https://cognito-idp.{Region}.amazonaws.com/{PoolId}",
        ValidateLifetime = true,
        LifetimeValidator =(before, expires, token, param) => expires > DateTime.UtcNow,
        
        ValidateAudience = false,
    };
});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Verificacion V1"));

//}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Verificacion V1"));

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

